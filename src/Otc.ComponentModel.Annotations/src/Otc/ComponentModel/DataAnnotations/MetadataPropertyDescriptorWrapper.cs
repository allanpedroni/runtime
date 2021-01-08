// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.ComponentModel;
using System.Linq;

namespace Otc.ComponentModel.DataAnnotations
{
    internal class MetadataPropertyDescriptorWrapper : PropertyDescriptor
    {
        private readonly PropertyDescriptor descriptor;
        private readonly bool isReadOnly;

        public MetadataPropertyDescriptorWrapper(PropertyDescriptor descriptor, Attribute[] newAttributes)
            : base(descriptor, newAttributes)
        {
            this.descriptor = descriptor;
            var readOnlyAttribute = newAttributes.OfType<ReadOnlyAttribute>().FirstOrDefault();
            isReadOnly = (readOnlyAttribute != null ? readOnlyAttribute.IsReadOnly : false);
        }

        public override void AddValueChanged(object component, EventHandler handler) { descriptor.AddValueChanged(component, handler); }

        public override bool CanResetValue(object component) { return descriptor.CanResetValue(component); }

        public override Type ComponentType { get { return descriptor.ComponentType; } }

        public override object GetValue(object component) { return descriptor.GetValue(component); }

        public override bool IsReadOnly
        {
            get
            {
                // Dev10 Bug 594083
                // It's not enough to call the wrapped _descriptor because it does not know anything about
                // new attributes passed into the constructor of this class.
                return isReadOnly || descriptor.IsReadOnly;
            }
        }

        public override Type PropertyType { get { return descriptor.PropertyType; } }

        public override void RemoveValueChanged(object component, EventHandler handler) { descriptor.RemoveValueChanged(component, handler); }

        public override void ResetValue(object component) { descriptor.ResetValue(component); }

        public override void SetValue(object component, object value) { descriptor.SetValue(component, value); }

        public override bool ShouldSerializeValue(object component) { return descriptor.ShouldSerializeValue(component); }

        public override bool SupportsChangeEvents { get { return descriptor.SupportsChangeEvents; } }
    }
}
