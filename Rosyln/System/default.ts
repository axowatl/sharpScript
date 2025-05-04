/*
Custom implementation of the default() function.
No source code was found.
*/

namespace System {
    const defaultMap = new Map<string, () => any>([
        ['Bool', () => new Bool(false)],
        ['Byte', () => new Byte(0)],
        ['Char', () => new Char('\0')],
        ['Decimal', () => new Decimal(0)],
        ['Double', () => new Double(0)],
        ['Single', () => new Single(0)],
        ['Int16', () => new Int16(0)],
        ['Int32', () => new Int32(0)],
        ['Int64', () => new Int64(0)],
        ['SByte', () => new SByte(0)],
        ['UInt16', () => new UInt16(0)],
        ['UInt32', () => new UInt32(0)],
        ['UInt64', () => new UInt64(0)],
    ]);
    
    export function registerDefault<T>(name: string, factory: () => T) {
        defaultMap.set(name, factory);
    }
    
    export function DEFAULT<T>(ctor: new (...args: any[]) => T): T | null {
        const factory = defaultMap.get(ctor.name);
        if (factory) return factory();
        try {
            return new ctor();
        } catch {
            return null;
        }
    }       
}
