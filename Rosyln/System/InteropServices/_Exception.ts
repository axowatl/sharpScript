// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*=============================================================================
**
** Interface: _Exception
**
**
** Purpose: COM backwards compatibility with v1 Exception
**        object layout.
**
**
=============================================================================*/
 
namespace System.Runtime.InteropServices {
    export interface _Exception
    {
        // This contains all of our V1 Exception class's members.
 
        // From Object
        ToString(): SystemString;
        Equals(obj: SystemObject): bool;
        GetHashCode(): int;
        GetType(): Type;
 
        // From V1's Exception class
        get Message(): SystemString;
 
        GetBaseException(): Exception;
 
        get StackTrace(): SystemString;
 
        get HelpLink(): SystemString;
        set HelpLink(): SystemString;
 
        get Source(): SystemString;
        set Source(): SystemString;

        GetObjectData(info: SerializationInfo, context: StreamingContext): void;
 
        //
        // This method is intentionally included in CoreCLR to make Exception.get_InnerException "newslot virtual final".
        // Some phone apps include MEF from desktop Silverlight. MEF's ComposablePartException depends on implicit interface 
        // implementations of get_InnerException to be provided by the base class. It works only if Exception.get_InnerException
        // is virtual.
        //
        get InnerException(): Exception;

        get TargetSite(): MethodBase;
   }
}
