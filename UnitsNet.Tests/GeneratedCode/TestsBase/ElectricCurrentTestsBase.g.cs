﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricCurrent.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricCurrentTestsBase : QuantityTestsBase
    {
        protected abstract double AmperesInOneAmpere { get; }
        protected abstract double CentiamperesInOneAmpere { get; }
        protected abstract double KiloamperesInOneAmpere { get; }
        protected abstract double MegaamperesInOneAmpere { get; }
        protected abstract double MicroamperesInOneAmpere { get; }
        protected abstract double MilliamperesInOneAmpere { get; }
        protected abstract double NanoamperesInOneAmpere { get; }
        protected abstract double PicoamperesInOneAmpere { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmperesTolerance { get { return 1e-5; } }
        protected virtual double CentiamperesTolerance { get { return 1e-5; } }
        protected virtual double KiloamperesTolerance { get { return 1e-5; } }
        protected virtual double MegaamperesTolerance { get { return 1e-5; } }
        protected virtual double MicroamperesTolerance { get { return 1e-5; } }
        protected virtual double MilliamperesTolerance { get { return 1e-5; } }
        protected virtual double NanoamperesTolerance { get { return 1e-5; } }
        protected virtual double PicoamperesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrent((double)0.0, ElectricCurrentUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricCurrent();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricCurrentUnit.Ampere, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrent(double.PositiveInfinity, ElectricCurrentUnit.Ampere));
            Assert.Throws<ArgumentException>(() => new ElectricCurrent(double.NegativeInfinity, ElectricCurrentUnit.Ampere));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrent(double.NaN, ElectricCurrentUnit.Ampere));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricCurrent(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricCurrent(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricCurrent) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricCurrent_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricCurrent(1, ElectricCurrentUnit.Ampere);

            QuantityInfo<ElectricCurrentUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricCurrent.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricCurrent", quantityInfo.Name);
            Assert.Equal(QuantityType.ElectricCurrent, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ElectricCurrentUnit>().Except(new[] {ElectricCurrentUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void AmpereToElectricCurrentUnits()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(AmperesInOneAmpere, ampere.Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(CentiamperesInOneAmpere, ampere.Centiamperes, CentiamperesTolerance);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, ampere.Kiloamperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, ampere.Megaamperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, ampere.Microamperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, ampere.Milliamperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, ampere.Nanoamperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, ampere.Picoamperes, PicoamperesTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricCurrent.From(1, ElectricCurrentUnit.Ampere);
            AssertEx.EqualTolerance(1, quantity00.Amperes, AmperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Ampere, quantity00.Unit);

            var quantity01 = ElectricCurrent.From(1, ElectricCurrentUnit.Centiampere);
            AssertEx.EqualTolerance(1, quantity01.Centiamperes, CentiamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Centiampere, quantity01.Unit);

            var quantity02 = ElectricCurrent.From(1, ElectricCurrentUnit.Kiloampere);
            AssertEx.EqualTolerance(1, quantity02.Kiloamperes, KiloamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Kiloampere, quantity02.Unit);

            var quantity03 = ElectricCurrent.From(1, ElectricCurrentUnit.Megaampere);
            AssertEx.EqualTolerance(1, quantity03.Megaamperes, MegaamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Megaampere, quantity03.Unit);

            var quantity04 = ElectricCurrent.From(1, ElectricCurrentUnit.Microampere);
            AssertEx.EqualTolerance(1, quantity04.Microamperes, MicroamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Microampere, quantity04.Unit);

            var quantity05 = ElectricCurrent.From(1, ElectricCurrentUnit.Milliampere);
            AssertEx.EqualTolerance(1, quantity05.Milliamperes, MilliamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Milliampere, quantity05.Unit);

            var quantity06 = ElectricCurrent.From(1, ElectricCurrentUnit.Nanoampere);
            AssertEx.EqualTolerance(1, quantity06.Nanoamperes, NanoamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Nanoampere, quantity06.Unit);

            var quantity07 = ElectricCurrent.From(1, ElectricCurrentUnit.Picoampere);
            AssertEx.EqualTolerance(1, quantity07.Picoamperes, PicoamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Picoampere, quantity07.Unit);

        }

        [Fact]
        public void FromAmperes_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricCurrent.FromAmperes(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricCurrent.FromAmperes(double.NegativeInfinity));
        }

        [Fact]
        public void FromAmperes_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricCurrent.FromAmperes(double.NaN));
        }

        [Fact]
        public void As()
        {
            var ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(AmperesInOneAmpere, ampere.As(ElectricCurrentUnit.Ampere), AmperesTolerance);
            AssertEx.EqualTolerance(CentiamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Centiampere), CentiamperesTolerance);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Kiloampere), KiloamperesTolerance);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Megaampere), MegaamperesTolerance);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Microampere), MicroamperesTolerance);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Milliampere), MilliamperesTolerance);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Nanoampere), NanoamperesTolerance);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Picoampere), PicoamperesTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricCurrent(value: 1, unit: ElectricCurrent.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var ampere = ElectricCurrent.FromAmperes(1);

            var ampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Ampere);
            AssertEx.EqualTolerance(AmperesInOneAmpere, (double)ampereQuantity.Value, AmperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Ampere, ampereQuantity.Unit);

            var centiampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Centiampere);
            AssertEx.EqualTolerance(CentiamperesInOneAmpere, (double)centiampereQuantity.Value, CentiamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Centiampere, centiampereQuantity.Unit);

            var kiloampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Kiloampere);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, (double)kiloampereQuantity.Value, KiloamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Kiloampere, kiloampereQuantity.Unit);

            var megaampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Megaampere);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, (double)megaampereQuantity.Value, MegaamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Megaampere, megaampereQuantity.Unit);

            var microampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Microampere);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, (double)microampereQuantity.Value, MicroamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Microampere, microampereQuantity.Unit);

            var milliampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Milliampere);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, (double)milliampereQuantity.Value, MilliamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Milliampere, milliampereQuantity.Unit);

            var nanoampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Nanoampere);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, (double)nanoampereQuantity.Value, NanoamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Nanoampere, nanoampereQuantity.Unit);

            var picoampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Picoampere);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, (double)picoampereQuantity.Value, PicoamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Picoampere, picoampereQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = ElectricCurrent.FromAmperes(1).ToBaseUnit();
            Assert.Equal(ElectricCurrent.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromAmperes(ampere.Amperes).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromCentiamperes(ampere.Centiamperes).Amperes, CentiamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromKiloamperes(ampere.Kiloamperes).Amperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMegaamperes(ampere.Megaamperes).Amperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMicroamperes(ampere.Microamperes).Amperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMilliamperes(ampere.Milliamperes).Amperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromNanoamperes(ampere.Nanoamperes).Amperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromPicoamperes(ampere.Picoamperes).Amperes, PicoamperesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricCurrent v = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(-1, -v.Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrent.FromAmperes(3)-v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrent.FromAmperes(10)/5).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, ElectricCurrent.FromAmperes(10)/ElectricCurrent.FromAmperes(5), AmperesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricCurrent oneAmpere = ElectricCurrent.FromAmperes(1);
            ElectricCurrent twoAmperes = ElectricCurrent.FromAmperes(2);

            Assert.True(oneAmpere < twoAmperes);
            Assert.True(oneAmpere <= twoAmperes);
            Assert.True(twoAmperes > oneAmpere);
            Assert.True(twoAmperes >= oneAmpere);

            Assert.False(oneAmpere > twoAmperes);
            Assert.False(oneAmpere >= twoAmperes);
            Assert.False(twoAmperes < oneAmpere);
            Assert.False(twoAmperes <= oneAmpere);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Equal(0, ampere.CompareTo(ampere));
            Assert.True(ampere.CompareTo(ElectricCurrent.Zero) > 0);
            Assert.True(ElectricCurrent.Zero.CompareTo(ampere) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentException>(() => ampere.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentNullException>(() => ampere.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricCurrent.FromAmperes(1);
            var b = ElectricCurrent.FromAmperes(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = ElectricCurrent.FromAmperes(1);
            var b = ElectricCurrent.FromAmperes(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ElectricCurrent.FromAmperes(1);
            object b = ElectricCurrent.FromAmperes(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ElectricCurrent.FromAmperes(1);
            Assert.True(v.Equals(ElectricCurrent.FromAmperes(1), AmperesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricCurrent.Zero, AmperesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricCurrent.FromAmperes(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.False(ampere.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.False(ampere.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricCurrentUnit.Undefined, ElectricCurrent.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricCurrentUnit)).Cast<ElectricCurrentUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricCurrentUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricCurrent.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 A", new ElectricCurrent(1, ElectricCurrentUnit.Ampere).ToString());
                Assert.Equal("1 cA", new ElectricCurrent(1, ElectricCurrentUnit.Centiampere).ToString());
                Assert.Equal("1 kA", new ElectricCurrent(1, ElectricCurrentUnit.Kiloampere).ToString());
                Assert.Equal("1 MA", new ElectricCurrent(1, ElectricCurrentUnit.Megaampere).ToString());
                Assert.Equal("1 µA", new ElectricCurrent(1, ElectricCurrentUnit.Microampere).ToString());
                Assert.Equal("1 mA", new ElectricCurrent(1, ElectricCurrentUnit.Milliampere).ToString());
                Assert.Equal("1 nA", new ElectricCurrent(1, ElectricCurrentUnit.Nanoampere).ToString());
                Assert.Equal("1 pA", new ElectricCurrent(1, ElectricCurrentUnit.Picoampere).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 A", new ElectricCurrent(1, ElectricCurrentUnit.Ampere).ToString(swedishCulture));
            Assert.Equal("1 cA", new ElectricCurrent(1, ElectricCurrentUnit.Centiampere).ToString(swedishCulture));
            Assert.Equal("1 kA", new ElectricCurrent(1, ElectricCurrentUnit.Kiloampere).ToString(swedishCulture));
            Assert.Equal("1 MA", new ElectricCurrent(1, ElectricCurrentUnit.Megaampere).ToString(swedishCulture));
            Assert.Equal("1 µA", new ElectricCurrent(1, ElectricCurrentUnit.Microampere).ToString(swedishCulture));
            Assert.Equal("1 mA", new ElectricCurrent(1, ElectricCurrentUnit.Milliampere).ToString(swedishCulture));
            Assert.Equal("1 nA", new ElectricCurrent(1, ElectricCurrentUnit.Nanoampere).ToString(swedishCulture));
            Assert.Equal("1 pA", new ElectricCurrent(1, ElectricCurrentUnit.Picoampere).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s1"));
                Assert.Equal("0.12 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s2"));
                Assert.Equal("0.123 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s3"));
                Assert.Equal("0.1235 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s1", culture));
            Assert.Equal("0.12 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s2", culture));
            Assert.Equal("0.123 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s3", culture));
            Assert.Equal("0.1235 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricCurrent)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricCurrentUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(QuantityType.ElectricCurrent, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(ElectricCurrent.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(new {ElectricCurrent.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricCurrent.FromAmperes(value);
            Assert.Equal(ElectricCurrent.FromAmperes(-value), -quantity);
        }
    }
}
