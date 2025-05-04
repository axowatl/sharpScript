// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Interface: ISerializable
**
**
** Purpose: Implemented by any object that needs to control its
**          own serialization.
**
**
===========================================================*/
 
namespace System.Runtime.Serialization {
    export interface ISerializable {
        GetObjectData(info: SerializationInfo, context: StreamingContext): void;
    }
}
