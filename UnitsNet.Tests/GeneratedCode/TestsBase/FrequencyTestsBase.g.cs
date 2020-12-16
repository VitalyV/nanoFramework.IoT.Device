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
    /// Test of Frequency.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class FrequencyTestsBase : QuantityTestsBase
    {
        protected abstract double BeatsPerMinuteInOneHertz { get; }
        protected abstract double CyclesPerHourInOneHertz { get; }
        protected abstract double CyclesPerMinuteInOneHertz { get; }
        protected abstract double GigahertzInOneHertz { get; }
        protected abstract double HertzInOneHertz { get; }
        protected abstract double KilohertzInOneHertz { get; }
        protected abstract double MegahertzInOneHertz { get; }
        protected abstract double PerSecondInOneHertz { get; }
        protected abstract double RadiansPerSecondInOneHertz { get; }
        protected abstract double TerahertzInOneHertz { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BeatsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CyclesPerHourTolerance { get { return 1e-5; } }
        protected virtual double CyclesPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double GigahertzTolerance { get { return 1e-5; } }
        protected virtual double HertzTolerance { get { return 1e-5; } }
        protected virtual double KilohertzTolerance { get { return 1e-5; } }
        protected virtual double MegahertzTolerance { get { return 1e-5; } }
        protected virtual double PerSecondTolerance { get { return 1e-5; } }
        protected virtual double RadiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double TerahertzTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Frequency((double)0.0, FrequencyUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Frequency();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(FrequencyUnit.Hertz, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Frequency(double.PositiveInfinity, FrequencyUnit.Hertz));
            Assert.Throws<ArgumentException>(() => new Frequency(double.NegativeInfinity, FrequencyUnit.Hertz));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Frequency(double.NaN, FrequencyUnit.Hertz));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Frequency(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Frequency(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Frequency) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Frequency_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Frequency(1, FrequencyUnit.Hertz);

            QuantityInfo<FrequencyUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Frequency.Zero, quantityInfo.Zero);
            Assert.Equal("Frequency", quantityInfo.Name);
            Assert.Equal(QuantityType.Frequency, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<FrequencyUnit>().Except(new[] {FrequencyUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void HertzToFrequencyUnits()
        {
            Frequency hertz = Frequency.FromHertz(1);
            AssertEx.EqualTolerance(BeatsPerMinuteInOneHertz, hertz.BeatsPerMinute, BeatsPerMinuteTolerance);
            AssertEx.EqualTolerance(CyclesPerHourInOneHertz, hertz.CyclesPerHour, CyclesPerHourTolerance);
            AssertEx.EqualTolerance(CyclesPerMinuteInOneHertz, hertz.CyclesPerMinute, CyclesPerMinuteTolerance);
            AssertEx.EqualTolerance(GigahertzInOneHertz, hertz.Gigahertz, GigahertzTolerance);
            AssertEx.EqualTolerance(HertzInOneHertz, hertz.Hertz, HertzTolerance);
            AssertEx.EqualTolerance(KilohertzInOneHertz, hertz.Kilohertz, KilohertzTolerance);
            AssertEx.EqualTolerance(MegahertzInOneHertz, hertz.Megahertz, MegahertzTolerance);
            AssertEx.EqualTolerance(PerSecondInOneHertz, hertz.PerSecond, PerSecondTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneHertz, hertz.RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(TerahertzInOneHertz, hertz.Terahertz, TerahertzTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Frequency.From(1, FrequencyUnit.BeatPerMinute);
            AssertEx.EqualTolerance(1, quantity00.BeatsPerMinute, BeatsPerMinuteTolerance);
            Assert.Equal(FrequencyUnit.BeatPerMinute, quantity00.Unit);

            var quantity01 = Frequency.From(1, FrequencyUnit.CyclePerHour);
            AssertEx.EqualTolerance(1, quantity01.CyclesPerHour, CyclesPerHourTolerance);
            Assert.Equal(FrequencyUnit.CyclePerHour, quantity01.Unit);

            var quantity02 = Frequency.From(1, FrequencyUnit.CyclePerMinute);
            AssertEx.EqualTolerance(1, quantity02.CyclesPerMinute, CyclesPerMinuteTolerance);
            Assert.Equal(FrequencyUnit.CyclePerMinute, quantity02.Unit);

            var quantity03 = Frequency.From(1, FrequencyUnit.Gigahertz);
            AssertEx.EqualTolerance(1, quantity03.Gigahertz, GigahertzTolerance);
            Assert.Equal(FrequencyUnit.Gigahertz, quantity03.Unit);

            var quantity04 = Frequency.From(1, FrequencyUnit.Hertz);
            AssertEx.EqualTolerance(1, quantity04.Hertz, HertzTolerance);
            Assert.Equal(FrequencyUnit.Hertz, quantity04.Unit);

            var quantity05 = Frequency.From(1, FrequencyUnit.Kilohertz);
            AssertEx.EqualTolerance(1, quantity05.Kilohertz, KilohertzTolerance);
            Assert.Equal(FrequencyUnit.Kilohertz, quantity05.Unit);

            var quantity06 = Frequency.From(1, FrequencyUnit.Megahertz);
            AssertEx.EqualTolerance(1, quantity06.Megahertz, MegahertzTolerance);
            Assert.Equal(FrequencyUnit.Megahertz, quantity06.Unit);

            var quantity07 = Frequency.From(1, FrequencyUnit.PerSecond);
            AssertEx.EqualTolerance(1, quantity07.PerSecond, PerSecondTolerance);
            Assert.Equal(FrequencyUnit.PerSecond, quantity07.Unit);

            var quantity08 = Frequency.From(1, FrequencyUnit.RadianPerSecond);
            AssertEx.EqualTolerance(1, quantity08.RadiansPerSecond, RadiansPerSecondTolerance);
            Assert.Equal(FrequencyUnit.RadianPerSecond, quantity08.Unit);

            var quantity09 = Frequency.From(1, FrequencyUnit.Terahertz);
            AssertEx.EqualTolerance(1, quantity09.Terahertz, TerahertzTolerance);
            Assert.Equal(FrequencyUnit.Terahertz, quantity09.Unit);

        }

        [Fact]
        public void FromHertz_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Frequency.FromHertz(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Frequency.FromHertz(double.NegativeInfinity));
        }

        [Fact]
        public void FromHertz_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Frequency.FromHertz(double.NaN));
        }

        [Fact]
        public void As()
        {
            var hertz = Frequency.FromHertz(1);
            AssertEx.EqualTolerance(BeatsPerMinuteInOneHertz, hertz.As(FrequencyUnit.BeatPerMinute), BeatsPerMinuteTolerance);
            AssertEx.EqualTolerance(CyclesPerHourInOneHertz, hertz.As(FrequencyUnit.CyclePerHour), CyclesPerHourTolerance);
            AssertEx.EqualTolerance(CyclesPerMinuteInOneHertz, hertz.As(FrequencyUnit.CyclePerMinute), CyclesPerMinuteTolerance);
            AssertEx.EqualTolerance(GigahertzInOneHertz, hertz.As(FrequencyUnit.Gigahertz), GigahertzTolerance);
            AssertEx.EqualTolerance(HertzInOneHertz, hertz.As(FrequencyUnit.Hertz), HertzTolerance);
            AssertEx.EqualTolerance(KilohertzInOneHertz, hertz.As(FrequencyUnit.Kilohertz), KilohertzTolerance);
            AssertEx.EqualTolerance(MegahertzInOneHertz, hertz.As(FrequencyUnit.Megahertz), MegahertzTolerance);
            AssertEx.EqualTolerance(PerSecondInOneHertz, hertz.As(FrequencyUnit.PerSecond), PerSecondTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneHertz, hertz.As(FrequencyUnit.RadianPerSecond), RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(TerahertzInOneHertz, hertz.As(FrequencyUnit.Terahertz), TerahertzTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Frequency(value: 1, unit: Frequency.BaseUnit);
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
            var hertz = Frequency.FromHertz(1);

            var beatperminuteQuantity = hertz.ToUnit(FrequencyUnit.BeatPerMinute);
            AssertEx.EqualTolerance(BeatsPerMinuteInOneHertz, (double)beatperminuteQuantity.Value, BeatsPerMinuteTolerance);
            Assert.Equal(FrequencyUnit.BeatPerMinute, beatperminuteQuantity.Unit);

            var cycleperhourQuantity = hertz.ToUnit(FrequencyUnit.CyclePerHour);
            AssertEx.EqualTolerance(CyclesPerHourInOneHertz, (double)cycleperhourQuantity.Value, CyclesPerHourTolerance);
            Assert.Equal(FrequencyUnit.CyclePerHour, cycleperhourQuantity.Unit);

            var cycleperminuteQuantity = hertz.ToUnit(FrequencyUnit.CyclePerMinute);
            AssertEx.EqualTolerance(CyclesPerMinuteInOneHertz, (double)cycleperminuteQuantity.Value, CyclesPerMinuteTolerance);
            Assert.Equal(FrequencyUnit.CyclePerMinute, cycleperminuteQuantity.Unit);

            var gigahertzQuantity = hertz.ToUnit(FrequencyUnit.Gigahertz);
            AssertEx.EqualTolerance(GigahertzInOneHertz, (double)gigahertzQuantity.Value, GigahertzTolerance);
            Assert.Equal(FrequencyUnit.Gigahertz, gigahertzQuantity.Unit);

            var hertzQuantity = hertz.ToUnit(FrequencyUnit.Hertz);
            AssertEx.EqualTolerance(HertzInOneHertz, (double)hertzQuantity.Value, HertzTolerance);
            Assert.Equal(FrequencyUnit.Hertz, hertzQuantity.Unit);

            var kilohertzQuantity = hertz.ToUnit(FrequencyUnit.Kilohertz);
            AssertEx.EqualTolerance(KilohertzInOneHertz, (double)kilohertzQuantity.Value, KilohertzTolerance);
            Assert.Equal(FrequencyUnit.Kilohertz, kilohertzQuantity.Unit);

            var megahertzQuantity = hertz.ToUnit(FrequencyUnit.Megahertz);
            AssertEx.EqualTolerance(MegahertzInOneHertz, (double)megahertzQuantity.Value, MegahertzTolerance);
            Assert.Equal(FrequencyUnit.Megahertz, megahertzQuantity.Unit);

            var persecondQuantity = hertz.ToUnit(FrequencyUnit.PerSecond);
            AssertEx.EqualTolerance(PerSecondInOneHertz, (double)persecondQuantity.Value, PerSecondTolerance);
            Assert.Equal(FrequencyUnit.PerSecond, persecondQuantity.Unit);

            var radianpersecondQuantity = hertz.ToUnit(FrequencyUnit.RadianPerSecond);
            AssertEx.EqualTolerance(RadiansPerSecondInOneHertz, (double)radianpersecondQuantity.Value, RadiansPerSecondTolerance);
            Assert.Equal(FrequencyUnit.RadianPerSecond, radianpersecondQuantity.Unit);

            var terahertzQuantity = hertz.ToUnit(FrequencyUnit.Terahertz);
            AssertEx.EqualTolerance(TerahertzInOneHertz, (double)terahertzQuantity.Value, TerahertzTolerance);
            Assert.Equal(FrequencyUnit.Terahertz, terahertzQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = Frequency.FromHertz(1).ToBaseUnit();
            Assert.Equal(Frequency.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Frequency hertz = Frequency.FromHertz(1);
            AssertEx.EqualTolerance(1, Frequency.FromBeatsPerMinute(hertz.BeatsPerMinute).Hertz, BeatsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromCyclesPerHour(hertz.CyclesPerHour).Hertz, CyclesPerHourTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromCyclesPerMinute(hertz.CyclesPerMinute).Hertz, CyclesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromGigahertz(hertz.Gigahertz).Hertz, GigahertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromHertz(hertz.Hertz).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromKilohertz(hertz.Kilohertz).Hertz, KilohertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromMegahertz(hertz.Megahertz).Hertz, MegahertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromPerSecond(hertz.PerSecond).Hertz, PerSecondTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromRadiansPerSecond(hertz.RadiansPerSecond).Hertz, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromTerahertz(hertz.Terahertz).Hertz, TerahertzTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Frequency v = Frequency.FromHertz(1);
            AssertEx.EqualTolerance(-1, -v.Hertz, HertzTolerance);
            AssertEx.EqualTolerance(2, (Frequency.FromHertz(3)-v).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(2, (v + v).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(10, (v*10).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(10, (10*v).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(2, (Frequency.FromHertz(10)/5).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(2, Frequency.FromHertz(10)/Frequency.FromHertz(5), HertzTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Frequency oneHertz = Frequency.FromHertz(1);
            Frequency twoHertz = Frequency.FromHertz(2);

            Assert.True(oneHertz < twoHertz);
            Assert.True(oneHertz <= twoHertz);
            Assert.True(twoHertz > oneHertz);
            Assert.True(twoHertz >= oneHertz);

            Assert.False(oneHertz > twoHertz);
            Assert.False(oneHertz >= twoHertz);
            Assert.False(twoHertz < oneHertz);
            Assert.False(twoHertz <= oneHertz);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.Equal(0, hertz.CompareTo(hertz));
            Assert.True(hertz.CompareTo(Frequency.Zero) > 0);
            Assert.True(Frequency.Zero.CompareTo(hertz) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.Throws<ArgumentException>(() => hertz.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.Throws<ArgumentNullException>(() => hertz.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Frequency.FromHertz(1);
            var b = Frequency.FromHertz(2);

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
            var a = Frequency.FromHertz(1);
            var b = Frequency.FromHertz(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Frequency.FromHertz(1);
            object b = Frequency.FromHertz(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Frequency.FromHertz(1);
            Assert.True(v.Equals(Frequency.FromHertz(1), HertzTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Frequency.Zero, HertzTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Frequency.FromHertz(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Frequency.FromHertz(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.False(hertz.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.False(hertz.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(FrequencyUnit.Undefined, Frequency.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(FrequencyUnit)).Cast<FrequencyUnit>();
            foreach(var unit in units)
            {
                if(unit == FrequencyUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Frequency.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 bpm", new Frequency(1, FrequencyUnit.BeatPerMinute).ToString());
                Assert.Equal("1 cph", new Frequency(1, FrequencyUnit.CyclePerHour).ToString());
                Assert.Equal("1 cpm", new Frequency(1, FrequencyUnit.CyclePerMinute).ToString());
                Assert.Equal("1 GHz", new Frequency(1, FrequencyUnit.Gigahertz).ToString());
                Assert.Equal("1 Hz", new Frequency(1, FrequencyUnit.Hertz).ToString());
                Assert.Equal("1 kHz", new Frequency(1, FrequencyUnit.Kilohertz).ToString());
                Assert.Equal("1 MHz", new Frequency(1, FrequencyUnit.Megahertz).ToString());
                Assert.Equal("1 s⁻¹", new Frequency(1, FrequencyUnit.PerSecond).ToString());
                Assert.Equal("1 rad/s", new Frequency(1, FrequencyUnit.RadianPerSecond).ToString());
                Assert.Equal("1 THz", new Frequency(1, FrequencyUnit.Terahertz).ToString());
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

            Assert.Equal("1 bpm", new Frequency(1, FrequencyUnit.BeatPerMinute).ToString(swedishCulture));
            Assert.Equal("1 cph", new Frequency(1, FrequencyUnit.CyclePerHour).ToString(swedishCulture));
            Assert.Equal("1 cpm", new Frequency(1, FrequencyUnit.CyclePerMinute).ToString(swedishCulture));
            Assert.Equal("1 GHz", new Frequency(1, FrequencyUnit.Gigahertz).ToString(swedishCulture));
            Assert.Equal("1 Hz", new Frequency(1, FrequencyUnit.Hertz).ToString(swedishCulture));
            Assert.Equal("1 kHz", new Frequency(1, FrequencyUnit.Kilohertz).ToString(swedishCulture));
            Assert.Equal("1 MHz", new Frequency(1, FrequencyUnit.Megahertz).ToString(swedishCulture));
            Assert.Equal("1 s⁻¹", new Frequency(1, FrequencyUnit.PerSecond).ToString(swedishCulture));
            Assert.Equal("1 rad/s", new Frequency(1, FrequencyUnit.RadianPerSecond).ToString(swedishCulture));
            Assert.Equal("1 THz", new Frequency(1, FrequencyUnit.Terahertz).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Hz", new Frequency(0.123456, FrequencyUnit.Hertz).ToString("s1"));
                Assert.Equal("0.12 Hz", new Frequency(0.123456, FrequencyUnit.Hertz).ToString("s2"));
                Assert.Equal("0.123 Hz", new Frequency(0.123456, FrequencyUnit.Hertz).ToString("s3"));
                Assert.Equal("0.1235 Hz", new Frequency(0.123456, FrequencyUnit.Hertz).ToString("s4"));
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
            Assert.Equal("0.1 Hz", new Frequency(0.123456, FrequencyUnit.Hertz).ToString("s1", culture));
            Assert.Equal("0.12 Hz", new Frequency(0.123456, FrequencyUnit.Hertz).ToString("s2", culture));
            Assert.Equal("0.123 Hz", new Frequency(0.123456, FrequencyUnit.Hertz).ToString("s3", culture));
            Assert.Equal("0.1235 Hz", new Frequency(0.123456, FrequencyUnit.Hertz).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Frequency)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(FrequencyUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal(QuantityType.Frequency, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal(Frequency.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Frequency.FromHertz(1.0);
            Assert.Equal(new {Frequency.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Frequency.FromHertz(value);
            Assert.Equal(Frequency.FromHertz(-value), -quantity);
        }
    }
}
