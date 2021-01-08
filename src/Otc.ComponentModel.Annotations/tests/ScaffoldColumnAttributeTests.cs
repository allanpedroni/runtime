// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Otc.ComponentModel.DataAnnotations;
using Xunit;

namespace Otc.ComponentModel.Annotations.Tests
{
    public class ScaffoldColumnAttributeTests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Ctor_Bool(bool value)
        {
            var attribute = new ScaffoldColumnAttribute(value);
            Assert.Equal(value, attribute.Scaffold);
        }
    }
}
