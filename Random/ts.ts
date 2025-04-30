/*
Class: Class
Struct: Type
Interface: Interface
Enum: Enum
Delegate: Type or Interface
*/
namespace show {
  interface test {
      ToString(): string;
      value?: number;
  };

  class Test implements test {
      ToString(): string {
          throw new Error("Method not implemented.");
      }
  }
  enum en {
    Byte = 1,
  };
  en.Byte

  
}
