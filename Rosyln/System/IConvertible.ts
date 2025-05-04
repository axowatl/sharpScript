// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
namespace System {
    // The IConvertible interface represents an object that contains a value. This
    // interface is implemented by the following types in the System namespace:
    // Boolean, Char, SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64,
    // Single, Double, Decimal, DateTime, TimeSpan, and String. The interface may
    // be implemented by other types that are to be considered values. For example,
    // a library of nullable database types could 
    //
    // Note: The interface was originally proposed as IValue.
    //
    // The implementations of IConvertible provided by the System.XXX value classes
    // simply forward to the appropriate Value.ToXXX(YYY) methods (a description of
    // the Value class follows below). In cases where a Value.ToXXX(YYY) method
    // does not exist (because the particular conversion is not supported), the
    // IConvertible implementation should simply throw an InvalidCastException.

    public interface IConvertible
    {
        // Returns the type code of this object. An implementation of this method
        // must not return TypeCode.Empty (which represents a null reference) or
        // TypeCode.Object (which represents an object that doesn't implement the
        // IConvertible interface). An implementation of this method should return
        // TypeCode.DBNull if the value of this object is a database null. For
        // example, a nullable integer type should return TypeCode.DBNull if the
        // value of the object is the database null. Otherwise, an implementation
        // of this method should return the TypeCode that best describes the
        // internal representation of the object.
 
        GetTypeCode(): TypeCode;
 
        // The ToXXX methods convert the value of the underlying object to the
        // given type. If a particular conversion is not supported, the
        // implementation must throw an InvalidCastException. If the value of the
        // underlying object is not within the range of the target type, the
        // implementation must throw an OverflowException.  The 
        // IFormatProvider will be used to get a NumberFormatInfo or similar
        // appropriate service object, and may safely be null.
 
        ToBoolean(provider: IFormatProvider): bool;
        ToChar(provider: IFormatProvider): char;
        ToSByte(provider: IFormatProvider): sbyte;
        ToByte(provider: IFormatProvider): byte;
        ToInt16(provider: IFormatProvider): short;
        ToUInt16(provider: IFormatProvider): ushort;
        ToInt32(provider: IFormatProvider): int;
        ToUInt32(provider: IFormatProvider): uint;
        ToInt64(provider: IFormatProvider): long;
        ToUInt64(provider: IFormatProvider): ulong;
        ToSingle(provider: IFormatProvider): float;
        ToDouble(provider: IFormatProvider): double;
        ToDecimal(provider: IFormatProvider): Decimal;
        ToDateTime(provider: IFormatProvider): DateTime;
        ToString(provider: IFormatProvider): SystemString;
        ToType(conversionType: Type, provider: IFormatProvider): SystemObject;
    }

    public abstract class IConvertibleContract implements IConvertible
    {
        // #region IConvertible Members
        GetTypeCode(): Type
        {
            throw new NotImplementedException();
        }
 
        ToBoolean(provider: IFormatProvider): bool
        {
            throw new NotImplementedException();
        }
 
        ToChar(provider: IFormatProvider): char
        {
            throw new NotImplementedException();
        }
 
        ToSByte(provider: IFormatProvider): sbyte
        {
            throw new NotImplementedException();
        }
 
        ToByte(provider: IFormatProvider): byte
        {
            throw new NotImplementedException();
        }
 
        ToInt16(provider: IFormatProvider): short
        {
            throw new NotImplementedException();
        }
 
        ToUInt16(provider: IFormatProvider): ushort
        {
            throw new NotImplementedException();
        }
 
        ToInt32(provider: IFormatProvider): int
        {
            throw new NotImplementedException();
        }
 
        ToUInt32(provider: IFormatProvider): uint
        {
            throw new NotImplementedException();
        }
 
        ToInt64(provider: IFormatProvider): long
        {
            throw new NotImplementedException();
        }
 
        ToUInt64(provider: IFormatProvider): ulong
        {
            throw new NotImplementedException();
        }
 
        ToSingle(provider: IFormatProvider): float
        {
            throw new NotImplementedException();
        }
 
        ToDouble(provider: IFormatProvider): double
        {
            throw new NotImplementedException();
        }
 
        ToDecimal(provider: IFormatProvider): Decimal
        {
            throw new NotImplementedException();
        }
 
        ToDateTime(provider: IFormatProvider): DateTime
        {
            throw new NotImplementedException();
        }

        ToString(provider: IFormatProvider): SystemString
        {
            Contract.Ensures(Contract.Result<SystemString>() != null);
            throw new NotImplementedException();
        }
 
        ToType(conversionType: Type, provider: IFormatProvider): SystemObject
        {
            throw new NotImplementedException();
        }
 
        // #endregion
    }
}
