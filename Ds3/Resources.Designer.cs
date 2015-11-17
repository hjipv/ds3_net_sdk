﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ds3 {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ds3.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received a status code of {0} when one of {1} was expected. Error message: &quot;{2}&quot;.
        /// </summary>
        internal static string BadStatusCodeException {
            get {
                return ResourceManager.GetString("BadStatusCodeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received a status code of {0} when one of {1} was expected. Could not parse the response for additional information..
        /// </summary>
        internal static string BadStatusCodeInvalidErrorResponseException {
            get {
                return ResourceManager.GetString("BadStatusCodeInvalidErrorResponseException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must provide a seekable stream when wrapping a WindowedStream..
        /// </summary>
        internal static string CannotSeekStreamException {
            get {
                return ResourceManager.GetString("CannotSeekStreamException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Content length ({0}) not match the number of byte read ({1}).
        /// </summary>
        internal static string ContentLengthNotMatch {
            get {
                return ResourceManager.GetString("ContentLengthNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered 307 number: {0}.
        /// </summary>
        internal static string Encountered307NTimes {
            get {
                return ResourceManager.GetString("Encountered307NTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some of the provided enumerators are not equal in length..
        /// </summary>
        internal static string EnumeratorsNotOfEqualLengthException {
            get {
                return ResourceManager.GetString("EnumeratorsNotOfEqualLengthException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comparison argument must be of the same type..
        /// </summary>
        internal static string ExpectedObjectOfSameTypeException {
            get {
                return ResourceManager.GetString("ExpectedObjectOfSameTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a PUT job, but was a GET job..
        /// </summary>
        internal static string ExpectedPutJobButWasGetJobException {
            get {
                return ResourceManager.GetString("ExpectedPutJobButWasGetJobException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered an exception when formating xml string..
        /// </summary>
        internal static string FormatXmlException {
            get {
                return ResourceManager.GetString("FormatXmlException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This handle was already disposed. This is a bug. Please make Disposing only fire once..
        /// </summary>
        internal static string HandleAlreadyDisposedException {
            get {
                return ResourceManager.GetString("HandleAlreadyDisposedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This handle to a shared object has already been used..
        /// </summary>
        internal static string HandleAlreadyUsedException {
            get {
                return ResourceManager.GetString("HandleAlreadyUsedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This handle to a shared resource was not expected..
        /// </summary>
        internal static string HandleDoesNotExistException {
            get {
                return ResourceManager.GetString("HandleDoesNotExistException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enum value not accounted for in a switch statement intended to be exhaustive..
        /// </summary>
        internal static string InvalidEnumValueException {
            get {
                return ResourceManager.GetString("InvalidEnumValueException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected offset {1} for key &apos;{0}&apos; when releasing stream..
        /// </summary>
        internal static string InvalidOffsetException {
            get {
                return ResourceManager.GetString("InvalidOffsetException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid SeekOrigin: {0}.
        /// </summary>
        internal static string InvalidSeekOrigin {
            get {
                return ResourceManager.GetString("InvalidSeekOrigin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PUT object streams must be readable..
        /// </summary>
        internal static string InvalidStreamException {
            get {
                return ResourceManager.GetString("InvalidStreamException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value for type: {0}.
        /// </summary>
        internal static string InvalidValueForTypeException {
            get {
                return ResourceManager.GetString("InvalidValueForTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The job went away as we were trying to acquire chunk information..
        /// </summary>
        internal static string JobGoneException {
            get {
                return ResourceManager.GetString("JobGoneException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected an element called &quot;{0}&quot; but didn&apos;t find it..
        /// </summary>
        internal static string MissingElementException {
            get {
                return ResourceManager.GetString("MissingElementException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a header called &quot;{0}&quot; but didn&apos;t find it..
        /// </summary>
        internal static string MissingHeaderException {
            get {
                return ResourceManager.GetString("MissingHeaderException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reached the limit number of retries request.
        /// </summary>
        internal static string NoMoreRetriesException {
            get {
                return ResourceManager.GetString("NoMoreRetriesException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tried to perform a bulk job but there were no objects to transfer..
        /// </summary>
        internal static string NoObjectsToTransferException {
            get {
                return ResourceManager.GetString("NoObjectsToTransferException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some or all of the objects to put are missing a size field..
        /// </summary>
        internal static string ObjectsMissingSizeException {
            get {
                return ResourceManager.GetString("ObjectsMissingSizeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested range was not available to be marked completed..
        /// </summary>
        internal static string RangeNotTrackedException {
            get {
                return ResourceManager.GetString("RangeNotTrackedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ranges {0} and {1} do not overlap..
        /// </summary>
        internal static string RangesDoNotOverlapException {
            get {
                return ResourceManager.GetString("RangesDoNotOverlapException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request: {0}.
        /// </summary>
        internal static string RequestLogging {
            get {
                return ResourceManager.GetString("RequestLogging", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to | Response status: {0} ({1}ms).
        /// </summary>
        internal static string ResponseLogging {
            get {
                return ResourceManager.GetString("ResponseLogging", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job tried to open stream for key &apos;{0}&apos;, but that key should not be available. This is probably a bug in the helpers..
        /// </summary>
        internal static string StreamUnavailableException {
            get {
                return ResourceManager.GetString("StreamUnavailableException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many redirects..
        /// </summary>
        internal static string TooManyRedirectsException {
            get {
                return ResourceManager.GetString("TooManyRedirectsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exhausted retries for retrieving data when partial data was received..
        /// </summary>
        internal static string TooManyRetriesForPartialData {
            get {
                return ResourceManager.GetString("TooManyRetriesForPartialData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered an error while reading XML response: &quot;{0}&quot;.
        /// </summary>
        internal static string XmlResponseErrorException {
            get {
                return ResourceManager.GetString("XmlResponseErrorException", resourceCulture);
            }
        }
    }
}
