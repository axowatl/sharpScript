// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
 
namespace System {
    // This file defines an internal class used to throw exceptions in BCL code.
    // The main purpose is to reduce code size. 
    // 
    // The old way to throw an exception generates quite a lot IL code and assembly code.
    // Following is an example:
    //     C# source
    //          throw new ArgumentNullException("key", Environment.GetResourceString("ArgumentNull_Key"));
    //     IL code:
    //          IL_0003:  ldstr      "key"
    //          IL_0008:  ldstr      "ArgumentNull_Key"
    //          IL_000d:  call       string System.Environment::GetResourceString(string)
    //          IL_0012:  newobj     instance void System.ArgumentNullException::.ctor(string,string)
    //          IL_0017:  throw
    //    which is 21bytes in IL.
    // 
    // So we want to get rid of the ldstr and call to Environment.GetResource in IL.
    // In order to do that, I created two enums: ExceptionResource, ExceptionArgument to represent the
    // argument name and resource name in a small integer. The source code will be changed to 
    //    ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key, ExceptionResource.ArgumentNull_Key);
    //
    // The IL code will be 7 bytes.
    //    IL_0008:  ldc.i4.4
    //    IL_0009:  ldc.i4.4
    //    IL_000a:  call       void System.ThrowHelper::ThrowArgumentNullException(valuetype System.ExceptionArgument)
    //    IL_000f:  ldarg.0
    //
    // This will also reduce the Jitted code size a lot. 
    //
    // It is very important we do this for generic classes because we can easily generate the same code 
    // multiple times for different instantiation.
    //
    // The convention for this enum is using the argument name as the enum name
    // 
    export enum ExceptionArgument {
        obj,
        dictionary,
        dictionaryCreationThreshold,
        array,
        info,
        key,
        collection,
        list,
        match,
        converter,
        queue,
        stack,
        capacity,
        index,
        startIndex,
        value,
        count,
        arrayIndex,
        name,
        mode,
        item,
        options,
        view,
        sourceBytesToCopy,
    }
 
    //
    // The convention for this enum is using the resource name as the enum name
    // 
    export enum ExceptionResource {
        Argument_ImplementIComparable,
        Argument_InvalidType,     
        Argument_InvalidArgumentForComparison,
        Argument_InvalidRegistryKeyPermissionCheck,        
        ArgumentOutOfRange_NeedNonNegNum,
        
        Arg_ArrayPlusOffTooSmall,
        Arg_NonZeroLowerBound,        
        Arg_RankMultiDimNotSupported,        
        Arg_RegKeyDelHive,
        Arg_RegKeyStrLenBug,  
        Arg_RegSetStrArrNull,
        Arg_RegSetMismatchedKind,
        Arg_RegSubKeyAbsent,        
        Arg_RegSubKeyValueAbsent,
        
        Argument_AddingDuplicate,
        Serialization_InvalidOnDeser,
        Serialization_MissingKeys,
        Serialization_NullKey,
        Argument_InvalidArrayType,
        NotSupported_KeyCollectionSet,
        NotSupported_ValueCollectionSet,
        ArgumentOutOfRange_SmallCapacity,
        ArgumentOutOfRange_Index,
        Argument_InvalidOffLen,
        Argument_ItemNotExist,
        ArgumentOutOfRange_Count,
        ArgumentOutOfRange_InvalidThreshold,
        ArgumentOutOfRange_ListInsert,
        NotSupported_ReadOnlyCollection,
        InvalidOperation_CannotRemoveFromStackOrQueue,
        InvalidOperation_EmptyQueue,
        InvalidOperation_EnumOpCantHappen,
        InvalidOperation_EnumFailedVersion,
        InvalidOperation_EmptyStack,
        ArgumentOutOfRange_BiggerThanCollection,
        InvalidOperation_EnumNotStarted,
        InvalidOperation_EnumEnded,
        NotSupported_SortedListNestedWrite,
        InvalidOperation_NoValue,
        InvalidOperation_RegRemoveSubKey,
        Security_RegistryPermission,
        UnauthorizedAccess_RegistryNoWrite,
        ObjectDisposed_RegKeyClosed,
        NotSupported_InComparableType,
        Argument_InvalidRegistryOptionsCheck,
        Argument_InvalidRegistryViewCheck
    }

    export class ThrowHelper {

        public static ThrowArgumentOutOfRangeException(): void;
        public static ThrowArgumentOutOfRangeException(argument: ExceptionArgument): void;
        public static ThrowArgumentOutOfRangeException(argument: ExceptionArgument, resource: ExceptionResource): void;

        public static ThrowArgumentOutOfRangeException(argument?: ExceptionArgument, resource?: ExceptionResource): void {
            if (!argument && !resource) {
                ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
            } else if (!resource) {
                throw new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument));
            } else {
                if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8) {
                    // Dev11 474369 quirk: Mango had an empty message string:
                    throw new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument), SystemString.Empty);                                                  
                } else {
                    throw new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument), Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
                }    
            }
        }
 
        public static ThrowWrongKeyTypeArgumentException(key: SystemObject, targetType: Type): void {
            throw new ArgumentException(Environment.GetResourceString("Arg_WrongType", key, targetType), "key");
        }
 
        public static ThrowWrongValueTypeArgumentException(value: SystemObject, targetType: Type): void {
            throw new ArgumentException(Environment.GetResourceString("Arg_WrongType", value, targetType), "value");
        }
 
        public static ThrowKeyNotFoundException(): void {
            throw new System.Collections.Generic.KeyNotFoundException();
        }

        public static ThrowArgumentException(resource: ExceptionResource): void;
        public static ThrowArgumentException(resource: ExceptionResource, argument: ExceptionArgument): void;

        public static ThrowArgumentException(resource: ExceptionResource, argument?: ExceptionArgument): void {
            if (!argument) {
                throw new ArgumentException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
            } else {
                throw new ArgumentException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)), ThrowHelper.GetArgumentName(argument));
            }
        }
 
        public static ThrowArgumentNullException(argument: ExceptionArgument): void {
            throw new ArgumentNullException(ThrowHelper.GetArgumentName(argument));
        }
 
        public static ThrowInvalidOperationException(resource: ExceptionResource): void {
            throw new InvalidOperationException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
        }
 
        public static ThrowSerializationException(resource: ExceptionResource): void {
            throw new SerializationException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
        }
 
        public static ThrowSecurityException(resource: ExceptionResource): void {
            throw new System.Security.SecurityException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));            
        }
 
        public static ThrowNotSupportedException(resource: ExceptionResource): void {
            throw new NotSupportedException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
        }
 
        public static ThrowUnauthorizedAccessException(resource: ExceptionResource) {
            throw new UnauthorizedAccessException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
        }
 
        public static ThrowObjectDisposedException(objectName: SystemString, resource: ExceptionResource): void {
            throw new ObjectDisposedException(objectName, Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
        }
 
        // Allow nulls for reference types and Nullable<U>, but not for value types.
        public static IfNullAndNullsAreIllegalThenThrow<T>(value: SystemObject, argName: ExceptionArgument, ctor: new (...args: any[]) => T): void {
            // Note that default(T) is not equal to null for value types except when T is Nullable<U>.
            if (value == null && !(DEFAULT<T>(ctor) == null)) {
                ThrowHelper.ThrowArgumentNullException(argName);
            }
        }
 
        //
        // This function will convert an ExceptionArgument enum value to the argument name string.
        //
        public static GetArgumentName(argument: ExceptionArgument): SystemString {
            let argumentName: SystemString = null;
 
            switch (argument) {
                case ExceptionArgument.array:
                    argumentName = "array";
                    break;
 
                case ExceptionArgument.arrayIndex:
                    argumentName = "arrayIndex";
                    break;
 
                case ExceptionArgument.capacity:
                    argumentName = "capacity";
                    break;
 
                case ExceptionArgument.collection:
                    argumentName = "collection";
                    break;
 
                case ExceptionArgument.list:
                    argumentName = "list";
                    break;
 
                case ExceptionArgument.converter:
                    argumentName = "converter";
                    break;
 
                case ExceptionArgument.count:
                    argumentName = "count";
                    break;
 
                case ExceptionArgument.dictionary:
                    argumentName = "dictionary";
                    break;
 
                case ExceptionArgument.dictionaryCreationThreshold:
                    argumentName = "dictionaryCreationThreshold";
                    break;
 
                case ExceptionArgument.index:
                    argumentName = "index";
                    break;
 
                case ExceptionArgument.info:
                    argumentName = "info";
                    break;
 
                case ExceptionArgument.key:
                    argumentName = "key";
                    break;
 
                case ExceptionArgument.match:
                    argumentName = "match";
                    break;
 
                case ExceptionArgument.obj:
                    argumentName = "obj";
                    break;
 
                case ExceptionArgument.queue:
                    argumentName = "queue";
                    break;
 
                case ExceptionArgument.stack:
                    argumentName = "stack";
                    break;
 
                case ExceptionArgument.startIndex:
                    argumentName = "startIndex";
                    break;
 
                case ExceptionArgument.value:
                    argumentName = "value";
                    break;
 
                case ExceptionArgument.name:
                    argumentName = "name";
                    break;
 
                case ExceptionArgument.mode:
                    argumentName = "mode";
                    break;
 
                case ExceptionArgument.item:
                    argumentName = "item";
                    break;
 
                case ExceptionArgument.options:
                    argumentName = "options";
                    break;
 
                case ExceptionArgument.view:
                    argumentName = "view";
                    break;
 
               case ExceptionArgument.sourceBytesToCopy:
                    argumentName = "sourceBytesToCopy";
                    break;
 
                default:
                    Contract.Assert(false, "The enum value is not defined, please checked ExceptionArgumentName Enum.");
                    return SystemString.Empty;
            }
 
            return argumentName;
        }
 
        //
        // This function will convert an ExceptionResource enum value to the resource string.
        //
        public static GetResourceName(resource: ExceptionResource): SystemString {
            let resourceName: SystemString = null;
 
            switch (resource) {
                case ExceptionResource.Argument_ImplementIComparable:
                    resourceName = "Argument_ImplementIComparable";
                    break;
 
                case ExceptionResource.Argument_AddingDuplicate:
                    resourceName = "Argument_AddingDuplicate";
                    break;
 
                case ExceptionResource.ArgumentOutOfRange_BiggerThanCollection:
                    resourceName = "ArgumentOutOfRange_BiggerThanCollection";
                    break;
 
                case ExceptionResource.ArgumentOutOfRange_Count:
                    resourceName = "ArgumentOutOfRange_Count";
                    break;
 
                case ExceptionResource.ArgumentOutOfRange_Index:
                    resourceName = "ArgumentOutOfRange_Index";
                    break;
 
                case ExceptionResource.ArgumentOutOfRange_InvalidThreshold:
                    resourceName = "ArgumentOutOfRange_InvalidThreshold";
                    break;
 
                case ExceptionResource.ArgumentOutOfRange_ListInsert:
                    resourceName = "ArgumentOutOfRange_ListInsert";
                    break;
 
                case ExceptionResource.ArgumentOutOfRange_NeedNonNegNum:
                    resourceName = "ArgumentOutOfRange_NeedNonNegNum";
                    break;
 
                case ExceptionResource.ArgumentOutOfRange_SmallCapacity:
                    resourceName = "ArgumentOutOfRange_SmallCapacity";
                    break;
 
                case ExceptionResource.Arg_ArrayPlusOffTooSmall:
                    resourceName = "Arg_ArrayPlusOffTooSmall";
                    break;
 
                case ExceptionResource.Arg_RankMultiDimNotSupported:
                    resourceName = "Arg_RankMultiDimNotSupported";
                    break;
 
                case ExceptionResource.Arg_NonZeroLowerBound:
                    resourceName = "Arg_NonZeroLowerBound";
                    break;
 
                case ExceptionResource.Argument_InvalidArrayType:
                    resourceName = "Argument_InvalidArrayType";
                    break;
 
                case ExceptionResource.Argument_InvalidOffLen:
                    resourceName = "Argument_InvalidOffLen";
                    break;
 
                case ExceptionResource.Argument_ItemNotExist:
                    resourceName = "Argument_ItemNotExist";
                    break;                    
 
                case ExceptionResource.InvalidOperation_CannotRemoveFromStackOrQueue:
                    resourceName = "InvalidOperation_CannotRemoveFromStackOrQueue";
                    break;
 
                case ExceptionResource.InvalidOperation_EmptyQueue:
                    resourceName = "InvalidOperation_EmptyQueue";
                    break;
 
                case ExceptionResource.InvalidOperation_EnumOpCantHappen:
                    resourceName = "InvalidOperation_EnumOpCantHappen";
                    break;
 
                case ExceptionResource.InvalidOperation_EnumFailedVersion:
                    resourceName = "InvalidOperation_EnumFailedVersion";
                    break;
 
                case ExceptionResource.InvalidOperation_EmptyStack:
                    resourceName = "InvalidOperation_EmptyStack";
                    break;
 
                case ExceptionResource.InvalidOperation_EnumNotStarted:
                    resourceName = "InvalidOperation_EnumNotStarted";
                    break;
 
                case ExceptionResource.InvalidOperation_EnumEnded:
                    resourceName = "InvalidOperation_EnumEnded";
                    break;
 
                case ExceptionResource.NotSupported_KeyCollectionSet:
                    resourceName = "NotSupported_KeyCollectionSet";
                    break;
 
                case ExceptionResource.NotSupported_ReadOnlyCollection:
                    resourceName = "NotSupported_ReadOnlyCollection";
                    break;
 
                case ExceptionResource.NotSupported_ValueCollectionSet:
                    resourceName = "NotSupported_ValueCollectionSet";
                    break;
 
 
                case ExceptionResource.NotSupported_SortedListNestedWrite:
                    resourceName = "NotSupported_SortedListNestedWrite";
                    break;
 
 
                case ExceptionResource.Serialization_InvalidOnDeser:
                    resourceName = "Serialization_InvalidOnDeser";
                    break;
 
                case ExceptionResource.Serialization_MissingKeys:
                    resourceName = "Serialization_MissingKeys";
                    break;
 
                case ExceptionResource.Serialization_NullKey:
                    resourceName = "Serialization_NullKey";
                    break;
 
                case ExceptionResource.Argument_InvalidType:
                    resourceName = "Argument_InvalidType";
                    break;
 
                case ExceptionResource.Argument_InvalidArgumentForComparison:
                    resourceName = "Argument_InvalidArgumentForComparison";                    
                    break;
 
                case ExceptionResource.InvalidOperation_NoValue:
                    resourceName = "InvalidOperation_NoValue";                    
                    break;
 
                case ExceptionResource.InvalidOperation_RegRemoveSubKey:
                    resourceName = "InvalidOperation_RegRemoveSubKey";                    
                    break;
 
                case ExceptionResource.Arg_RegSubKeyAbsent:
                    resourceName = "Arg_RegSubKeyAbsent";                    
                    break;
 
                case ExceptionResource.Arg_RegSubKeyValueAbsent:
                    resourceName = "Arg_RegSubKeyValueAbsent";                    
                    break;
                    
                case ExceptionResource.Arg_RegKeyDelHive:
                    resourceName = "Arg_RegKeyDelHive";                    
                    break;
 
                case ExceptionResource.Security_RegistryPermission:
                    resourceName = "Security_RegistryPermission";                    
                    break;
 
                case ExceptionResource.Arg_RegSetStrArrNull:
                    resourceName = "Arg_RegSetStrArrNull";                    
                    break;
 
                case ExceptionResource.Arg_RegSetMismatchedKind:
                    resourceName = "Arg_RegSetMismatchedKind";                    
                    break;
 
                case ExceptionResource.UnauthorizedAccess_RegistryNoWrite:
                    resourceName = "UnauthorizedAccess_RegistryNoWrite";
                    break;
 
                case ExceptionResource.ObjectDisposed_RegKeyClosed:
                    resourceName = "ObjectDisposed_RegKeyClosed";
                    break;
 
                case ExceptionResource.Arg_RegKeyStrLenBug:
                    resourceName = "Arg_RegKeyStrLenBug";
                    break;
 
                case ExceptionResource.Argument_InvalidRegistryKeyPermissionCheck:
                    resourceName = "Argument_InvalidRegistryKeyPermissionCheck";
                    break;
 
                case ExceptionResource.NotSupported_InComparableType:
                    resourceName = "NotSupported_InComparableType";
                    break;
 
                case ExceptionResource.Argument_InvalidRegistryOptionsCheck:
                    resourceName = "Argument_InvalidRegistryOptionsCheck";
                    break;
 
                case ExceptionResource.Argument_InvalidRegistryViewCheck:
                    resourceName = "Argument_InvalidRegistryViewCheck";
                    break;
 
                default:
                    Contract.Assert( false, "The enum value is not defined, please checked ExceptionArgumentName Enum.");
                    return string.Empty;
            }
 
            return resourceName;
        }
 
    }
}
 