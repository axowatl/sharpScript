#region System Namespace
#region Classes
/*
AccessViolationException
ActivationContext
Activator
AggregateException
AppContext
AppDomain
AppDomainManager
AppDomainSetup
AppDomainUnloadedException
ApplicationException
ApplicationId
ApplicationIdentity
ArgumentException
ArgumentNullException
ArgumentOutOfRangeException
ArithmeticException
Array
ArrayTypeMismatchException
AssemblyLoadEventArgs
Attribute
AttributeUsageAttribute
BadImageFormatException
BitConverter
Buffer
CannotUnloadAppDomainException
CharEnumerator
CLSCompliantAttribute
Console
ConsoleCancelEventArgs
ContextBoundObject
ContextMarshalException
ContextStaticAttribute
Convert
DataMisalignedException
DBNull
Delegate
DivideByZeroException
DllNotFoundException
DuplicateWaitObjectException
EntryPointNotFoundException
Enum
Environment
EventArgs
Exception
ExecutionEngineException
FieldAccessException
FileStyleUriParser
FlagsAttribute
FormatException
FormattableString
FtpStyleUriParser
GC
GenericUriParser
GopherStyleUriParser
HttpStyleUriParser
IndexOutOfRangeException
InsufficientExecutionStackException
InsufficientMemoryException
InvalidCastException
InvalidOperationException
InvalidProgramException
InvalidTimeZoneException
Lazy<T>
Lazy<T,TMetadata>
LdapStyleUriParser
LoaderOptimizationAttribute
LocalDataStoreSlot
MarshalByRefObject
Math
MemberAccessException
MethodAccessException
MissingFieldException
MissingMemberException
MissingMethodException
MTAThreadAttribute
MulticastDelegate
MulticastNotSupportedException
NetPipeStyleUriParser
NetTcpStyleUriParser
NewsStyleUriParser
NonSerializedAttribute
NotFiniteNumberException
NotImplementedException
NotSupportedException
Nullable
NullReferenceException
Object
ObjectDisposedException
ObsoleteAttribute
OperatingSystem
OperationCanceledException
OutOfMemoryException
OverflowException
ParamArrayAttribute
PlatformNotSupportedException
Progress<T>
Random
RankException
ResolveEventArgs
SerializableAttribute
StackOverflowException
STAThreadAttribute
String
StringComparer
StringNormalizationExtensions
SystemException
ThreadStaticAttribute
TimeoutException
TimeZone
TimeZoneInfo
TimeZoneInfo.AdjustmentRule
TimeZoneNotFoundException
Tuple
Tuple<T1>
Tuple<T1,T2>
Tuple<T1,T2,T3>
Tuple<T1,T2,T3,T4>
Tuple<T1,T2,T3,T4,T5>
Tuple<T1,T2,T3,T4,T5,T6>
Tuple<T1,T2,T3,T4,T5,T6,T7>
Tuple<T1,T2,T3,T4,T5,T6,T7,TRest>
TupleExtensions
Type
TypeAccessException
TypeInitializationException
TypeLoadException
TypeUnloadedException
UnauthorizedAccessException
UnhandledExceptionEventArgs
Uri
UriBuilder
UriFormatException
UriParser
UriTemplate
UriTemplateEquivalenceComparer
UriTemplateMatch
UriTemplateMatchException
UriTemplateTable
UriTypeConverter
ValueType
Version
WeakReference
WeakReference<T>
*/
#endregion Classes
#region Structs
/*
ArgIterator
ArraySegment<T>
Boolean
Byte
Char
ConsoleKeyInfo
DateTime
DateTimeOffset
Decimal
Double
Guid
Int16
Int32
Int64
IntPtr
ModuleHandle
Nullable<T>
RuntimeArgumentHandle
RuntimeFieldHandle
RuntimeMethodHandle
RuntimeTypeHandle
SByte
Single
TimeSpan
TimeZoneInfo.TransitionTime
TypedReference
UInt16
UInt32
UInt64
UIntPtr
ValueTuple
ValueTuple<T1>
ValueTuple<T1,T2>
ValueTuple<T1,T2,T3>
ValueTuple<T1,T2,T3,T4>
ValueTuple<T1,T2,T3,T4,T5>
ValueTuple<T1,T2,T3,T4,T5,T6>
ValueTuple<T1,T2,T3,T4,T5,T6,T7>
ValueTuple<T1,T2,T3,T4,T5,T6,T7,TRest>
Void
*/
#endregion Structs
#region Interfaces
/*
_AppDomain
IAppDomainSetup
IAsyncResult
ICloneable
IComparable
IComparable<T>
IConvertible
ICustomFormatter
IDisposable
IEquatable<T>
IFormatProvider
IFormattable
IObservable<T>
IObserver<T>
IProgress<T>
IServiceProvider
*/
#endregion Interfaces
#region Enums
/*
ActivationContext.ContextForm
AppDomainManagerInitializationOptions
AttributeTargets
Base64FormattingOptions
ConsoleColor
ConsoleKey
ConsoleModifiers
ConsoleSpecialKey
DateTimeKind
DayOfWeek
Environment.SpecialFolder
Environment.SpecialFolderOption
EnvironmentVariableTarget
GCCollectionMode
GCNotificationStatus
GenericUriParserOptions
LoaderOptimization
MidpointRounding
PlatformID
StringComparison
StringSplitOptions
TypeCode
UriComponents
UriFormat
UriHostNameType
UriIdnScope
UriKind
UriPartial
*/
#endregion Enums
#region Delegates
/*
Action
Action<T>
Action<T1,T2>
Action<T1,T2,T3>
Action<T1,T2,T3,T4>
Action<T1,T2,T3,T4,T5>
Action<T1,T2,T3,T4,T5,T6>
Action<T1,T2,T3,T4,T5,T6,T7>
Action<T1,T2,T3,T4,T5,T6,T7,T8>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>
Action<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>
AppDomainInitializer
AssemblyLoadEventHandler
AsyncCallback
Comparison<T>
ConsoleCancelEventHandler
Converter<TInput,TOutput>
CrossAppDomainDelegate
EventHandler
EventHandler<TEventArgs>
Func<TResult>
Func<T,TResult>
Func<T1,T2,TResult>
Func<T1,T2,T3,TResult>
Func<T1,T2,T3,T4,TResult>
Func<T1,T2,T3,T4,T5,TResult>
Func<T1,T2,T3,T4,T5,T6,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,TResult>
Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,TResult>
Predicate<T>
ResolveEventHandler
UnhandledExceptionEventHandler
*/
#endregion Delegates
#endregion System Namespace

#region System.Collections Namespace
#region Classes
/*
ArrayList
BitArray
CaseInsensitiveComparer
CaseInsensitiveHashCodeProvider
CollectionBase
Comparer
DictionaryBase
Hashtable
Queue
ReadOnlyCollectionBase
SortedList
Stack
StructuralComparisons
*/
#endregion Classes
#region Structs
/*
DictionaryEntry
*/
#endregion Structs
#region Interfaces
/*
ICollection
IComparer
IDictionary
IDictionaryEnumerator
IEnumerable
IEnumerator
IEqualityComparer
IHashCodeProvider
IList
IStructuralComparable
IStructuralEquatable
*/
#endregion Interfaces
#endregion System.Collections Namespace

#region System.Collections.Concurrent Namespace
#region Classes
/*
BlockingCollection<T>
ConcurrentBag<T>
ConcurrentDictionary<TKey,TValue>
ConcurrentQueue<T>
ConcurrentStack<T>
OrderablePartitioner<TSource>
Partitioner
Partitioner<TSource>
*/
#endregion Classes
#region Structs
/*
IProducerConsumerCollection<T>
*/
#endregion Structs
#region Interfaces
/*
EnumerablePartitionerOptions
*/
#endregion Interfaces
#endregion System.Collections.Concurrent Namespace

#region System.Collections.Generic Namespace
#region Classes
/*
Comparer<T>
Dictionary<TKey,TValue>.KeyCollection
Dictionary<TKey,TValue>.ValueCollection
Dictionary<TKey,TValue>
EqualityComparer<T>
HashSet<T>
KeyedByTypeCollection<TItem>
KeyNotFoundException
LinkedList<T>
LinkedListNode<T>
List<T>
Queue<T>
SortedDictionary<TKey,TValue>.KeyCollection
SortedDictionary<TKey,TValue>.ValueCollection
SortedDictionary<TKey,TValue>
SortedList<TKey,TValue>
SortedSet<T>
Stack<T>
SynchronizedCollection<T>
SynchronizedKeyedCollection<K,T>
SynchronizedReadOnlyCollection<T>
*/
#endregion Classes
#region Structs
/*
Dictionary<TKey,TValue>.Enumerator
Dictionary<TKey,TValue>.KeyCollection.Enumerator
Dictionary<TKey,TValue>.ValueCollection.Enumerator
HashSet<T>.Enumerator
KeyValuePair<TKey,TValue>
LinkedList<T>.Enumerator
List<T>.Enumerator
Queue<T>.Enumerator
SortedDictionary<TKey,TValue>.Enumerator
SortedDictionary<TKey,TValue>.KeyCollection.Enumerator
SortedDictionary<TKey,TValue>.ValueCollection.Enumerator
SortedSet<T>.Enumerator
Stack<T>.Enumerator
*/
#endregion Structs
#region Interfaces
/*
ICollection<T>
IComparer<T>
IDictionary<TKey,TValue>
IEnumerable<T>
IEnumerator<T>
IEqualityComparer<T>
IList<T>
IReadOnlyCollection<T>
IReadOnlyDictionary<TKey,TValue>
IReadOnlyList<T>
ISet<T>
*/
#endregion Interfaces
#endregion System.Collections.Generic Namespace

#region System.Collections.ObjectModel Namespace
#region Classes
/*
Collection<T>
KeyedCollection<TKey,TItem>
ObservableCollection<T>
ReadOnlyCollection<T>
ReadOnlyDictionary<TKey,TValue>.KeyCollection
ReadOnlyDictionary<TKey,TValue>.ValueCollection
ReadOnlyDictionary<TKey,TValue>
ReadOnlyObservableCollection<T>
*/
#endregion Classes
#endregion System.Collections.ObjectModel Namespace

#region System.Configuration.Assemblies Namespace
#region Structs
/*
AssemblyHash
*/
#endregion Structs
#region Enums
/*
AssemblyHashAlgorithm
AssemblyVersionCompatibility
*/
#endregion Enums
#endregion System.Configuration.Assemblies Namespace

#region System.Deployment.Internal Namespace
#region Classes
/*
InternalActivationContextHelper
InternalApplicationIdentityHelper
*/
#endregion Classes
#endregion System.Deployment.Internal Namespace

#region System.Deployment.Internal.Isolation Namespace
#region Classes
/*
IsolationInterop
Store
StoreAssemblyEnumeration
StoreAssemblyFileEnumeration
StoreCategoryEnumeration
StoreCategoryInstanceEnumeration
StoreDeploymentMetadataEnumeration
StoreDeploymentMetadataPropertyEnumeration
StoreSubcategoryEnumeration
StoreTransaction
*/
#endregion Classes
#region Structs
/*
BLOB
CATEGORY
CATEGORY_INSTANCE
CATEGORY_SUBCATEGORY
IDENTITY_ATTRIBUTE
IStore_BindingResult
IStore_BindingResult_BoundVersion
StoreApplicationReference
StoreOperationInstallDeployment
StoreOperationMetadataProperty
StoreOperationPinDeployment
StoreOperationScavenge
StoreOperationSetCanonicalizationContext
StoreOperationSetDeploymentMetadata
StoreOperationStageComponent
StoreOperationStageComponentFile
StoreOperationUninstallDeployment
StoreOperationUnpinDeployment
StoreTransactionData
StoreTransactionOperation
STORE_ASSEMBLY
STORE_ASSEMBLY_FILE
STORE_CATEGORY
STORE_CATEGORY_INSTANCE
STORE_CATEGORY_SUBCATEGORY
*/
#endregion Structs
#region Interfaces
/*
IActContext
IAppIdAuthority
ICDF
IDefinitionAppId
IDefinitionIdentity
IEnumDefinitionIdentity
IEnumIDENTITY_ATTRIBUTE
IEnumReferenceIdentity
IEnumSTORE_ASSEMBLY
IEnumSTORE_ASSEMBLY_FILE
IEnumSTORE_ASSEMBLY_INSTALLATION_REFERENCE
IEnumSTORE_CATEGORY
IEnumSTORE_CATEGORY_INSTANCE
IEnumSTORE_CATEGORY_SUBCATEGORY
IEnumSTORE_DEPLOYMENT_METADATA
IEnumSTORE_DEPLOYMENT_METADATA_PROPERTY
IEnumUnknown
IIdentityAuthority
IManifestInformation
IManifestParseErrorCallback
IReferenceAppId
IReferenceIdentity
ISection
ISectionEntry
ISectionWithReferenceIdentityKey
ISectionWithStringKey
IStateManager
IStore
*/
#endregion Interfaces
#region Enums
/*
IAPPIDAUTHORITY_ARE_DEFINITIONS_EQUAL_FLAGS
IAPPIDAUTHORITY_ARE_REFERENCES_EQUAL_FLAGS
IIDENTITYAUTHORITY_DEFINITION_IDENTITY_TO_TEXT_FLAGS
IIDENTITYAUTHORITY_DOES_DEFINITION_MATCH_REFERENCE_FLAGS
IIDENTITYAUTHORITY_REFERENCE_IDENTITY_TO_TEXT_FLAGS
ISTORE_BIND_REFERENCE_TO_ASSEMBLY_FLAGS
ISTORE_ENUM_ASSEMBLIES_FLAGS
ISTORE_ENUM_FILES_FLAGS
StateManager_RunningState
StoreTransactionOperationType
STORE_ASSEMBLY_FILE_STATUS_FLAGS
STORE_ASSEMBLY_STATUS_FLAGS
*/
#endregion Enums
#endregion System.Deployment.Internal.Isolation Namespace

#region System.Deployment.Internal.Isolation.Manifest Namespace
#region Classes
/*
AssemblyReferenceDependentAssemblyEntry
AssemblyReferenceEntry
AssemblyRequestEntry
CategoryMembershipDataEntry
CategoryMembershipEntry
CLRSurrogateEntry
CmsUtils
CompatibleFrameworksMetadataEntry
COMServerEntry
DependentOSMetadataEntry
DeploymentMetadataEntry
DescriptionMetadataEntry
EntryPointEntry
FileAssociationEntry
FileEntry
HashElementEntry
MetadataSectionEntry
MuiResourceIdLookupMapEntry
MuiResourceMapEntry
MuiResourceTypeIdIntEntry
MuiResourceTypeIdStringEntry
PermissionSetEntry
ProgIdRedirectionEntry
ResourceTableMappingEntry
SubcategoryMembershipEntry
WindowClassEntry
*/
#endregion Classes
#region Interfaces
/*
IAssemblyReferenceDependentAssemblyEntry
IAssemblyReferenceEntry
IAssemblyRequestEntry
ICategoryMembershipDataEntry
ICategoryMembershipEntry
ICLRSurrogateEntry
ICMS
ICompatibleFrameworksMetadataEntry
ICOMServerEntry
IDependentOSMetadataEntry
IDeploymentMetadataEntry
IDescriptionMetadataEntry
IEntryPointEntry
IFileAssociationEntry
IFileEntry
IHashElementEntry
IMetadataSectionEntry
IMuiResourceIdLookupMapEntry
IMuiResourceMapEntry
IMuiResourceTypeIdIntEntry
IMuiResourceTypeIdStringEntry
IPermissionSetEntry
IProgIdRedirectionEntry
IResourceTableMappingEntry
ISubcategoryMembershipEntry
IWindowClassEntry
*/
#endregion Interfaces
#region Enums
/*
AssemblyReferenceDependentAssemblyEntryFieldId
AssemblyReferenceEntryFieldId
AssemblyRequestEntryFieldId
CategoryMembershipDataEntryFieldId
CategoryMembershipEntryFieldId
CLRSurrogateEntryFieldId
CMSSECTIONID
CMS_ASSEMBLY_DEPLOYMENT_FLAG
CMS_ASSEMBLY_REFERENCE_DEPENDENT_ASSEMBLY_FLAG
CMS_ASSEMBLY_REFERENCE_FLAG
CMS_COM_SERVER_FLAG
CMS_ENTRY_POINT_FLAG
CMS_FILE_FLAG
CMS_FILE_HASH_ALGORITHM
CMS_FILE_WRITABLE_TYPE
CMS_HASH_DIGESTMETHOD
CMS_HASH_TRANSFORM
CMS_SCHEMA_VERSION
CMS_TIME_UNIT_TYPE
CMS_USAGE_PATTERN
CompatibleFrameworksMetadataEntryFieldId
COMServerEntryFieldId
DependentOSMetadataEntryFieldId
DeploymentMetadataEntryFieldId
DescriptionMetadataEntryFieldId
EntryPointEntryFieldId
FileAssociationEntryFieldId
FileEntryFieldId
HashElementEntryFieldId
MetadataSectionEntryFieldId
MuiResourceIdLookupMapEntryFieldId
MuiResourceMapEntryFieldId
MuiResourceTypeIdIntEntryFieldId
MuiResourceTypeIdStringEntryFieldId
PermissionSetEntryFieldId
ProgIdRedirectionEntryFieldId
ResourceTableMappingEntryFieldId
SubcategoryMembershipEntryFieldId
WindowClassEntryFieldId
*/
#endregion Enums
#endregion System.Deployment.Internal.Isolation.Manifest Namespace

#region System.Diagnostics Namespace
#region Classes
/*
BooleanSwitch
ConditionalAttribute
ConsoleTraceListener
CorrelationManager
CounterCreationData
CounterCreationDataCollection
CounterSampleCalculator
DataReceivedEventArgs
Debug
DebuggableAttribute
Debugger
DebuggerBrowsableAttribute
DebuggerDisplayAttribute
DebuggerHiddenAttribute
DebuggerNonUserCodeAttribute
DebuggerStepperBoundaryAttribute
DebuggerStepThroughAttribute
DebuggerTypeProxyAttribute
DebuggerVisualizerAttribute
DefaultTraceListener
DelimitedListTraceListener
DiagnosticsConfigurationHandler
EntryWrittenEventArgs
EventInstance
EventLog
EventLogEntry
EventLogEntryCollection
EventLogInstaller
EventLogPermission
EventLogPermissionAttribute
EventLogPermissionEntry
EventLogPermissionEntryCollection
EventLogTraceListener
EventSchemaTraceListener
EventSourceCreationData
EventTypeFilter
FileVersionInfo
InstanceData
InstanceDataCollection
InstanceDataCollectionCollection
MonitoringDescriptionAttribute
PerformanceCounter
PerformanceCounterCategory
PerformanceCounterInstaller
PerformanceCounterManager
PerformanceCounterPermission
PerformanceCounterPermissionAttribute
PerformanceCounterPermissionEntry
PerformanceCounterPermissionEntryCollection
PresentationTraceSources
Process
ProcessModule
ProcessModuleCollection
ProcessStartInfo
ProcessThread
ProcessThreadCollection
SourceFilter
SourceSwitch
StackFrame
StackFrameExtensions
StackTrace
Stopwatch
Switch
SwitchAttribute
SwitchLevelAttribute
TextWriterTraceListener
Trace
TraceEventCache
TraceFilter
TraceListener
TraceListenerCollection
TraceSource
TraceSwitch
UnescapedXmlDiagnosticData
XmlWriterTraceListener
*/
#endregion Classes
#region Structs
/*
CounterSample
*/
#endregion Structs
#region Interfaces
/*
ICollectData
*/
#endregion Interfaces
#region Enums
/*
DebuggableAttribute.DebuggingModes
DebuggerBrowsableState
EventLogEntryType
EventLogPermissionAccess
OverflowAction
PerformanceCounterCategoryType
PerformanceCounterInstanceLifetime
PerformanceCounterPermissionAccess
PerformanceCounterType
PresentationTraceLevel
ProcessPriorityClass
ProcessWindowStyle
SourceLevels
ThreadPriorityLevel
ThreadState
ThreadWaitReason
TraceEventType
TraceLevel
TraceLogRetentionOption
TraceOptions
*/
#endregion Enums
#region Delegates
/*
DataReceivedEventHandler
EntryWrittenEventHandler
*/
#endregion Delegates
#endregion System.Diagnostics Namespace

#region System.Diagnostics.CodeAnalysis Namespace
#region Classes
/*
ExcludeFromCodeCoverageAttribute
SuppressMessageAttribute
*/
#endregion Classes
#endregion System.Diagnostics.CodeAnalysis Namespace

#region System.Diagnostics.Contracts Namespace
#region Classes
/*
Contract
ContractAbbreviatorAttribute
ContractArgumentValidatorAttribute
ContractClassAttribute
ContractClassForAttribute
ContractFailedEventArgs
ContractInvariantMethodAttribute
ContractOptionAttribute
ContractPublicPropertyNameAttribute
ContractReferenceAssemblyAttribute
ContractRuntimeIgnoredAttribute
ContractVerificationAttribute
PureAttribute
*/
#endregion Classes
#region Enums
/*
ContractFailureKind
*/
#endregion Enums
#endregion System.Diagnostics.Contracts Namespace

#region System.Diagnostics.Contracts.Internal Namespace
#region Classes
/*
ContractHelper
*/
#endregion Classes
#endregion System.Diagnostics.Contracts.Internal Namespace

#region System.Diagnostics.SymbolStore Namespace
#region Classes
/*
SymBinder
SymBinderBase
SymDocument
SymDocumentBase
SymDocumentType
SymDocumentWriter
SymDocumentWriterBase
SymLanguageType
SymLanguageVendor
SymMethod
SymMethodBase
SymReader
SymReaderBase
SymScope
SymScopeBase
SymVariable
SymVariableBase
SymWriter
SymWriterBase
*/
#endregion Classes
#region Structs
/*
SymbolToken
*/
#endregion Structs
#region Interfaces
/*
ISymbolBinder
ISymbolBinder1
ISymbolDocument
ISymbolDocumentWriter
ISymbolMethod
ISymbolNamespace
ISymbolReader
ISymbolScope
ISymbolVariable
ISymbolWriter
*/
#endregion Interfaces
#region Enums
/*
SymAddressKind
*/
#endregion Enums
#endregion System.Diagnostics.SymbolStore Namespace

#region System.Diagnostics.Tracing Namespace
#region Classes
/*
EventAttribute
EventCommandEventArgs
EventCounter
EventDataAttribute
EventFieldAttribute
EventIgnoreAttribute
EventListener
EventSource
EventSourceAttribute
EventSourceCreatedEventArgs
EventSourceException
EventWrittenEventArgs
NonEventAttribute
*/
#endregion Classes
#region Structs
/*
EventSource.EventData
EventSourceOptions
*/
#endregion Structs
#region Enums
/*
EventActivityOptions
EventChannel
EventCommand
EventFieldFormat
EventFieldTags
EventKeywords
EventLevel
EventManifestOptions
EventOpcode
EventSourceSettings
EventTags
EventTask
*/
#endregion Enums
#endregion System.Diagnostics.Tracing Namespace

#region System.Diagnostics.Tracing.Internal Namespace
#region Classes
/*
Environment
*/
#endregion Classes
#endregion System.Diagnostics.Tracing.Internal Namespace

#region System.Globalization Namespace
#region Classes
/*
Calendar
CharUnicodeInfo
ChineseLunisolarCalendar
CompareInfo
CultureAndRegionInfoBuilder
CultureInfo
CultureNotFoundException
DateTimeFormatInfo
DaylightTime
EastAsianLunisolarCalendar
GlobalizationExtensions
GregorianCalendar
HebrewCalendar
HijriCalendar
IdnMapping
JapaneseCalendar
JapaneseLunisolarCalendar
JulianCalendar
KoreanCalendar
KoreanLunisolarCalendar
NumberFormatInfo
PersianCalendar
RegionInfo
SortKey
SortVersion
StringInfo
TaiwanCalendar
TaiwanLunisolarCalendar
TextElementEnumerator
TextInfo
ThaiBuddhistCalendar
UmAlQuraCalendar
*/
#endregion Classes
#region Enums
/*
CalendarAlgorithmType
CalendarWeekRule
CompareOptions
CultureAndRegionModifiers
CultureTypes
DateTimeStyles
DigitShapes
GregorianCalendarTypes
NumberStyles
TimeSpanStyles
UnicodeCategory
*/
#endregion Enums
#endregion System.Globalization Namespace

#region System.IO Namespace
#region Classes
/*
BinaryReader
BinaryWriter
BufferedStream
Directory
DirectoryInfo
DirectoryNotFoundException
DriveInfo
DriveNotFoundException
EndOfStreamException
ErrorEventArgs
File
FileFormatException
FileInfo
FileLoadException
FileNotFoundException
FileStream
FileSystemEventArgs
FileSystemInfo
FileSystemWatcher
InternalBufferOverflowException
InvalidDataException
IODescriptionAttribute
IOException
MemoryStream
Path
PathTooLongException
PipeException
RenamedEventArgs
Stream
StreamReader
StreamWriter
StringReader
StringWriter
TextReader
TextWriter
UnmanagedMemoryAccessor
UnmanagedMemoryStream
*/
#endregion Classes
#region Structs
/*
WaitForChangedResult
*/
#endregion Structs
#region Enums
/*
DriveType
FileAccess
FileAttributes
FileMode
FileOptions
FileShare
HandleInheritability
NotifyFilters
SearchOption
SeekOrigin
WatcherChangeTypes
*/
#endregion Enums
#region Delegates
/*
ErrorEventHandler
FileSystemEventHandler
RenamedEventHandler
*/
#endregion Delegates
#endregion System.IO Namespace

#region System.IO.IsolatedStorage Namespace
#region Classes
/*
IsolatedStorage
IsolatedStorageException
IsolatedStorageFile
IsolatedStorageFileStream
IsolatedStorageSecurityState
*/
#endregion Classes
#region Interfaces
/*
INormalizeForIsolatedStorage
*/
#endregion Interfaces
#region Enums
/*
IsolatedStorageScope
IsolatedStorageSecurityOptions
*/
#endregion Enums
#endregion System.IO.IsolatedStorage Namespace

#region System.Reflection Namespace
#region Classes
/*
AmbiguousMatchException
Assembly
AssemblyAlgorithmIdAttribute
AssemblyCompanyAttribute
AssemblyConfigurationAttribute
AssemblyCopyrightAttribute
AssemblyCultureAttribute
AssemblyDefaultAliasAttribute
AssemblyDelaySignAttribute
AssemblyDescriptionAttribute
AssemblyFileVersionAttribute
AssemblyFlagsAttribute
AssemblyInformationalVersionAttribute
AssemblyKeyFileAttribute
AssemblyKeyNameAttribute
AssemblyMetadataAttribute
AssemblyName
AssemblyNameProxy
AssemblyProductAttribute
AssemblySignatureKeyAttribute
AssemblyTitleAttribute
AssemblyTrademarkAttribute
AssemblyVersionAttribute
Binder
ConstructorInfo
CustomAttributeData
CustomAttributeExtensions
CustomAttributeFormatException
DefaultMemberAttribute
EventInfo
ExceptionHandlingClause
FieldInfo
IntrospectionExtensions
InvalidFilterCriteriaException
LocalVariableInfo
ManifestResourceInfo
MemberInfo
MethodBase
MethodBody
MethodInfo
Missing
Module
ObfuscateAssemblyAttribute
ObfuscationAttribute
ParameterInfo
Pointer
PropertyInfo
ReflectionContext
ReflectionTypeLoadException
RuntimeReflectionExtensions
StrongNameKeyPair
TargetException
TargetInvocationException
TargetParameterCountException
TypeDelegator
TypeInfo
*/
#endregion Classes
#region Structs
/*
CustomAttributeNamedArgument
CustomAttributeTypedArgument
InterfaceMapping
ParameterModifier
*/
#endregion Structs
#region Interfaces
/*
ICustomAttributeProvider
ICustomTypeProvider
IReflect
IReflectableType
*/
#endregion Interfaces
#region Enums
/*
AssemblyContentType
AssemblyNameFlags
BindingFlags
CallingConventions
EventAttributes
ExceptionHandlingClauseOptions
FieldAttributes
GenericParameterAttributes
ImageFileMachine
MemberTypes
MethodAttributes
MethodImplAttributes
ParameterAttributes
PortableExecutableKinds
ProcessorArchitecture
PropertyAttributes
ResourceAttributes
ResourceLocation
TypeAttributes
*/
#endregion Enums
#region Delegates
/*
MemberFilter
ModuleResolveEventHandler
TypeFilter
*/
#endregion Delegates
#endregion System.Reflection Namespace

#region System.Reflection.Emit Namespace
#region Classes
/*
AssemblyBuilder
ConstructorBuilder
CustomAttributeBuilder
DynamicILInfo
DynamicMethod
EnumBuilder
EventBuilder
FieldBuilder
GenericTypeParameterBuilder
ILGenerator
LocalBuilder
MethodBuilder
MethodRental
ModuleBuilder
OpCodes
ParameterBuilder
PropertyBuilder
SignatureHelper
TypeBuilder
UnmanagedMarshal
*/
#endregion Classes
#region Structs
/*
EventToken
ExceptionHandler
FieldToken
Label
MethodToken
OpCode
ParameterToken
PropertyToken
SignatureToken
StringToken
TypeToken
*/
#endregion Structs
#region Enums
/*
AssemblyBuilderAccess
FlowControl
OpCodeType
OperandType
PackingSize
PEFileKinds
StackBehaviour
*/
#endregion Enums
#endregion System.Reflection.Emit Namespace

#region System.Resources Namespace
#region Classes
/*
MissingManifestResourceException
MissingSatelliteAssemblyException
NeutralResourcesLanguageAttribute
ResourceManager
ResourceReader
ResourceSet
ResourceWriter
ResXDataNode
ResXFileRef
ResXFileRef.Converter
ResXResourceReader
ResXResourceSet
ResXResourceWriter
SatelliteContractVersionAttribute
*/
#endregion Classes
#region Interfaces
/*
IResourceReader
IResourceWriter
*/
#endregion Interfaces
#region Enums
/*
UltimateResourceFallbackLocation
*/
#endregion Enums
#endregion System.Resources Namespace

#region System.Runtime Namespace
#region Classes
/*
AssemblyTargetedPatchBandAttribute
GCSettings
MemoryFailPoint
ProfileOptimization
TargetedPatchingOptOutAttribute
*/
#endregion Classes
#region Enums
/*
GCLargeObjectHeapCompactionMode
GCLatencyMode
*/
#endregion Enums
#endregion System.Runtime Namespace

#region System.Runtime.CompilerServices Namespace
#region Classes
/*
AccessedThroughPropertyAttribute
AsyncStateMachineAttribute
CallConvCdecl
CallConvFastcall
CallConvStdcall
CallConvThiscall
CallerFilePathAttribute
CallerLineNumberAttribute
CallerMemberNameAttribute
CallSite
CallSite<T>
CallSiteBinder
CallSiteHelpers
CallSiteOps
Closure
CompilationRelaxationsAttribute
CompilerGeneratedAttribute
CompilerGlobalScopeAttribute
CompilerMarshalOverride
ConditionalWeakTable<TKey,TValue>
ContractHelper
CustomConstantAttribute
DateTimeConstantAttribute
DebugInfoGenerator
DecimalConstantAttribute
DefaultDependencyAttribute
DependencyAttribute
DisablePrivateReflectionAttribute
DiscardableAttribute
DynamicAttribute
ExecutionScope
ExtensionAttribute
FixedAddressValueTypeAttribute
FixedBufferAttribute
FormattableStringFactory
HasCopySemanticsAttribute
IDispatchConstantAttribute
IndexerNameAttribute
InternalsVisibleToAttribute
IsBoxed
IsByRefLikeAttribute
IsByValue
IsConst
IsCopyConstructed
IsExplicitlyDereferenced
IsImplicitlyDereferenced
IsJitIntrinsic
IsLong
IsPinned
IsReadOnlyAttribute
IsSignUnspecifiedByte
IsUdtReturn
IsVolatile
IteratorStateMachineAttribute
IUnknownConstantAttribute
MethodImplAttribute
NativeCppClassAttribute
ReadOnlyCollectionBuilder<T>
ReferenceAssemblyAttribute
RequiredAttributeAttribute
RuleCache<T>
RuntimeCompatibilityAttribute
RuntimeFeature
RuntimeHelpers
RuntimeOps
RuntimeWrappedException
ScopelessEnumAttribute
SpecialNameAttribute
StateMachineAttribute
StringFreezingAttribute
StrongBox<T>
SuppressIldasmAttribute
TupleElementNamesAttribute
TypeForwardedFromAttribute
TypeForwardedToAttribute
UnsafeValueTypeAttribute
*/
#endregion Classes
#region Structs
/*
AsyncTaskMethodBuilder
AsyncTaskMethodBuilder<TResult>
AsyncVoidMethodBuilder
ConfiguredTaskAwaitable
ConfiguredTaskAwaitable.ConfiguredTaskAwaiter
ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter
ConfiguredTaskAwaitable<TResult>
TaskAwaiter
TaskAwaiter<TResult>
YieldAwaitable
YieldAwaitable.YieldAwaiter
*/
#endregion Structs
#region Interfaces
/*
IAsyncStateMachine
ICriticalNotifyCompletion
INotifyCompletion
IRuntimeVariables
IStrongBox
ITuple
*/
#endregion Interfaces
#region Enums
/*
CompilationRelaxations
LoadHint
MethodCodeType
MethodImplOptions
*/
#endregion Enums
#region Delegates
/*
ConditionalWeakTable<TKey,TValue>.CreateValueCallback
RuntimeHelpers.CleanupCode
RuntimeHelpers.TryCode
*/
#endregion Delegates
#endregion System.Runtime.CompilerServices Namespace

#region System.Runtime.ConstrainedExecution Namespace
#region Classes
/*
CriticalFinalizerObject
PrePrepareMethodAttribute
ReliabilityContractAttribute
*/
#endregion Classes
#region Enums
/*
Cer
Consistency
*/
#endregion Enums
#endregion System.Runtime.ConstrainedExecution Namespace

#region System.Runtime.DesignerServices Namespace
#region Classes
/*
WindowsRuntimeDesignerContext
*/
#endregion Classes
#endregion System.Runtime.DesignerServices Namespace

#region System.Runtime.ExceptionServices Namespace
#region Classes
/*
ExceptionDispatchInfo
FirstChanceExceptionEventArgs
HandleProcessCorruptedStateExceptionsAttribute
*/
#endregion Classes
#endregion System.Runtime.ExceptionServices Namespace

#region System.Runtime.Hosting Namespace
#region Classes
/*
ActivationArguments
ApplicationActivator
*/
#endregion Classes
#endregion System.Runtime.Hosting Namespace

#region System.Runtime.InteropServices Namespace
#region Classes
/*
AllowReversePInvokeCallsAttribute
AutomationProxyAttribute
BestFitMappingAttribute
BStrWrapper
ClassInterfaceAttribute
CoClassAttribute
ComAliasNameAttribute
ComAwareEventInfo
ComCompatibleVersionAttribute
ComConversionLossAttribute
ComDefaultInterfaceAttribute
ComEventInterfaceAttribute
ComEventsHelper
COMException
ComImportAttribute
ComRegisterFunctionAttribute
ComSourceInterfacesAttribute
ComUnregisterFunctionAttribute
ComVisibleAttribute
CriticalHandle
CurrencyWrapper
DefaultCharSetAttribute
DefaultDllImportSearchPathsAttribute
DefaultParameterValueAttribute
DispatchWrapper
DispIdAttribute
DllImportAttribute
ErrorWrapper
ExtensibleClassFactory
ExternalException
FieldOffsetAttribute
GuidAttribute
HandleCollector
IDispatchImplAttribute
ImportedFromTypeLibAttribute
InAttribute
InterfaceTypeAttribute
InvalidComObjectException
InvalidOleVariantTypeException
LCIDConversionAttribute
ManagedToNativeComInteropStubAttribute
Marshal
MarshalAsAttribute
MarshalDirectiveException
OptionalAttribute
OutAttribute
PreserveSigAttribute
PrimaryInteropAssemblyAttribute
ProgIdAttribute
RegistrationServices
RuntimeEnvironment
RuntimeInformation
SafeArrayRankMismatchException
SafeArrayTypeMismatchException
SafeBuffer
SafeHandle
SEHException
SetWin32ContextInIDispatchAttribute
StandardOleMarshalObject
StructLayoutAttribute
TypeIdentifierAttribute
TypeLibConverter
TypeLibFuncAttribute
TypeLibImportClassAttribute
TypeLibTypeAttribute
TypeLibVarAttribute
TypeLibVersionAttribute
UnknownWrapper
UnmanagedFunctionPointerAttribute
VariantWrapper
*/
#endregion Classes
#region Structs
/*
ArrayWithOffset
BIND_OPTS
BINDPTR
CONNECTDATA
DISPPARAMS
ELEMDESC
ELEMDESC.DESCUNION
EXCEPINFO
FILETIME
FUNCDESC
GCHandle
HandleRef
IDLDESC
OSPlatform
PARAMDESC
STATSTG
TYPEATTR
TYPEDESC
TYPELIBATTR
VARDESC
VARDESC.DESCUNION
*/
#endregion Structs
#region Interfaces
/*
_Activator
_Assembly
_AssemblyBuilder
_AssemblyName
_Attribute
_ConstructorBuilder
_ConstructorInfo
_CustomAttributeBuilder
_EnumBuilder
_EventBuilder
_EventInfo
_Exception
_FieldBuilder
_FieldInfo
_ILGenerator
_LocalBuilder
_MemberInfo
_MethodBase
_MethodBuilder
_MethodInfo
_MethodRental
_Module
_ModuleBuilder
_ParameterBuilder
_ParameterInfo
_PropertyBuilder
_PropertyInfo
_SignatureHelper
_Thread
_Type
_TypeBuilder
ICustomAdapter
ICustomFactory
ICustomMarshaler
ICustomQueryInterface
IRegistrationServices
ITypeLibConverter
ITypeLibExporterNameProvider
ITypeLibExporterNotifySink
ITypeLibImporterNotifySink
UCOMIBindCtx
UCOMIConnectionPoint
UCOMIConnectionPointContainer
UCOMIEnumConnectionPoints
UCOMIEnumConnections
UCOMIEnumMoniker
UCOMIEnumString
UCOMIEnumVARIANT
UCOMIMoniker
UCOMIPersistFile
UCOMIRunningObjectTable
UCOMIStream
UCOMITypeComp
UCOMITypeInfo
UCOMITypeLib
*/
#endregion Interfaces
#region Enums
/*
Architecture
AssemblyRegistrationFlags
CALLCONV
CallingConvention
CharSet
ClassInterfaceType
ComInterfaceType
ComMemberType
CustomQueryInterfaceMode
CustomQueryInterfaceResult
DESCKIND
DllImportSearchPath
ExporterEventKind
FUNCFLAGS
FUNCKIND
GCHandleType
IDispatchImplType
IDLFLAG
IMPLTYPEFLAGS
ImporterEventKind
INVOKEKIND
LayoutKind
LIBFLAGS
PARAMFLAG
RegistrationClassContext
RegistrationConnectionType
SYSKIND
TYPEFLAGS
TYPEKIND
TypeLibExporterFlags
TypeLibFuncFlags
TypeLibImporterFlags
TypeLibTypeFlags
TypeLibVarFlags
UnmanagedType
VarEnum
VARFLAGS
*/
#endregion Enums
#region Delegates
/*
ObjectCreationDelegate
*/
#endregion Delegates
#endregion System.Runtime.InteropServices Namespace

#region System.Runtime.InteropServices.ComTypes Namespace
#region Structs
/*
BIND_OPTS
BINDPTR
CONNECTDATA
DISPPARAMS
ELEMDESC
ELEMDESC.DESCUNION
EXCEPINFO
FILETIME
FORMATETC
FUNCDESC
IDLDESC
PARAMDESC
STATDATA
STATSTG
STGMEDIUM
TYPEATTR
TYPEDESC
TYPELIBATTR
VARDESC
VARDESC.DESCUNION
*/
#endregion Structs
#region Interfaces
/*
IAdviseSink
IBindCtx
IConnectionPoint
IConnectionPointContainer
IDataObject
IEnumConnectionPoints
IEnumConnections
IEnumFORMATETC
IEnumMoniker
IEnumSTATDATA
IEnumString
IEnumVARIANT
IMoniker
IPersistFile
IRunningObjectTable
IStream
ITypeComp
ITypeInfo
ITypeInfo2
ITypeLib
ITypeLib2
*/
#endregion Interfaces
#region Enums
/*
ADVF
CALLCONV
DATADIR
DESCKIND
DVASPECT
FUNCFLAGS
FUNCKIND
IDLFLAG
IMPLTYPEFLAGS
INVOKEKIND
LIBFLAGS
PARAMFLAG
SYSKIND
TYMED
TYPEFLAGS
TYPEKIND
VARFLAGS
VARKIND
*/
#endregion Enums
#endregion System.Runtime.InteropServices.ComTypes Namespace

#region System.Runtime.InteropServices.Expando Namespace
#region Interfaces
/*
IExpando
*/
#endregion Interfaces
#endregion System.Runtime.InteropServices.Expando Namespace

#region System.Runtime.InteropServices.TCEAdapterGen Namespace
#region Classes
/*
EventItfInfo
EventProviderWriter
EventSinkHelperWriter
NameSpaceExtractor
TCEAdapterGenerator
*/
#endregion Classes
#endregion System.Runtime.InteropServices.TCEAdapterGen Namespace

#region System.Runtime.InteropServices.WindowsRuntime Namespace
#region Classes
/*
DefaultInterfaceAttribute
DesignerNamespaceResolveEventArgs
EventRegistrationTokenTable<T>
InterfaceImplementedInVersionAttribute
NamespaceResolveEventArgs
ReadOnlyArrayAttribute
ReturnValueNameAttribute
WindowsRuntimeMarshal
WindowsRuntimeMetadata
WriteOnlyArrayAttribute
*/
#endregion Classes
#region Structs
/*
EventRegistrationToken
*/
#endregion Structs
#region Interfaces
/*
IActivationFactory
*/
#endregion Interfaces
#endregion System.Runtime.InteropServices.WindowsRuntime Namespace

#region System.Runtime.Remoting Namespace
#region Classes
/*
ActivatedClientTypeEntry
ActivatedServiceTypeEntry
InternalRemotingServices
ObjectHandle
ObjRef
RemotingConfiguration
RemotingException
RemotingServices
RemotingTimeoutException
ServerException
SoapServices
TypeEntry
WellKnownClientTypeEntry
WellKnownServiceTypeEntry
*/
#endregion Classes
#region Interfaces
/*
IChannelInfo
IEnvoyInfo
IObjectHandle
IRemotingTypeInfo
*/
#endregion Interfaces
#region Enums
/*
CustomErrorsModes
WellKnownObjectMode
*/
#endregion Enums
#endregion System.Runtime.Remoting Namespace

#region System.Runtime.Remoting.Activation Namespace
#region Classes
/*
UrlAttribute
*/
#endregion Classes
#region Interfaces
/*
IActivator
IConstructionCallMessage
IConstructionReturnMessage
*/
#endregion Interfaces
#region Enums
/*
ActivatorLevel
*/
#endregion Enums
#endregion System.Runtime.Remoting.Activation Namespace

#region System.Runtime.Remoting.Channels Namespace
#region Classes
/*
BaseChannelObjectWithProperties
BaseChannelSinkWithProperties
BaseChannelWithProperties
BinaryClientFormatterSink
BinaryClientFormatterSinkProvider
BinaryServerFormatterSink
BinaryServerFormatterSinkProvider
ChannelDataStore
ChannelServices
ClientChannelSinkStack
CommonTransportKeys
ServerChannelSinkStack
SinkProviderData
SoapClientFormatterSink
SoapClientFormatterSinkProvider
SoapServerFormatterSink
SoapServerFormatterSinkProvider
TransportHeaders
*/
#endregion Classes
#region Interfaces
/*
IAuthorizeRemotingConnection
IChannel
IChannelDataStore
IChannelReceiver
IChannelReceiverHook
IChannelSender
IChannelSinkBase
IClientChannelSink
IClientChannelSinkProvider
IClientChannelSinkStack
IClientFormatterSink
IClientFormatterSinkProvider
IClientResponseChannelSinkStack
ISecurableChannel
IServerChannelSink
IServerChannelSinkProvider
IServerChannelSinkStack
IServerFormatterSinkProvider
IServerResponseChannelSinkStack
ITransportHeaders
*/
#endregion Interfaces
#region Enums
/*
BinaryServerFormatterSink.Protocol
ServerProcessing
SoapServerFormatterSink.Protocol
SocketCachePolicy
*/
#endregion Enums
#endregion System.Runtime.Remoting.Channels Namespace

#region System.Runtime.Remoting.Contexts Namespace
#region Classes
/*
Context
ContextAttribute
ContextProperty
SynchronizationAttribute
*/
#endregion Classes
#region Interfaces
/*
IContextAttribute
IContextProperty
IContextPropertyActivator
IContributeClientContextSink
IContributeDynamicSink
IContributeEnvoySink
IContributeObjectSink
IContributeServerContextSink
IDynamicMessageSink
IDynamicProperty
*/
#endregion Interfaces
#region Delegates
/*
CrossContextDelegate
*/
#endregion Delegates
#endregion System.Runtime.Remoting.Contexts Namespace

#region System.Runtime.Remoting.Lifetime Namespace
#region Classes
/*
ClientSponsor
LifetimeServices
*/
#endregion Classes
#region Interfaces
/*
ILease
ISponsor
*/
#endregion Interfaces
#region Enums
/*
LeaseState
*/
#endregion Enums
#endregion System.Runtime.Remoting.Lifetime Namespace

#region System.Runtime.Remoting.Messaging Namespace
#region Classes
/*
AsyncResult
CallContext
ConstructionCall
ConstructionResponse
Header
InternalMessageWrapper
LogicalCallContext
MethodCall
MethodCallMessageWrapper
MethodResponse
MethodReturnMessageWrapper
OneWayAttribute
RemotingSurrogateSelector
ReturnMessage
*/
#endregion Classes
#region Interfaces
/*
ILogicalThreadAffinative
IMessage
IMessageCtrl
IMessageSink
IMethodCallMessage
IMethodMessage
IMethodReturnMessage
IRemotingFormatter
*/
#endregion Interfaces
#region Delegates
/*
HeaderHandler
MessageSurrogateFilter
*/
#endregion Delegates
#endregion System.Runtime.Remoting.Messaging Namespace

#region System.Runtime.Remoting.Metadata Namespace
#region Classes
/*
SoapAttribute
SoapFieldAttribute
SoapMethodAttribute
SoapParameterAttribute
SoapTypeAttribute
*/
#endregion Classes
#region Enums
/*
SoapOption
XmlFieldOrderOption
*/
#endregion Enums
#endregion System.Runtime.Remoting.Metadata Namespace

#region System.Runtime.Remoting.Metadata.W3cXsd2001 Namespace
#region Classes
/*
SoapAnyUri
SoapBase64Binary
SoapDate
SoapDateTime
SoapDay
SoapDuration
SoapEntities
SoapEntity
SoapHexBinary
SoapId
SoapIdref
SoapIdrefs
SoapInteger
SoapLanguage
SoapMonth
SoapMonthDay
SoapName
SoapNcName
SoapNegativeInteger
SoapNmtoken
SoapNmtokens
SoapNonNegativeInteger
SoapNonPositiveInteger
SoapNormalizedString
SoapNotation
SoapPositiveInteger
SoapQName
SoapTime
SoapToken
SoapYear
SoapYearMonth
*/
#endregion Classes
#region Interfaces
/*
ISoapXsd
*/
#endregion Interfaces
#endregion System.Runtime.Remoting.Metadata.W3cXsd2001 Namespace

#region System.Runtime.Remoting.Proxies Namespace
#region Classes
/*
ProxyAttribute
RealProxy
*/
#endregion Classes
#endregion System.Runtime.Remoting.Proxies Namespace

#region System.Runtime.Remoting.Services Namespace
#region Classes
/*
EnterpriseServicesHelper
RemotingClientProxy
RemotingService
TrackingServices
*/
#endregion Classes
#region Interfaces
/*
ITrackingHandler
*/
#endregion Interfaces
#endregion System.Runtime.Remoting.Services Namespace

#region System.Runtime.Serialization Namespace
#region Classes
/*
CollectionDataContractAttribute
ContractNamespaceAttribute
DataContractAttribute
DataContractResolver
DataContractSerializer
DataContractSerializerExtensions
DataContractSerializerSettings
DataMemberAttribute
DateTimeFormat
EnumMemberAttribute
ExportOptions
ExtensionDataObject
Formatter
FormatterConverter
FormatterServices
IgnoreDataMemberAttribute
ImportOptions
InvalidDataContractException
KnownTypeAttribute
NetDataContractSerializer
ObjectIDGenerator
ObjectManager
OnDeserializedAttribute
OnDeserializingAttribute
OnSerializedAttribute
OnSerializingAttribute
OptionalFieldAttribute
SafeSerializationEventArgs
SerializationBinder
SerializationException
SerializationInfo
SerializationInfoEnumerator
SerializationObjectManager
SurrogateSelector
XmlObjectSerializer
XmlSerializableServices
XPathQueryGenerator
XsdDataContractExporter
XsdDataContractImporter
*/
#endregion Classes
#region Structs
/*
SerializationEntry
StreamingContext
*/
#endregion Structs
#region Interfaces
/*
IDataContractSurrogate
IDeserializationCallback
IExtensibleDataObject
IFormatter
IFormatterConverter
IObjectReference
ISafeSerializationData
ISerializable
ISerializationSurrogate
ISerializationSurrogateProvider
ISurrogateSelector
*/
#endregion Interfaces
#region Enums
/*
EmitTypeInformation
StreamingContextStates
*/
#endregion Enums
#endregion System.Runtime.Serialization Namespace

#region System.Runtime.Serialization.Formatters Namespace
#region Classes
/*
InternalRM
InternalST
ServerFault
SoapFault
SoapMessage
*/
#endregion Classes
#region Interfaces
/*
IFieldInfo
ISoapMessage
*/
#endregion Interfaces
#region Enums
/*
FormatterAssemblyStyle
FormatterTypeStyle
TypeFilterLevel
*/
#endregion Enums
#endregion System.Runtime.Serialization.Formatters Namespace

#region System.Runtime.Serialization.Formatters.Binary Namespace
#region Classes
/*
BinaryFormatter
*/
#endregion Classes
#endregion System.Runtime.Serialization.Formatters.Binary Namespace

#region System.Runtime.Versioning Namespace
#region Classes
/*
ComponentGuaranteesAttribute
FrameworkName
ResourceConsumptionAttribute
ResourceExposureAttribute
TargetFrameworkAttribute
VersioningHelper
*/
#endregion Classes
#region Enums
/*
ComponentGuaranteesOptions
ResourceScope
*/
#endregion Enums
#endregion System.Runtime.Versioning Namespace

#region System.Security Namespace
#region Classes
/*
AllowPartiallyTrustedCallersAttribute
CodeAccessPermission
HostProtectionException
HostSecurityManager
NamedPermissionSet
PermissionSet
ReadOnlyPermissionSet
SecureString
SecureStringMarshal
SecurityContext
SecurityCriticalAttribute
SecurityElement
SecurityException
SecurityManager
SecurityRulesAttribute
SecuritySafeCriticalAttribute
SecurityState
SecurityTransparentAttribute
SecurityTreatAsSafeAttribute
SuppressUnmanagedCodeSecurityAttribute
UnverifiableCodeAttribute
VerificationException
XmlSyntaxException
*/
#endregion Classes
#region Interfaces
/*
IEvidenceFactory
IPermission
ISecurityEncodable
ISecurityPolicyEncodable
IStackWalk
*/
#endregion Interfaces
#region Enums
/*
HostSecurityManagerOptions
ManifestKinds
PartialTrustVisibilityLevel
PolicyLevelType
SecurityContextSource
SecurityCriticalScope
SecurityRuleSet
SecurityZone
*/
#endregion Enums
#endregion System.Security Namespace

#region System.Security.AccessControl Namespace
#region Classes
/*
AccessRule
AccessRule<T>
AceEnumerator
AuditRule
AuditRule<T>
AuthorizationRule
AuthorizationRuleCollection
CommonAce
CommonAcl
CommonObjectSecurity
CommonSecurityDescriptor
CompoundAce
CryptoKeyAccessRule
CryptoKeyAuditRule
CryptoKeySecurity
CustomAce
DirectoryObjectSecurity
DirectorySecurity
DiscretionaryAcl
EventWaitHandleAccessRule
EventWaitHandleAuditRule
EventWaitHandleSecurity
FileSecurity
FileSystemAccessRule
FileSystemAuditRule
FileSystemSecurity
GenericAce
GenericAcl
GenericSecurityDescriptor
KnownAce
MutexAccessRule
MutexAuditRule
MutexSecurity
NativeObjectSecurity
ObjectAccessRule
ObjectAce
ObjectAuditRule
ObjectSecurity
ObjectSecurity<T>
PrivilegeNotHeldException
QualifiedAce
RawAcl
RawSecurityDescriptor
RegistryAccessRule
RegistryAuditRule
RegistrySecurity
SemaphoreAccessRule
SemaphoreAuditRule
SemaphoreSecurity
SystemAcl
*/
#endregion Classes
#region Enums
/*
AccessControlActions
AccessControlModification
AccessControlSections
AccessControlType
AceFlags
AceQualifier
AceType
AuditFlags
CompoundAceType
ControlFlags
CryptoKeyRights
EventWaitHandleRights
FileSystemRights
InheritanceFlags
MutexRights
ObjectAceFlags
PropagationFlags
RegistryRights
ResourceType
SecurityInfos
SemaphoreRights
*/
#endregion Enums
#region Delegates
/*
NativeObjectSecurity.ExceptionFromErrorCode
*/
#endregion Delegates
#endregion System.Security.AccessControl Namespace

#region System.Security.Claims Namespace
#region Classes
/*
AuthenticationInformation
AuthenticationTypes
AuthorizationContext
Claim
ClaimProperties
ClaimsAuthenticationManager
ClaimsAuthorizationManager
ClaimsIdentity
ClaimsPrincipal
ClaimTypes
ClaimValueTypes
DynamicRoleClaimProvider
*/
#endregion Classes
#endregion System.Security.Claims Namespace

#region System.Security.Cryptography Namespace
#region Classes
/*
Aes
AesCng
AesCryptoServiceProvider
AesManaged
AsnEncodedData
AsnEncodedDataCollection
AsnEncodedDataEnumerator
AsymmetricAlgorithm
AsymmetricKeyExchangeDeformatter
AsymmetricKeyExchangeFormatter
AsymmetricSignatureDeformatter
AsymmetricSignatureFormatter
CngAlgorithm
CngAlgorithmGroup
CngKey
CngKeyBlobFormat
CngKeyCreationParameters
CngPropertyCollection
CngProvider
CngUIPolicy
CryptoAPITransform
CryptoConfig
CryptographicAttributeObject
CryptographicAttributeObjectCollection
CryptographicAttributeObjectEnumerator
CryptographicException
CryptographicUnexpectedOperationException
CryptoStream
CspKeyContainerInfo
CspParameters
DataProtector
DeriveBytes
DES
DESCryptoServiceProvider
DpapiDataProtector
DSA
DSACng
DSACryptoServiceProvider
DSASignatureDeformatter
DSASignatureFormatter
ECCurve.NamedCurves
ECDiffieHellman
ECDiffieHellmanCng
ECDiffieHellmanCngPublicKey
ECDiffieHellmanPublicKey
ECDsa
ECDsaCng
FromBase64Transform
HashAlgorithm
HMAC
HMACMD5
HMACRIPEMD160
HMACSHA1
HMACSHA256
HMACSHA384
HMACSHA512
IncrementalHash
KeyedHashAlgorithm
KeySizes
MACTripleDES
ManifestSignatureInformation
ManifestSignatureInformationCollection
MaskGenerationMethod
MD5
MD5Cng
MD5CryptoServiceProvider
Oid
OidCollection
OidEnumerator
PasswordDeriveBytes
PKCS1MaskGenerationMethod
ProtectedData
ProtectedMemory
RandomNumberGenerator
RC2
RC2CryptoServiceProvider
Rfc2898DeriveBytes
Rijndael
RijndaelManaged
RijndaelManagedTransform
RIPEMD160
RIPEMD160Managed
RNGCryptoServiceProvider
RSA
RSACng
RSACryptoServiceProvider
RSAEncryptionPadding
RSAOAEPKeyExchangeDeformatter
RSAOAEPKeyExchangeFormatter
RSAPKCS1KeyExchangeDeformatter
RSAPKCS1KeyExchangeFormatter
RSAPKCS1SignatureDeformatter
RSAPKCS1SignatureFormatter
RSASignaturePadding
SHA1
SHA1Cng
SHA1CryptoServiceProvider
SHA1Managed
SHA256
SHA256Cng
SHA256CryptoServiceProvider
SHA256Managed
SHA384
SHA384Cng
SHA384CryptoServiceProvider
SHA384Managed
SHA512
SHA512Cng
SHA512CryptoServiceProvider
SHA512Managed
SignatureDescription
StrongNameSignatureInformation
SymmetricAlgorithm
ToBase64Transform
TripleDES
TripleDESCng
TripleDESCryptoServiceProvider
*/
#endregion Classes
#region Structs
/*
CngProperty
DSAParameters
ECCurve
ECParameters
ECPoint
HashAlgorithmName
RSAParameters
*/
#endregion Structs
#region Interfaces
/*
ICryptoTransform
ICspAsymmetricAlgorithm
*/
#endregion Interfaces
#region Enums
/*
CipherMode
CngExportPolicies
CngKeyCreationOptions
CngKeyHandleOpenOptions
CngKeyOpenOptions
CngKeyUsages
CngPropertyOptions
CngUIProtectionLevels
CryptoStreamMode
CspProviderFlags
DataProtectionScope
ECCurve.ECCurveType
ECDiffieHellmanKeyDerivationFunction
ECKeyXmlFormat
FromBase64TransformMode
KeyNumber
MemoryProtectionScope
OidGroup
PaddingMode
RSAEncryptionPaddingMode
RSASignaturePaddingMode
SignatureVerificationResult
*/
#endregion Enums
#endregion System.Security.Cryptography Namespace

#region System.Security.Cryptography.X509Certificates Namespace
#region Classes
/*
AuthenticodeSignatureInformation
CertificateRequest
DSACertificateExtensions
ECDsaCertificateExtensions
PublicKey
RSACertificateExtensions
SubjectAlternativeNameBuilder
TimestampInformation
X500DistinguishedName
X509BasicConstraintsExtension
X509Certificate
X509Certificate2
X509Certificate2Collection
X509Certificate2Enumerator
X509Certificate2UI
X509CertificateCollection
X509CertificateCollection.X509CertificateEnumerator
X509Chain
X509ChainElement
X509ChainElementCollection
X509ChainElementEnumerator
X509ChainPolicy
X509EnhancedKeyUsageExtension
X509Extension
X509ExtensionCollection
X509ExtensionEnumerator
X509KeyUsageExtension
X509SignatureGenerator
X509Store
X509SubjectKeyIdentifierExtension
*/
#endregion Classes
#region Structs
/*
X509ChainStatus
*/
#endregion Structs
#region Enums
/*
OpenFlags
StoreLocation
StoreName
TrustStatus
X500DistinguishedNameFlags
X509ChainStatusFlags
X509ContentType
X509FindType
X509IncludeOption
X509KeyStorageFlags
X509KeyUsageFlags
X509NameType
X509RevocationFlag
X509RevocationMode
X509SelectionFlag
X509SubjectKeyIdentifierHashAlgorithm
X509VerificationFlags
*/
#endregion Enums
#endregion System.Security.Cryptography.X509Certificates Namespace

#region System.Security.Permissions Namespace
#region Classes
/*
CodeAccessSecurityAttribute
DataProtectionPermission
DataProtectionPermissionAttribute
EnvironmentPermission
EnvironmentPermissionAttribute
FileDialogPermission
FileDialogPermissionAttribute
FileIOPermission
FileIOPermissionAttribute
GacIdentityPermission
GacIdentityPermissionAttribute
HostProtectionAttribute
IsolatedStorageFilePermission
IsolatedStorageFilePermissionAttribute
IsolatedStoragePermission
IsolatedStoragePermissionAttribute
KeyContainerPermission
KeyContainerPermissionAccessEntry
KeyContainerPermissionAccessEntryCollection
KeyContainerPermissionAccessEntryEnumerator
KeyContainerPermissionAttribute
MediaPermission
MediaPermissionAttribute
PermissionSetAttribute
PrincipalPermission
PrincipalPermissionAttribute
PublisherIdentityPermission
PublisherIdentityPermissionAttribute
ReflectionPermission
ReflectionPermissionAttribute
RegistryPermission
RegistryPermissionAttribute
ResourcePermissionBase
ResourcePermissionBaseEntry
SecurityAttribute
SecurityPermission
SecurityPermissionAttribute
SiteIdentityPermission
SiteIdentityPermissionAttribute
StorePermission
StorePermissionAttribute
StrongNameIdentityPermission
StrongNameIdentityPermissionAttribute
StrongNamePublicKeyBlob
TypeDescriptorPermission
TypeDescriptorPermissionAttribute
UIPermission
UIPermissionAttribute
UrlIdentityPermission
UrlIdentityPermissionAttribute
WebBrowserPermission
WebBrowserPermissionAttribute
ZoneIdentityPermission
ZoneIdentityPermissionAttribute
*/
#endregion Classes
#region Interfaces
/*
IUnrestrictedPermission
*/
#endregion Interfaces
#region Enums
/*
DataProtectionPermissionFlags
EnvironmentPermissionAccess
FileDialogPermissionAccess
FileIOPermissionAccess
HostProtectionResource
IsolatedStorageContainment
KeyContainerPermissionFlags
MediaPermissionAudio
MediaPermissionImage
MediaPermissionVideo
PermissionState
ReflectionPermissionFlag
RegistryPermissionAccess
SecurityAction
SecurityPermissionFlag
StorePermissionFlags
TypeDescriptorPermissionFlags
UIPermissionClipboard
UIPermissionWindow
WebBrowserPermissionLevel
*/
#endregion Enums
#endregion System.Security.Permissions Namespace

#region System.Security.Policy Namespace
#region Classes
/*
AllMembershipCondition
ApplicationDirectory
ApplicationDirectoryMembershipCondition
ApplicationSecurityInfo
ApplicationSecurityManager
ApplicationTrust
ApplicationTrustCollection
ApplicationTrustEnumerator
CodeConnectAccess
CodeGroup
Evidence
EvidenceBase
FileCodeGroup
FirstMatchCodeGroup
GacInstalled
GacMembershipCondition
Hash
HashMembershipCondition
NetCodeGroup
PermissionRequestEvidence
PolicyException
PolicyLevel
PolicyStatement
Publisher
PublisherMembershipCondition
Site
SiteMembershipCondition
StrongName
StrongNameMembershipCondition
TrustManagerContext
UnionCodeGroup
Url
UrlMembershipCondition
Zone
ZoneMembershipCondition
*/
#endregion Classes
#region Interfaces
/*
IApplicationTrustManager
IIdentityPermissionFactory
IMembershipCondition
*/
#endregion Interfaces
#region Enums
/*
ApplicationVersionMatch
PolicyStatementAttribute
TrustManagerUIContext
*/
#endregion Enums
#endregion System.Security.Policy Namespace

#region System.Security.Principal Namespace
#region Classes
/*
GenericIdentity
GenericPrincipal
IdentityNotMappedException
IdentityReference
IdentityReferenceCollection
NTAccount
SecurityIdentifier
WindowsIdentity
WindowsImpersonationContext
WindowsPrincipal
*/
#endregion Classes
#region Interfaces
/*
IIdentity
IPrincipal
*/
#endregion Interfaces
#region Enums
/*
PrincipalPolicy
TokenAccessLevels
TokenImpersonationLevel
WellKnownSidType
WindowsAccountType
WindowsBuiltInRole
*/
#endregion Enums
#endregion System.Security.Principal Namespace

#region System.Security.Util Namespace
#region Classes
/*
Config
DirectoryString
Hex
LocalSiteString
Parser
SiteString
StringExpressionSet
TokenBasedSet
Tokenizer
TokenizerShortBlock
TokenizerStream
TokenizerStringBlock
URLString
XMLUtil
*/
#endregion Classes
#region Structs
/*
TokenBasedSetEnumerator
*/
#endregion Structs
#region Enums
/*
QuickCacheEntryType
*/
#endregion Enums
#endregion System.Security.Util Namespace

#region System.StubHelpers Namespace
#region Classes
/*
AnsiBSTRMarshaler
AnsiCharMarshaler
BSTRMarshaler
CleanupWorkList
CleanupWorkListElement
CSTRMarshaler
DateMarshaler
DateTimeOffsetMarshaler
EventArgsMarshaler
HResultExceptionMarshaler
HStringMarshaler
InterfaceMarshaler
KeyValuePairMarshaler
MngdHiddenLengthArrayMarshaler
MngdNativeArrayMarshaler
MngdRefCustomMarshaler
MngdSafeArrayMarshaler
NullableMarshaler
ObjectMarshaler
StubHelpers
SystemTypeMarshaler
UriMarshaler
UTF8BufferMarshaler
UTF8Marshaler
ValueClassMarshaler
VBByValStrMarshaler
WinRTTypeNameConverter
WSTRBufferMarshaler
*/
#endregion Classes
#region Structs
/*
AsAnyMarshaler
CopyCtorStubCookie
CopyCtorStubDesc
DateTimeNative
NativeVariant
TypeNameNative
*/
#endregion Structs
#region Enums
/*
TypeKind
*/
#endregion Enums
#endregion System.StubHelpers Namespace

#region System.Text Namespace
#region Classes
/*
ASCIIEncoding
Decoder
DecoderExceptionFallback
DecoderExceptionFallbackBuffer
DecoderFallback
DecoderFallbackBuffer
DecoderFallbackException
DecoderReplacementFallback
DecoderReplacementFallbackBuffer
Encoder
EncoderExceptionFallback
EncoderExceptionFallbackBuffer
EncoderFallback
EncoderFallbackBuffer
EncoderFallbackException
EncoderReplacementFallback
EncoderReplacementFallbackBuffer
Encoding
EncodingInfo
EncodingProvider
StringBuilder
UnicodeEncoding
UTF32Encoding
UTF7Encoding
UTF8Encoding
*/
#endregion Classes
#region Enums
/*
NormalizationForm
*/
#endregion Enums
#endregion System.Text Namespace

#region System.Threading Namespace
#region Classes
/*
AbandonedMutexException
AsyncLocal<T>
AutoResetEvent
Barrier
BarrierPostPhaseException
CancellationTokenSource
CompressedStack
CountdownEvent
EventWaitHandle
ExecutionContext
HostExecutionContext
HostExecutionContextManager
Interlocked
LazyInitializer
LockRecursionException
ManualResetEvent
ManualResetEventSlim
Monitor
Mutex
Overlapped
PreAllocatedOverlapped
ReaderWriterLock
ReaderWriterLockSlim
RegisteredWaitHandle
Semaphore
SemaphoreFullException
SemaphoreSlim
SynchronizationContext
SynchronizationLockException
Thread
ThreadAbortException
ThreadExceptionEventArgs
ThreadInterruptedException
ThreadLocal<T>
ThreadPool
ThreadPoolBoundHandle
ThreadStartException
ThreadStateException
Timeout
Timer
Volatile
WaitHandle
WaitHandleCannotBeOpenedException
WaitHandleExtensions
*/
#endregion Classes
#region Structs
/*
AsyncFlowControl
AsyncLocalValueChangedArgs<T>
CancellationToken
CancellationTokenRegistration
LockCookie
NativeOverlapped
SpinLock
SpinWait
*/
#endregion Structs
#region Enums
/*
ApartmentState
EventResetMode
LazyThreadSafetyMode
LockRecursionPolicy
ThreadPriority
ThreadState
*/
#endregion Enums
#region Delegates
/*
ContextCallback
IOCompletionCallback
ParameterizedThreadStart
SendOrPostCallback
ThreadExceptionEventHandler
ThreadStart
TimerCallback
WaitCallback
WaitOrTimerCallback
*/
#endregion Delegates
#endregion System.Threading Namespace

#region System.Threading.Tasks Namespace
#region Classes
/*
ConcurrentExclusiveSchedulerPair
Parallel
ParallelLoopState
ParallelOptions
Task
Task<TResult>
TaskCanceledException
TaskCompletionSource<TResult>
TaskExtensions
TaskFactory
TaskFactory<TResult>
TaskScheduler
TaskSchedulerException
UnobservedTaskExceptionEventArgs
*/
#endregion Classes
#region Structs
/*
ParallelLoopResult
*/
#endregion Structs
#region Enums
/*
TaskContinuationOptions
TaskCreationOptions
TaskStatus
*/
#endregion Enums
#endregion System.Threading.Tasks Namespace
