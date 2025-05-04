// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Class:  Int32
**
**
** Purpose: A representation of a 32 bit 2's complement 
**          integer.
**
** 
===========================================================*/
namespace System {
    private class Int32 implements IComparable, IFormattable, IConvertible, IComparable<Int32>, IEquatable<Int32>, IArithmetic<Int32>
    {
        private m_value: number;
    
        public static get MaxValue(): int { return new int(0x7fffffff); }
        public static get MinValue(): int { return new int(0x80000000 | 0); }

        constructor(value: int);
        constructor(value: number);

        constructor(value: int | number) {
            if (value instanceof int) {
                this.m_value = value.m_value;
            } else {
                this.m_value = value | 0;
            }
        }
    
        // Compares this object to another object, returning an integer that
        // indicates the relationship. 
        // Returns a value less than zero if this  object
        // null is considered to be less than any instance.
        // If object is not of type Int32, this method throws an ArgumentException.
        // 
        public CompareTo(value: int): int;
        public CompareTo(value: number): int;

        public CompareTo(value: int | number): int {
            if (value == null) {
                return new int(1);
            }
            if (value instanceof int) {
                if (this.m_value < value.m_value) { return new int(-1); }
                if (this.m_value > value.m_value) { return new int(1); }
                return new int(0);
            }
            if (this.m_value < value) { return new int(-1); }
            if (this.m_value > value) { return new int(1); }
            return new int(0);
        }

        public override Equals(obj: int): bool;
        public override Equals(obj: number): bool;

        public override Equals(obj: int | number): bool {
            if (obj instanceof int) { return new bool(this.m_value == obj.m_value); }
            return new bool(this.m_value == obj);
        }
 
        // The absolute value of the int contained.
        public override GetHashCode(): int {
            return this;
        }

        public override ToString(): SystemString;
        public override ToString(format: SystemString): SystemString;
        public override ToString(provider: IFormatProvider): SystemString;
        public override ToString(format: SystemString, provider: IFormatProvider): SystemString;

        public override ToString(arg1?: SystemString | IFormatProvider, arg2?: IFormatProvider): SystemString {
            if (arg1 instanceof SystemString && arg2 instanceof IFormatProvider) {
                Contract.Ensures(Contract.Result<SystemString>() != null);
                return Number.FormatInt32(this.m_value, arg1, NumberFormatInfo.GetInstance(arg2));
            } else if (arg1 instanceof SystemString) {
                Contract.Ensures(Contract.Result<SystemString>() != null);
                return Number.FormatInt32(this.m_value, arg1, NumberFormatInfo.CurrentInfo);
            } else if (arg1 instanceof IFormatProvider) {
                Contract.Ensures(Contract.Result<SystemString>() != null);
                return Number.FormatInt32(this.m_value, null, NumberFormatInfo.GetInstance(arg1));
            } else {
                Contract.Ensures(Contract.Result<SystemString>() != null);
                return Number.FormatInt32(this.m_value, null, NumberFormatInfo.CurrentInfo);
            }
        }

        public static Parse(s: SystemString): int;
        public static Parse(s: SystemString, style: NumberStyles): int;
        public static Parse(s: SystemString, provider: IFormatProvider): int;
        public static Parse(s: SystemString, style: NumberStyles, provider: IFormatProvider): int;

        public static Parse(s: SystemString, arg2?: NumberStyles | IFormatProvider, arg3?: IFormatProvider): int {
            if (arg2 instanceof NumberStyles && arg3 instanceof IFormatProvider) {
                NumberFormatInfo.ValidateParseStyleInteger(arg2);
                return Number.ParseInt32(s, arg2, NumberFormatInfo.GetInstance(arg3)); 
            } else if (arg2 instanceof NumberStyles) {
                NumberFormatInfo.ValidateParseStyleInteger(arg2);
                return Number.ParseInt32(s, arg2, NumberFormatInfo.CurrentInfo);
            } else if (arg2 instanceof IFormatProvider) {
                return Number.ParseInt32(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(arg2));
            } else {
                return Number.ParseInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
            }
        }

        public static TryParse(s: SystemString, result: int): { b: bool, result: int };
        public static TryParse(s: SystemString, style: NumberStyles, provider: IFormatProvider, result: int): { b: bool, result: int };

        public static TryParse(s: SystemString, arg2: NumberStyles | int, provider: IFormatProvider, result: int): { b: bool, result: int} {
            if (arg2 instanceof int) {
                return Number.TryParseInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, result);
            } else {
                NumberFormatInfo.ValidateParseStyleInteger(arg2);
                return Number.TryParseInt32(s, arg2, NumberFormatInfo.GetInstance(provider), result);
            }
        }
 
        //
        // IConvertible implementation
        // 

        public GetTypeCode(): TypeCode {
            return TypeCode.Int32;
        }
 
        /// <internalonly/>
        public ToBoolean(provider: IFormatProvider): bool {
            return Convert.ToBoolean(this.m_value);
        }
 
        /// <internalonly/>
        public ToChar(provider: IFormatProvider): char {
            return Convert.ToChar(m_value);
        }
 
        /// <internalonly/>
        public ToSByte(provider: IFormatProvider): sbyte {
            return Convert.ToSByte(m_value);
        }
 
        /// <internalonly/>
        public ToByte(provider: IFormatProvider): byte {
            return Convert.ToByte(m_value);
        }
 
        /// <internalonly/>
        public ToInt16(provider: IFormatProvider): short {
            return Convert.ToInt16(m_value);
        }
 
        /// <internalonly/>
        public ToUInt16(provider: IFormatProvider): ushort {
            return Convert.ToUInt16(m_value);
        }
 
        /// <internalonly/>
        public ToInt32(provider: IFormatProvider): int {
            return m_value;
        }
 
        /// <internalonly/>
        public ToUInt32(provider: IFormatProvider): uint {
            return Convert.ToUInt32(m_value);
        }
 
        /// <internalonly/>
        public ToInt64(provider: IFormatProvider): long {
            return Convert.ToInt64(m_value);
        }
 
        /// <internalonly/>
        public ToUInt64(provider: IFormatProvider): ulong {
            return Convert.ToUInt64(m_value);
        }
 
        /// <internalonly/>
        public ToSingle(provider: IFormatProvider): float {
            return Convert.ToSingle(m_value);
        }
 
        /// <internalonly/>
        public ToDouble(provider: IFormatProvider): double {
            return Convert.ToDouble(m_value);
        }
 
        /// <internalonly/>
        public ToDecimal(provider: IFormatProvider): decimal {
            return Convert.ToDecimal(m_value);
        }
 
        /// <internalonly/>
        public ToDateTime(provider: IFormatProvider): dateTime {
            throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Int32", "DateTime"));
        }
 
        /// <internalonly/>
        public ToType(type: Type, provider: IFormatProvider): SystemObject {
            return Convert.DefaultToType(this, type, provider);
        }

        //
        // IArithmetic<Int32> implementation
        //

        /// <internalonly/>
        public AbsoluteValue(): { value: int, overflowed: bool } {
            const overflowed = this.m_value === int.MinValue;
            const abs = overflowed ? this.m_value : Math.abs(this.m_value);
            return {
                value: new Int32(abs),
                overflowed: new bool(overflowed),
            };
        }

        /// <internalonly/>
        public Negate(): { value: int, overflowed: bool } {
            const overflowed = this.m_value === int.MinValue; // Negate(MinValue) overflows
            return new int(-this.m_value);
        }

        /// <internalonly/>
        public Sign(): { value: int, overflowed: bool } {
            const overflowed: bool = new bool(false);
            return new int(this.m_value >= 0 ? (this.m_value == 0 ? 0 : 1) : -1);
        }

        /// <internalonly/>
        public Add(addend: int): { value: int, overflowed: bool } {
            const l: long = new long(this.m_value + addend.m_value);
            const overflowed: bool = new bool(l.m_value > int.MaxValue || l.m_value < int.MinValue);
            return { value: new int(l.m_value), overflowed: overflowed };
        }

        /// <internalonly/>
        public Subtract(subtrahend: int): { value: int, overflowed: bool } {
            const l: long = new long(this.m_value - subtrahend.m_value);
            const overflowed: bool = (l.m_value > int.MaxValue || l.m_value < int.MinValue);
            return { value: new int(l.m_value), overflowed: overflowed };
        }

        /// <internalonly/>
        public Multiply(multiplier: int): { value: int, overflowed: bool } {
            const l: long = new long(this.m_value * multiplier.m_value);
            const overflowed: bool = new bool(l.m_value > int.MaxValue || l.m_value < int.MinValue);
            return { value: new int(l.m_value), overflowed: overflowed };
        }


        /// <internalonly/>
        public Divide(divisor: int): { value: int, overflowed: bool } {
            // signed integer division can overflow.  Consider the following
            // 8-bit case: -128/-1 = 128.
            // 128 won't fit into a signed 8-bit integer, instead you will end up
            // with -128.
            //
            // Because of this corner case, we must check if the numerator
            // is MinValue and if the denominator is -1.

            const overflowed: bool = new bool(divisor.m_value == -1 && this.m_value == int.MinValue);

            if (overflowed.m_value) {
                // we special case (MinValue / (-1)) for Int32 and Int64 as
                // unchecked still throws OverflowException when variables
                // are used instead of constants
                return int.MinValue;
            }
            else {
                return new int(this.m_value / divisor.m_value);   
            }
        }

        /// <internalonly/>
        public DivideRemainder(divisor: int): {value: int, remainder: int, overflowed: bool } {
            const overflowed: bool = new bool(divisor.m_value == -1 && this.m_value == int.MinValue);

            if (overflowed.m_value) {
                // we special case (MinValue / (-1)) for Int32 and Int64 as
                // unchecked still throws OverflowException when variables
                // are used instead of constants
                return { value: int.MinValue, remainder: new int(0), overflowed: overflowed };
            }
            else {
                return { value: new int(this.m_value / divisor.m_value), remainder: (this.m_value % divisor.m_value), overflowed: overflowed };
            }  
        }

        /// <internalonly/>
        public Remainder(divisor: int): { value: int, overflowed: bool } {
            const overflowed: bool = new bool(false);

            if (divisor.m_value == -1 && this.m_value == int.MinValue) {
                // we special case (MinValue % (-1)) for Int32 and Int64 as
                // unchecked still throws OverflowException when variables
                // are used instead of constants
                return { value: 0, overflowed: overflowed };
            }
            else {
                return { value: new int(this.m_value % divisor.m_value), overflowed: overflowed };
            }
        }

        /// <internalonly/>
        public GetDescriptor(): ArithmeticDescriptor<Int32> {
            if (this.s_descriptor == null) {
                this.s_descriptor = new Int32ArithmeticDescriptor(ArithmeticCapabilities.One | ArithmeticCapabilities.Zero | ArithmeticCapabilities.MaxValue | ArithmeticCapabilities.MinValue);
            }
            return this.s_descriptor;
        }

        private s_descriptor: Int32ArithmeticDescriptor = this.GetDescriptor();
 
        public Int32ArithmeticDescriptor = class Int32ArithmeticDescriptor implements ArithmeticDescriptor<Int32> {
            constructor(capabilities: ArithmeticCapabilities) {
                super(capabilities);
            }

            public override get One(): int {
                return new int(1);
            }

            public override get Zero(): int {
                return new int(0)
            }

            public override get MinValue(): int {
                return int.MinValue;
            }

            public override get MaxValue(): int {
                return int.MaxValue;
            }
        }
    }

    export type int = Int32;
    export const int = Int32;
}