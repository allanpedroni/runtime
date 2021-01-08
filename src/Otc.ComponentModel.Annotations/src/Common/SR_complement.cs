// These sources have been forked from https://github.com/dotnet/corefx/releases/tag/v1.1.8
// then customized by Ole Consignado in order to meet it needs.
// Original sources should be found at: https://github.com/dotnet/corefx/tree/v1.1.8/src/System.ComponentModel.Annotations
// Thanks to Microsoft for making it open source!

// Generated from corefx build
// ResourceType was adapted to load local resource

namespace Otc
{
    internal static partial class SR
    {
        internal static System.Type ResourceType { get; } = typeof(Otc.ComponentModel.Annotations.Resources.Strings);
    }

    internal static partial class SR
    {
        /// <summary>The argument '{0}' cannot be null, empty or contain only whitespace.</summary>
        internal static string @ArgumentIsNullOrWhitespace => GetResourceString("ArgumentIsNullOrWhitespace", @"The argument '{0}' cannot be null, empty or contain only whitespace.");
        /// <summary>The associated metadata type for type '{0}' contains the following unknown properties or fields: {1}. Please make sure that the names of these members match the names of the properties on the main type.</summary>
        internal static string @AssociatedMetadataTypeTypeDescriptor_MetadataTypeContainsUnknownProperties => GetResourceString("AssociatedMetadataTypeTypeDescriptor_MetadataTypeContainsUnknownProperties", @"The associated metadata type for type '{0}' contains the following unknown properties or fields: {1}. Please make sure that the names of these members match the names of the properties on the main type.");
        /// <summary>The type '{0}' does not contain a public property named '{1}'.</summary>
        internal static string @AttributeStore_Unknown_Property => GetResourceString("AttributeStore_Unknown_Property", @"The type '{0}' does not contain a public property named '{1}'.");
        /// <summary>The property {0}.{1} could not be found.</summary>
        internal static string @Common_PropertyNotFound => GetResourceString("Common_PropertyNotFound", @"The property {0}.{1} could not be found.");
        /// <summary>'{0}' and '{1}' do not match.</summary>
        internal static string @CompareAttribute_MustMatch => GetResourceString("CompareAttribute_MustMatch", @"'{0}' and '{1}' do not match.");
        /// <summary>Could not find a property named {0}.</summary>
        internal static string @CompareAttribute_UnknownProperty => GetResourceString("CompareAttribute_UnknownProperty", @"Could not find a property named {0}.");
        /// <summary>The {0} field is not a valid credit card number.</summary>
        internal static string @CreditCardAttribute_Invalid => GetResourceString("CreditCardAttribute_Invalid", @"The {0} field is not a valid credit card number.");
        /// <summary>The CustomValidationAttribute method '{0}' in type '{1}' must return Otc.ComponentModel.DataAnnotations.ValidationResult.  Use Otc.ComponentModel.DataAnnotations.ValidationResult.Success to represent success.</summary>
        internal static string @CustomValidationAttribute_Method_Must_Return_ValidationResult => GetResourceString("CustomValidationAttribute_Method_Must_Return_ValidationResult", @"The CustomValidationAttribute method '{0}' in type '{1}' must return Otc.ComponentModel.DataAnnotations.ValidationResult.  Use Otc.ComponentModel.DataAnnotations.ValidationResult.Success to represent success.");
        /// <summary>The CustomValidationAttribute method '{0}' does not exist in type '{1}' or is not public and static.</summary>
        internal static string @CustomValidationAttribute_Method_Not_Found => GetResourceString("CustomValidationAttribute_Method_Not_Found", @"The CustomValidationAttribute method '{0}' does not exist in type '{1}' or is not public and static.");
        /// <summary>The CustomValidationAttribute.Method was not specified.</summary>
        internal static string @CustomValidationAttribute_Method_Required => GetResourceString("CustomValidationAttribute_Method_Required", @"The CustomValidationAttribute.Method was not specified.");
        /// <summary>The CustomValidationAttribute method '{0}' in type '{1}' must match the expected signature: public static ValidationResult {0}(object value, ValidationContext context).  The value can be strongly typed.  The ValidationContext parameter is optional.</summary>
        internal static string @CustomValidationAttribute_Method_Signature => GetResourceString("CustomValidationAttribute_Method_Signature", @"The CustomValidationAttribute method '{0}' in type '{1}' must match the expected signature: public static ValidationResult {0}(object value, ValidationContext context).  The value can be strongly typed.  The ValidationContext parameter is optional.");
        /// <summary>Could not convert the value of type '{0}' to '{1}' as expected by method {2}.{3}.</summary>
        internal static string @CustomValidationAttribute_Type_Conversion_Failed => GetResourceString("CustomValidationAttribute_Type_Conversion_Failed", @"Could not convert the value of type '{0}' to '{1}' as expected by method {2}.{3}.");
        /// <summary>The custom validation type '{0}' must be public.</summary>
        internal static string @CustomValidationAttribute_Type_Must_Be_Public => GetResourceString("CustomValidationAttribute_Type_Must_Be_Public", @"The custom validation type '{0}' must be public.");
        /// <summary>{0} is not valid.</summary>
        internal static string @CustomValidationAttribute_ValidationError => GetResourceString("CustomValidationAttribute_ValidationError", @"{0} is not valid.");
        /// <summary>The CustomValidationAttribute.ValidatorType was not specified.</summary>
        internal static string @CustomValidationAttribute_ValidatorType_Required => GetResourceString("CustomValidationAttribute_ValidatorType_Required", @"The CustomValidationAttribute.ValidatorType was not specified.");
        /// <summary>The custom DataType string cannot be null or empty.</summary>
        internal static string @DataTypeAttribute_EmptyDataTypeString => GetResourceString("DataTypeAttribute_EmptyDataTypeString", @"The custom DataType string cannot be null or empty.");
        /// <summary>The {0} property has not been set.  Use the {1} method to get the value.</summary>
        internal static string @DisplayAttribute_PropertyNotSet => GetResourceString("DisplayAttribute_PropertyNotSet", @"The {0} property has not been set.  Use the {1} method to get the value.");
        /// <summary>The {0} field is not a valid e-mail address.</summary>
        internal static string @EmailAddressAttribute_Invalid => GetResourceString("EmailAddressAttribute_Invalid", @"The {0} field is not a valid e-mail address.");
        /// <summary>The type provided for EnumDataTypeAttribute cannot be null.</summary>
        internal static string @EnumDataTypeAttribute_TypeCannotBeNull => GetResourceString("EnumDataTypeAttribute_TypeCannotBeNull", @"The type provided for EnumDataTypeAttribute cannot be null.");
        /// <summary>The type '{0}' needs to represent an enumeration type.</summary>
        internal static string @EnumDataTypeAttribute_TypeNeedsToBeAnEnum => GetResourceString("EnumDataTypeAttribute_TypeNeedsToBeAnEnum", @"The type '{0}' needs to represent an enumeration type.");
        /// <summary>The {0} field only accepts files with the following extensions: {1}</summary>
        internal static string @FileExtensionsAttribute_Invalid => GetResourceString("FileExtensionsAttribute_Invalid", @"The {0} field only accepts files with the following extensions: {1}");
        /// <summary>Cannot retrieve property '{0}' because localization failed.  Type '{1}' is not public or does not contain a public static string property with the name '{2}'.</summary>
        internal static string @LocalizableString_LocalizationFailed => GetResourceString("LocalizableString_LocalizationFailed", @"Cannot retrieve property '{0}' because localization failed.  Type '{1}' is not public or does not contain a public static string property with the name '{2}'.");
        /// <summary>MaxLengthAttribute must have a Length value that is greater than zero. Use MaxLength() without parameters to indicate that the string or array can have the maximum allowable length.</summary>
        internal static string @MaxLengthAttribute_InvalidMaxLength => GetResourceString("MaxLengthAttribute_InvalidMaxLength", @"MaxLengthAttribute must have a Length value that is greater than zero. Use MaxLength() without parameters to indicate that the string or array can have the maximum allowable length.");
        /// <summary>The field {0} must be a string or array type with a maximum length of '{1}'.</summary>
        internal static string @MaxLengthAttribute_ValidationError => GetResourceString("MaxLengthAttribute_ValidationError", @"The field {0} must be a string or array type with a maximum length of '{1}'.");
        /// <summary>MetadataClassType cannot be null.</summary>
        internal static string @MetadataTypeAttribute_TypeCannotBeNull => GetResourceString("MetadataTypeAttribute_TypeCannotBeNull", @"MetadataClassType cannot be null.");
        /// <summary>MinLengthAttribute must have a Length value that is zero or greater.</summary>
        internal static string @MinLengthAttribute_InvalidMinLength => GetResourceString("MinLengthAttribute_InvalidMinLength", @"MinLengthAttribute must have a Length value that is zero or greater.");
        /// <summary>The field {0} must be a string or array type with a minimum length of '{1}'.</summary>
        internal static string @MinLengthAttribute_ValidationError => GetResourceString("MinLengthAttribute_ValidationError", @"The field {0} must be a string or array type with a minimum length of '{1}'.");
        /// <summary>The field of type {0} must be a string, array or ICollection type.</summary>
        internal static string @LengthAttribute_InvalidValueType => GetResourceString("LengthAttribute_InvalidValueType", @"The field of type {0} must be a string, array or ICollection type.");
        /// <summary>The {0} field is not a valid phone number.</summary>
        internal static string @PhoneAttribute_Invalid => GetResourceString("PhoneAttribute_Invalid", @"The {0} field is not a valid phone number.");
        /// <summary>The type {0} must implement {1}.</summary>
        internal static string @RangeAttribute_ArbitraryTypeNotIComparable => GetResourceString("RangeAttribute_ArbitraryTypeNotIComparable", @"The type {0} must implement {1}.");
        /// <summary>The maximum value '{0}' must be greater than or equal to the minimum value '{1}'.</summary>
        internal static string @RangeAttribute_MinGreaterThanMax => GetResourceString("RangeAttribute_MinGreaterThanMax", @"The maximum value '{0}' must be greater than or equal to the minimum value '{1}'.");
        /// <summary>The minimum and maximum values must be set.</summary>
        internal static string @RangeAttribute_Must_Set_Min_And_Max => GetResourceString("RangeAttribute_Must_Set_Min_And_Max", @"The minimum and maximum values must be set.");
        /// <summary>The OperandType must be set when strings are used for minimum and maximum values.</summary>
        internal static string @RangeAttribute_Must_Set_Operand_Type => GetResourceString("RangeAttribute_Must_Set_Operand_Type", @"The OperandType must be set when strings are used for minimum and maximum values.");
        /// <summary>The field {0} must be between {1} and {2}.</summary>
        internal static string @RangeAttribute_ValidationError => GetResourceString("RangeAttribute_ValidationError", @"The field {0} must be between {1} and {2}.");
        /// <summary>The field {0} must match the regular expression '{1}'.</summary>
        internal static string @RegexAttribute_ValidationError => GetResourceString("RegexAttribute_ValidationError", @"The field {0} must match the regular expression '{1}'.");
        /// <summary>The pattern must be set to a valid regular expression.</summary>
        internal static string @RegularExpressionAttribute_Empty_Pattern => GetResourceString("RegularExpressionAttribute_Empty_Pattern", @"The pattern must be set to a valid regular expression.");
        /// <summary>The {0} field is required.</summary>
        internal static string @RequiredAttribute_ValidationError => GetResourceString("RequiredAttribute_ValidationError", @"The {0} field is required.");
        /// <summary>The maximum length must be a nonnegative integer.</summary>
        internal static string @StringLengthAttribute_InvalidMaxLength => GetResourceString("StringLengthAttribute_InvalidMaxLength", @"The maximum length must be a nonnegative integer.");
        /// <summary>The field {0} must be a string with a maximum length of {1}.</summary>
        internal static string @StringLengthAttribute_ValidationError => GetResourceString("StringLengthAttribute_ValidationError", @"The field {0} must be a string with a maximum length of {1}.");
        /// <summary>The field {0} must be a string with a minimum length of {2} and a maximum length of {1}.</summary>
        internal static string @StringLengthAttribute_ValidationErrorIncludingMinimum => GetResourceString("StringLengthAttribute_ValidationErrorIncludingMinimum", @"The field {0} must be a string with a minimum length of {2} and a maximum length of {1}.");
        /// <summary>The key parameter at position {0} with value '{1}' is not a string. Every key control parameter must be a string.</summary>
        internal static string @UIHintImplementation_ControlParameterKeyIsNotAString => GetResourceString("UIHintImplementation_ControlParameterKeyIsNotAString", @"The key parameter at position {0} with value '{1}' is not a string. Every key control parameter must be a string.");
        /// <summary>The key parameter at position {0} is null. Every key control parameter must be a string.</summary>
        internal static string @UIHintImplementation_ControlParameterKeyIsNull => GetResourceString("UIHintImplementation_ControlParameterKeyIsNull", @"The key parameter at position {0} is null. Every key control parameter must be a string.");
        /// <summary>The key parameter at position {0} with value '{1}' occurs more than once.</summary>
        internal static string @UIHintImplementation_ControlParameterKeyOccursMoreThanOnce => GetResourceString("UIHintImplementation_ControlParameterKeyOccursMoreThanOnce", @"The key parameter at position {0} with value '{1}' occurs more than once.");
        /// <summary>The number of control parameters must be even.</summary>
        internal static string @UIHintImplementation_NeedEvenNumberOfControlParameters => GetResourceString("UIHintImplementation_NeedEvenNumberOfControlParameters", @"The number of control parameters must be even.");
        /// <summary>The {0} field is not a valid fully-qualified http, https, or ftp URL.</summary>
        internal static string @UrlAttribute_Invalid => GetResourceString("UrlAttribute_Invalid", @"The {0} field is not a valid fully-qualified http, https, or ftp URL.");
        /// <summary>Either ErrorMessageString or ErrorMessageResourceName must be set, but not both.</summary>
        internal static string @ValidationAttribute_Cannot_Set_ErrorMessage_And_Resource => GetResourceString("ValidationAttribute_Cannot_Set_ErrorMessage_And_Resource", @"Either ErrorMessageString or ErrorMessageResourceName must be set, but not both.");
        /// <summary>IsValid(object value) has not been implemented by this class.  The preferred entry point is GetValidationResult() and classes should override IsValid(object value, ValidationContext context).</summary>
        internal static string @ValidationAttribute_IsValid_NotImplemented => GetResourceString("ValidationAttribute_IsValid_NotImplemented", @"IsValid(object value) has not been implemented by this class.  The preferred entry point is GetValidationResult() and classes should override IsValid(object value, ValidationContext context).");
        /// <summary>Both ErrorMessageResourceType and ErrorMessageResourceName need to be set on this attribute.</summary>
        internal static string @ValidationAttribute_NeedBothResourceTypeAndResourceName => GetResourceString("ValidationAttribute_NeedBothResourceTypeAndResourceName", @"Both ErrorMessageResourceType and ErrorMessageResourceName need to be set on this attribute.");
        /// <summary>The property '{0}' on resource type '{1}' is not a string type.</summary>
        internal static string @ValidationAttribute_ResourcePropertyNotStringType => GetResourceString("ValidationAttribute_ResourcePropertyNotStringType", @"The property '{0}' on resource type '{1}' is not a string type.");
        /// <summary>The resource type '{0}' does not have an accessible static property named '{1}'.</summary>
        internal static string @ValidationAttribute_ResourceTypeDoesNotHaveProperty => GetResourceString("ValidationAttribute_ResourceTypeDoesNotHaveProperty", @"The resource type '{0}' does not have an accessible static property named '{1}'.");
        /// <summary>The field {0} is invalid.</summary>
        internal static string @ValidationAttribute_ValidationError => GetResourceString("ValidationAttribute_ValidationError", @"The field {0} is invalid.");
        /// <summary>The instance provided must match the ObjectInstance on the ValidationContext supplied.</summary>
        internal static string @Validator_InstanceMustMatchValidationContextInstance => GetResourceString("Validator_InstanceMustMatchValidationContextInstance", @"The instance provided must match the ObjectInstance on the ValidationContext supplied.");
        /// <summary>The value for property '{0}' must be of type '{1}'.</summary>
        internal static string @Validator_Property_Value_Wrong_Type => GetResourceString("Validator_Property_Value_Wrong_Type", @"The value for property '{0}' must be of type '{1}'.");
    }

}
