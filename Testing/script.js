const displayOutput = document.getElementById('output');

const input = `using s = System.Collections;`;

class ASTGenerator {
  constructor(tokens) {
    this.tokens = tokens;
    this.position = 0;
  }

  advance() {
    this.position++;
  }

  get currentToken() {
    return this.tokens[this.position];
  }

  peek(amount = 1) {
    return this.tokens[this.position + amount];
  }

  parse() {
    const program = {
      type: "Program",
      body: []
    };

    while (this.position < this.tokens.length) {
      const stmt = this.parseStatement();
      if (stmt) program.body.push(stmt);
    }

    return program;
  }

  parseStatement() {
    if (this.currentToken.type === 'NAMESPACE') {
      return this.parseNamespace();
    }

    throw new Error(`Unexpected token: ${this.currentToken.value}`);
  }

  parseNamespace() {
    
  }
}

class Tokenizer {
  constructor(input) {
    this.input = input;
    this.position = 0;
    this.currentChar = this.input[this.position];
    this.valueTypes = ["bool", "byte", "char", "decimal", "double", "enum", "float", "int", "long", "sbyte", "short", "struct", "uint", "ulong", "ushort"];
    this.referenceTypes = ["class", "delegate", "interface", "object", "string"];
    this.modifiers = ["public", "private", "internal", "protected", "abstract", "const", "event", "extern", "new", "override", "partial", "readonly", "sealed", "static", "unsafe", "virtual", "volatile"];
    this.statements = ["if", "else", "switch", "do", "for", "foreach", "in", "while", "break", "continue", "goto", "return", "throw", "try", "catch", "finally", "checked", "unchecked"];
    this.methodParamters = ["params", "in", "ref", "out"];
    this.namespaces = ["namespace", "using", "extern"];
    this.operators = ["as", "is", "new", "sizeof", "typeof", "true", "false", "stackalloc"];
    this.conversions = ["explicit", "implicit", "operator"];
    this.access = ["base", "this"];
    this.literals = ["null", "default"];
    this.contextual = ["add", "equals", "nameof", "value", "alias", "from", "on", "var", "ascending", "get", "orderby", "when", "async", "global", "where", "await", "group", "partial", "yield", "by", "into", "remove", "descending", "join", "select", "dynamic", "let", "set"];
    this.preprocessorDirectives = ["#define", "#undef", "#if", "#else", "#elif", "#endif", "#region", "#endregion", "#warning", "#error", "#line"];    
  }

  advance() {
    this.position++;
    if (this.position < this.input.length) {
      this.currentChar = this.input[this.position];
    } else {
      this.currentChar = null;
    }
  }

  peek(amount = 1) {
    const nextPos = this.position + amount;
    return nextPos < this.input.length ? this.input[nextPos] : null;
  }

  skipWhitespace() {
    while (this.currentChar !== null && /\s/.test(this.currentChar)) {
      this.advance();
    }
  }

  skipComment() {
    // Single-line comment
    if (this.currentChar === '/' && this.peek() === '/') {
      while (this.currentChar !== null && this.currentChar !== '\n') {
        this.advance();
      }
    }
    // Multi-line comment
    else if (this.currentChar === '/' && this.peek() === '*') {
      this.advance(); // skip '/'
      this.advance(); // skip '*'
      while (this.currentChar !== null) {
        if (this.currentChar === '*' && this.peek() === '/') {
          this.advance();
          this.advance();
          break;
        }
        this.advance();
      }
    }
  }

  tokenize() {
    const tokens = [];

    while (this.currentChar !== null) {
      this.skipWhitespace();
      if (this.currentChar === '/' && (this.peek() === '/' || this.peek() === '*')) {
        this.skipComment();
        continue;
      }
      if (this.currentChar === null) break;

      if (this.currentChar === '#') {
        let directive = this.preprocessorDirective();
        tokens.push({ type: 'PREPROCESSOR_DIRECTIVE', value: directive });
        continue;
      }

      if (/[a-zA-Z_]/.test(this.currentChar)) {
        tokens.push(this.identifier());
        continue;
      }

      if (/[0-9]/.test(this.currentChar)) {
        tokens.push(this.number());
        continue;
      }

      if (this.currentChar === '"' || this.currentChar === "'") {
        tokens.push(this.string());
        continue;
      }

      const fourCharOp = this.currentChar + this.peek() + this.peek(2) + this.peek(3);
      if (['>>>='].includes(fourCharOp)) {
        tokens.push({ type: 'OPERATOR', value: fourCharOp });
        this.advance(); this.advance(); this.advance(); this.advance();
        continue;
      }

      const threeCharOp = this.currentChar + this.peek() + this.peek(2);
      if (['>>>', '<<=', '>>=', '??='].includes(threeCharOp)) {
        tokens.push({ type: 'OPERATOR', value: threeCharOp });
        this.advance(); this.advance(); this.advance();
        continue;
      }

      const twoCharOp = this.currentChar + this.peek();
      if ([
        '==', '!=', '>=', '<=', '&&', '||', '<<', '>>',
        '+=', '-=', '*=', '/=', '%=', '&=', '|=', '^=',
        '??', '->', '=>', '++', '--', '..'
      ].includes(twoCharOp)) {
        tokens.push({ type: 'OPERATOR', value: twoCharOp });
        this.advance(); this.advance();
        continue;
      }

      if (['$@', '@$'].includes(twoCharOp)) {
        tokens.push({ type: 'INTERPOLATED', value: twoCharOp });
        this.advance(); this.advance();
        continue;
      }

      switch (this.currentChar) {
        case '{': tokens.push({ type: 'LBRACE', value: '{' }); break;
        case '}': tokens.push({ type: 'RBRACE', value: '}' }); break;
        case '(': tokens.push({ type: 'LPAREN', value: '(' }); break;
        case ')': tokens.push({ type: 'RPAREN', value: ')' }); break;
        case '[': tokens.push({ type: 'LBRACKET', value: '[' }); break;
        case ']': tokens.push({ type: 'RBRACKET', value: ']' }); break;
        case ';': tokens.push({ type: 'SEMICOLON', value: ';' }); break;
        case ',': tokens.push({ type: 'COMMA', value: ',' }); break;
        case '.': tokens.push({ type: 'DOT', value: '.' }); break;
        case '+': tokens.push({ type: 'OPERATOR', value: '+' }); break;
        case '-': tokens.push({ type: 'OPERATOR', value: '-' }); break;
        case '*': tokens.push({ type: 'OPERATOR', value: '*' }); break;
        case '/': tokens.push({ type: 'OPERATOR', value: '/' }); break;
        case '%': tokens.push({ type: 'OPERATOR', value: '%' }); break;
        case '=': tokens.push({ type: 'OPERATOR', value: '=' }); break;
        case '<': tokens.push({ type: 'OPERATOR', value: '<' }); break;
        case '>': tokens.push({ type: 'OPERATOR', value: '>' }); break;
        case '!': tokens.push({ type: 'OPERATOR', value: '!' }); break;
        case '&': tokens.push({ type: 'OPERATOR', value: '&' }); break;
        case '~': tokens.push({ type: 'OPERATOR', value: '~' }); break;
        case '|': tokens.push({ type: 'OPERATOR', value: '|' }); break;
        case '^': tokens.push({ type: 'OPERATOR', value: '^' }); break;
        case '?': tokens.push({ type: 'QUESTION', value: '?' }); break;
        case ':': tokens.push({ type: 'COLON', value: ':' }); break;
        case '$': tokens.push({ type: 'INTERPOLATED', value: '$' }); break;
        default:
          throw new Error(`Unknown character: ${this.currentChar}`);
      }

      this.advance();
    }

    return tokens;
  }

  identifier() {
    let result = '';
    while (this.currentChar !== null && /[a-zA-Z0-9_]/.test(this.currentChar)) {
      result += this.currentChar;
      this.advance();
    }

    if (this.valueTypes.includes(result)) return { type: 'VALUE_TYPE', value: result };
    if (this.referenceTypes.includes(result)) return { type: 'REFERENCE_TYPE', value: result };
    if (this.modifiers.includes(result)) return { type: 'MODIFIER', value: result };
    if (this.statements.includes(result)) return { type: 'STATEMENT', value: result };
    if (this.methodParamters.includes(result)) return { type: 'METHOD_PARAMETER', value: result };
    if (this.namespaces.includes(result)) return { type: 'NAMESPACE', value: result };
    if (this.operators.includes(result)) return { type: 'OPERATOR', value: result };
    if (this.conversions.includes(result)) return { type: 'CONVERSION', value: result };
    if (this.access.includes(result)) return { type: 'ACCESS', value: result };
    if (this.literals.includes(result)) return { type: 'LITERAL', value: result };
    if (this.contextual.includes(result)) return { type: 'CONTEXTUAL', value: result };

    return { type: 'IDENTIFIER', value: result };
  }

  number() {
    let result = '';
    let hasDot = false;

    while (this.currentChar !== null && /[0-9\.]/.test(this.currentChar)) {
      if (this.currentChar === '.') {
        if (hasDot) break; // second dot? stop
        hasDot = true;
      }
      result += this.currentChar;
      this.advance();
    }

    return { type: 'NUMBER', value: hasDot ? parseFloat(result) : parseInt(result, 10) };
  }

  string() {
    const quoteType = this.currentChar; // ' or "
    let result = '';
    this.advance(); // skip opening quote

    while (this.currentChar !== null && this.currentChar !== quoteType) {
      if (this.currentChar === '\\') { // escape sequences
        this.advance();
        if (this.currentChar !== null) {
          result += '\\' + this.currentChar;
          this.advance();
        }
      } else {
        result += this.currentChar;
        this.advance();
      }
    }

    if (this.currentChar !== quoteType) {
      throw new Error(`Unterminated string literal`);
    }

    this.advance(); // skip closing quote
    return { type: 'STRING', value: result };
  }

  preprocessorDirective() {
    let result = '';
    this.advance(); // Skip the '#' character
    while (this.currentChar !== null && /\w/.test(this.currentChar)) {
      result += this.currentChar;
      this.advance();
    }
  
    // Check if the directive is a valid known directive
    if (!this.preprocessorDirectives.includes(result)) {
      throw new Error(`Unknown preprocessor directive: ${result}`);
    }
  
    return result;
  }  
}

const tokenizer = new Tokenizer(input);
const tokens = tokenizer.tokenize();
console.log('Tokens:', tokens);
const ASTGen = new ASTGenerator(tokens);
const AST = ASTGen.parse();
console.log('AST:', JSON.stringify(AST, null, 2));
displayOutput.innerHTML = JSON.stringify(AST, null, 2);
