const input = "";

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
    this.accessModifiers = ["public", "private", "protected", "internal", "protected internal", "private protected", "file"];
    this.modifiers = ["abstract", "async", "const", "new", "override", "partial", "readonly", "sealed", "static", "virtual"];
    this.keywords = ["bool", "byte", "char", "decimal", "double", "float", "int", "long", "object", "sbyte", "short", "string", "uint", "ulong", "ushort", "void", "dynamic"];
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

    if (this.keywords.includes(result)) {
      return { type: 'KEYWORD', value: result };
    }

    if (this.accessModifiers.includes(result)) {
      return { type: 'ACCESS_MODIFIER', value: result };
    }

    if (this.modifiers.includes(result)) {
      return { type: 'MODIFIER', value: result };
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
