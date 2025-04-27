const input = `struct BigStruct
{
    public int A;
    public int B;
    public int C;
    public int D;
    public int E;
}`;

class ASTGenerator {
  constructor(input) {
    this.input = input;
    this.output = this.createStructure();
  }

  createStructure() {
    return {
        type: "Program",
        start: 0,
        end: this.input.length,
        body: [],
        sourceType: "module",
    }
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
  }

  advance() {
    this.position++;
    if (this.position < this.input.length) {
      this.currentChar = this.input[this.position];
    } else {
      this.currentChar = null;
    }
  }

  tokenize() {
    const tokens = [];

    while (this.currentChar !== null) {
      if (/\s/.test(this.currentChar)) {
        this.advance();
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

      // Punctuation
      if (this.currentChar === '{') {
        tokens.push({ type: 'LBRACE', value: '{' });
        this.advance();
        continue;
      }
      if (this.currentChar === '}') {
        tokens.push({ type: 'RBRACE', value: '}' });
        this.advance();
        continue;
      }
      if (this.currentChar === '(') {
        tokens.push({ type: 'LPAREN', value: '(' });
        this.advance();
        continue;
      }
      if (this.currentChar === ')') {
        tokens.push({ type: 'RPAREN', value: ')' });
        this.advance();
        continue;
      }
      if (this.currentChar === '[') {
        tokens.push({ type: 'LBRACKET', value: '[' });
        this.advance();
        continue;
      }
      if (this.currentChar === ']') {
        tokens.push({ type: 'RBRACKET', value: ']' });
        this.advance();
        continue;
      }

      // Symbols
      if (this.currentChar === '=') {
        tokens.push({ type: 'OPERATOR', value: '=' });
        this.advance();
        continue;
      }
      if (this.currentChar === ';') {
        tokens.push({ type: 'PUNCTUATION', value: ';' });
        this.advance();
        continue;
      }
      if (this.currentChar === ',') {
        tokens.push({ type: 'PUNCTUATION', value: ',' });
        this.advance();
        continue;
      }
      if (this.currentChar === '.') {
        tokens.push({ type: 'DOT', value: '.' });
        this.advance();
        continue;
      }

      throw new Error(`Unknown character: ${this.currentChar}`);
    }

    return tokens;
  }

  identifier() {
    let result = '';
    while (this.currentChar !== null && /[a-zA-Z0-9_]/.test(this.currentChar)) {
      result += this.currentChar;
      this.advance();
    }

    if (this.valueTypes.includes(result)) {
      return { type: 'VALUE_TYPE', value: result };
    }

    if (this.referenceTypes.includes(result)) {
      return { type: 'REFERENCE_TYPE', value: result };
    }

    if (this.modifiers.includes(result)) {
      return { type: 'MODIFIER', value: result };
    }

    if (this.statements.includes(result)) {
      return { type: 'STATEMENT', value: result };
    }

    if (this.methodParamters.includes(result)) {
      return { type: 'METHOD_PARAMETER', value: result };
    }

    if (this.namespaces.includes(result)) {
      return { type: 'NAMESPACE', value: result };
    }

    if (this.operators.includes(result)) {
      return { type: 'OPERATOR', value: result };
    }

    if (this.conversions.includes(result)) {
      return { type: 'CONVERSION', value: result };
    }

    if (this.access.includes(result)) {
      return { type: 'ACCESS', value: result };
    }

    if (this.literals.includes(result)) {
      return { type: 'LITERAL', value: result };
    }

    if (this.contextual.includes(result)) {
      return { type: 'CONTEXTUAL', value: result };
    }

    return { type: 'IDENTIFIER', value: result };
  }

  number() {
    let result = '';
    while (this.currentChar !== null && /[0-9]/.test(this.currentChar)) {
      result += this.currentChar;
      this.advance();
    }

    return { type: 'NUMBER', value: Number(result) };
  }
}

const tokens = new Tokenizer(input);
console.log(tokens.tokenize());
