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

using UnitsNet.NumberExtensions.NumberToSpecificWeight;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToSpecificWeightExtensionsTests
    {
        [Fact]
        public void NumberToKilogramsForcePerCubicCentimeterTest() =>
            Assert.Equal(SpecificWeight.FromKilogramsForcePerCubicCentimeter(2), 2.KilogramsForcePerCubicCentimeter());

        [Fact]
        public void NumberToKilogramsForcePerCubicMeterTest() =>
            Assert.Equal(SpecificWeight.FromKilogramsForcePerCubicMeter(2), 2.KilogramsForcePerCubicMeter());

        [Fact]
        public void NumberToKilogramsForcePerCubicMillimeterTest() =>
            Assert.Equal(SpecificWeight.FromKilogramsForcePerCubicMillimeter(2), 2.KilogramsForcePerCubicMillimeter());

        [Fact]
        public void NumberToKilonewtonsPerCubicCentimeterTest() =>
            Assert.Equal(SpecificWeight.FromKilonewtonsPerCubicCentimeter(2), 2.KilonewtonsPerCubicCentimeter());

        [Fact]
        public void NumberToKilonewtonsPerCubicMeterTest() =>
            Assert.Equal(SpecificWeight.FromKilonewtonsPerCubicMeter(2), 2.KilonewtonsPerCubicMeter());

        [Fact]
        public void NumberToKilonewtonsPerCubicMillimeterTest() =>
            Assert.Equal(SpecificWeight.FromKilonewtonsPerCubicMillimeter(2), 2.KilonewtonsPerCubicMillimeter());

        [Fact]
        public void NumberToKilopoundsForcePerCubicFootTest() =>
            Assert.Equal(SpecificWeight.FromKilopoundsForcePerCubicFoot(2), 2.KilopoundsForcePerCubicFoot());

        [Fact]
        public void NumberToKilopoundsForcePerCubicInchTest() =>
            Assert.Equal(SpecificWeight.FromKilopoundsForcePerCubicInch(2), 2.KilopoundsForcePerCubicInch());

        [Fact]
        public void NumberToMeganewtonsPerCubicMeterTest() =>
            Assert.Equal(SpecificWeight.FromMeganewtonsPerCubicMeter(2), 2.MeganewtonsPerCubicMeter());

        [Fact]
        public void NumberToNewtonsPerCubicCentimeterTest() =>
            Assert.Equal(SpecificWeight.FromNewtonsPerCubicCentimeter(2), 2.NewtonsPerCubicCentimeter());

        [Fact]
        public void NumberToNewtonsPerCubicMeterTest() =>
            Assert.Equal(SpecificWeight.FromNewtonsPerCubicMeter(2), 2.NewtonsPerCubicMeter());

        [Fact]
        public void NumberToNewtonsPerCubicMillimeterTest() =>
            Assert.Equal(SpecificWeight.FromNewtonsPerCubicMillimeter(2), 2.NewtonsPerCubicMillimeter());

        [Fact]
        public void NumberToPoundsForcePerCubicFootTest() =>
            Assert.Equal(SpecificWeight.FromPoundsForcePerCubicFoot(2), 2.PoundsForcePerCubicFoot());

        [Fact]
        public void NumberToPoundsForcePerCubicInchTest() =>
            Assert.Equal(SpecificWeight.FromPoundsForcePerCubicInch(2), 2.PoundsForcePerCubicInch());

        [Fact]
        public void NumberToTonnesForcePerCubicCentimeterTest() =>
            Assert.Equal(SpecificWeight.FromTonnesForcePerCubicCentimeter(2), 2.TonnesForcePerCubicCentimeter());

        [Fact]
        public void NumberToTonnesForcePerCubicMeterTest() =>
            Assert.Equal(SpecificWeight.FromTonnesForcePerCubicMeter(2), 2.TonnesForcePerCubicMeter());

        [Fact]
        public void NumberToTonnesForcePerCubicMillimeterTest() =>
            Assert.Equal(SpecificWeight.FromTonnesForcePerCubicMillimeter(2), 2.TonnesForcePerCubicMillimeter());

    }
}