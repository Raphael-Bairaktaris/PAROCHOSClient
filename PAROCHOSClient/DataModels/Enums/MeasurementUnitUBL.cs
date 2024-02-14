namespace PAROCHOSClient
{
    /// <summary>
    /// Provides enumeration over the UBL measurement units
    /// </summary>
    public enum UBLMeasurementUnit
    {
        /// <summary>
        /// Group (Code: 10)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of groups (group: set of items classified together).
        /// </remarks>
        Group,

        /// <summary>
        /// Outfit (Code: 11)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of outfits (outfit: a complete set of equipment / materials / objects used for a specific purpose).
        /// </remarks>
        Outfit,

        /// <summary>
        /// Ration (Code: 13)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of rations (ration: a single portion of provisions).
        /// </remarks>
        Ration,

        /// <summary>
        /// Shot (Code: 14)
        /// </summary>
        /// <remarks>
        /// A unit of liquid measure, especially related to spirits.
        /// </remarks>
        Shot,

        /// <summary>
        /// Stick, military (Code: 15)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of military sticks (military stick: bombs or paratroops released in rapid succession from an aircraft).
        /// </remarks>
        Stick_Military,

        /// <summary>
        /// Twenty foot container (Code: 20)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of shipping containers that measure 20 foot in length.
        /// </remarks>
        TwentyFootContainer,

        /// <summary>
        /// Forty foot container (Code: 21)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of shipping containers that measure 40 foot in length.
        /// </remarks>
        FortyFootContainer,

        /// <summary>
        /// Decilitre per gram (Code: 22)
        /// </summary>
        DecilitrePerGram,

        /// <summary>
        /// Gram per cubic centimetre (Code: 23)
        /// </summary>
        GramPerCubicCentimetre,

        /// <summary>
        /// Theoretical pound (Code: 24)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the expected mass of material expressed as the number of pounds.
        /// </remarks>
        TheoreticalPound,

        /// <summary>
        /// Gram per square centimetre (Code: 25)
        /// </summary>
        GramPerSquareCentimetre,

        /// <summary>
        /// Theoretical ton (Code: 27)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the expected mass of material, expressed as the number of tons.
        /// </remarks>
        TheoreticalTon,

        /// <summary>
        /// Kilogram per square metre (Code: 28)
        /// </summary>
        KilogramPerSquareMetre,

        /// <summary>
        /// Kilopascal square metre per gram (Code: 33)
        /// </summary>
        KilopascalSquareMetrePerGram,

        /// <summary>
        /// Kilopascal per millimetre (Code: 34)
        /// </summary>
        KilopascalPerMillimetre,

        /// <summary>
        /// Millilitre per square centimetre second (Code: 35)
        /// </summary>
        MillilitrePerSquareCentimetreSecond,

        /// <summary>
        /// Ounce per square foot (Code: 37)
        /// </summary>
        OuncePerSquareFoot,

        /// <summary>
        /// Ounce per square foot per 0,01inch (Code: 38)
        /// </summary>
        OuncePerSquareFootPer0_01inch,

        /// <summary>
        /// Millilitre per second (Code: 40)
        /// </summary>
        MillilitrePerSecond,

        /// <summary>
        /// Millilitre per minute (Code: 41)
        /// </summary>
        MillilitrePerMinute,

        /// <summary>
        /// Sitas (Code: 56)
        /// </summary>
        /// <remarks>
        /// A unit of area for tin plate equal to a surface area of 100 square metres.
        /// </remarks>
        Sitas,

        /// <summary>
        /// Mesh (Code: 57)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of strands per inch as a measure of the fineness of a woven product.
        /// </remarks>
        Mesh,

        /// <summary>
        /// Net kilogram (Code: 58)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the total number of kilograms after deductions.
        /// </remarks>
        NetKilogram,

        /// <summary>
        /// Part per million (Code: 59)
        /// </summary>
        /// <remarks>
        /// A unit of proportion equal to 10⁻⁶.
        /// </remarks>
        PartPerMillion,

        /// <summary>
        /// Percent weight (Code: 60)
        /// </summary>
        /// <remarks>
        /// A unit of proportion equal to 10⁻².
        /// </remarks>
        PercentWeight,

        /// <summary>
        /// Part per billion (US) (Code: 61)
        /// </summary>
        /// <remarks>
        /// A unit of proportion equal to 10⁻⁹.
        /// </remarks>
        PartPerBillion_US,

        /// <summary>
        /// Millipascal (Code: 74)
        /// </summary>
        Millipascal,

        /// <summary>
        /// Milli-inch (Code: 77)
        /// </summary>
        MilliInch,

        /// <summary>
        /// Pound per square inch absolute (Code: 80)
        /// </summary>
        PoundPerSquareInchAbsolute,

        /// <summary>
        /// Henry (Code: 81)
        /// </summary>
        Henry,

        /// <summary>
        /// Foot pound-force (Code: 85)
        /// </summary>
        FootPoundForce,

        /// <summary>
        /// Pound per cubic foot (Code: 87)
        /// </summary>
        PoundPerCubicFoot,

        /// <summary>
        /// Poise (Code: 89)
        /// </summary>
        Poise,

        /// <summary>
        /// Stokes (Code: 91)
        /// </summary>
        Stokes,

        /// <summary>
        /// Fixed rate (Code: 1I)
        /// </summary>
        /// <remarks>
        /// A unit of quantity expressed as a predetermined or set rate for usage of a facility or service.
        /// </remarks>
        FixedRate,

        /// <summary>
        /// Radian per second (Code: 2A)
        /// </summary>
        /// <remarks>
        /// Refer ISO/TC12 SI Guide
        /// </remarks>
        RadianPerSecond,

        /// <summary>
        /// Radian per second squared (Code: 2B)
        /// </summary>
        /// <remarks>
        /// Refer ISO/TC12 SI Guide
        /// </remarks>
        RadianPerSecondSquared,

        /// <summary>
        /// Roentgen (Code: 2C)
        /// </summary>
        Roentgen,

        /// <summary>
        /// Volt AC (Code: 2G)
        /// </summary>
        /// <remarks>
        /// A unit of electric potential in relation to alternating current (AC).
        /// </remarks>
        VoltAC,

        /// <summary>
        /// Volt DC (Code: 2H)
        /// </summary>
        /// <remarks>
        /// A unit of electric potential in relation to direct current (DC).
        /// </remarks>
        VoltDC,

        /// <summary>
        /// British thermal unit (international table) per hour (Code: 2I)
        /// </summary>
        BritishThermalUnit_internationalTable_PerHour,

        /// <summary>
        /// Cubic centimetre per second (Code: 2J)
        /// </summary>
        CubicCentimetrePerSecond,

        /// <summary>
        /// Cubic foot per hour (Code: 2K)
        /// </summary>
        CubicFootPerHour,

        /// <summary>
        /// Cubic foot per minute (Code: 2L)
        /// </summary>
        CubicFootPerMinute,

        /// <summary>
        /// Centimetre per second (Code: 2M)
        /// </summary>
        CentimetrePerSecond,

        /// <summary>
        /// Decibel (Code: 2N)
        /// </summary>
        Decibel,

        /// <summary>
        /// Kilobyte (Code: 2P)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10³ (1000) bytes.
        /// </remarks>
        Kilobyte,

        /// <summary>
        /// Kilobecquerel (Code: 2Q)
        /// </summary>
        Kilobecquerel,

        /// <summary>
        /// Kilocurie (Code: 2R)
        /// </summary>
        Kilocurie,

        /// <summary>
        /// Megagram (Code: 2U)
        /// </summary>
        Megagram,

        /// <summary>
        /// Metre per minute (Code: 2X)
        /// </summary>
        MetrePerMinute,

        /// <summary>
        /// Milliroentgen (Code: 2Y)
        /// </summary>
        Milliroentgen,

        /// <summary>
        /// Millivolt (Code: 2Z)
        /// </summary>
        Millivolt,

        /// <summary>
        /// Megajoule (Code: 3B)
        /// </summary>
        Megajoule,

        /// <summary>
        /// Manmonth (Code: 3C)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of months for a person or persons to perform an undertaking.
        /// </remarks>
        Manmonth,

        /// <summary>
        /// Centistokes (Code: 4C)
        /// </summary>
        Centistokes,

        /// <summary>
        /// Microlitre (Code: 4G)
        /// </summary>
        Microlitre,

        /// <summary>
        /// Micrometre (micron) (Code: 4H)
        /// </summary>
        Micrometre_micron,

        /// <summary>
        /// Milliampere (Code: 4K)
        /// </summary>
        Milliampere,

        /// <summary>
        /// Megabyte (Code: 4L)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10⁶ (1000000) bytes.
        /// </remarks>
        Megabyte,

        /// <summary>
        /// Milligram per hour (Code: 4M)
        /// </summary>
        MilligramPerHour,

        /// <summary>
        /// Megabecquerel (Code: 4N)
        /// </summary>
        Megabecquerel,

        /// <summary>
        /// Microfarad (Code: 4O)
        /// </summary>
        Microfarad,

        /// <summary>
        /// Newton per metre (Code: 4P)
        /// </summary>
        NewtonPerMetre,

        /// <summary>
        /// Ounce inch (Code: 4Q)
        /// </summary>
        OunceInch,

        /// <summary>
        /// Ounce foot (Code: 4R)
        /// </summary>
        OunceFoot,

        /// <summary>
        /// Picofarad (Code: 4T)
        /// </summary>
        Picofarad,

        /// <summary>
        /// Pound per hour (Code: 4U)
        /// </summary>
        PoundPerHour,

        /// <summary>
        /// Ton (US) per hour (Code: 4W)
        /// </summary>
        Ton_US_PerHour,

        /// <summary>
        /// Kilolitre per hour (Code: 4X)
        /// </summary>
        KilolitrePerHour,

        /// <summary>
        /// Barrel (US) per minute (Code: 5A)
        /// </summary>
        Barrel_US_PerMinute,

        /// <summary>
        /// Batch (Code: 5B)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of batches (batch: quantity of material produced in one operation or number of animals or persons coming at once).
        /// </remarks>
        Batch,

        /// <summary>
        /// MMSCF/day (Code: 5E)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one million (1000000) cubic feet of gas per day.
        /// </remarks>
        MMSCFPerDay,

        /// <summary>
        /// Hydraulic horse power (Code: 5J)
        /// </summary>
        /// <remarks>
        /// A unit of power defining the hydraulic horse power delivered by a fluid pump depending on the viscosity of the fluid.
        /// </remarks>
        HydraulicHorsePower,

        /// <summary>
        /// Ampere square metre per joule second (Code: A10)
        /// </summary>
        AmpereSquareMetrePerJouleSecond,

        /// <summary>
        /// Angstrom (Code: A11)
        /// </summary>
        Angstrom,

        /// <summary>
        /// Astronomical unit (Code: A12)
        /// </summary>
        AstronomicalUnit,

        /// <summary>
        /// Attojoule (Code: A13)
        /// </summary>
        Attojoule,

        /// <summary>
        /// Barn (Code: A14)
        /// </summary>
        Barn,

        /// <summary>
        /// Barn per electronvolt (Code: A15)
        /// </summary>
        BarnPerElectronvolt,

        /// <summary>
        /// Barn per steradian electronvolt (Code: A16)
        /// </summary>
        BarnPerSteradianElectronvolt,

        /// <summary>
        /// Barn per steradian (Code: A17)
        /// </summary>
        BarnPerSteradian,

        /// <summary>
        /// Becquerel per kilogram (Code: A18)
        /// </summary>
        BecquerelPerKilogram,

        /// <summary>
        /// Becquerel per cubic metre (Code: A19)
        /// </summary>
        BecquerelPerCubicMetre,

        /// <summary>
        /// Ampere per centimetre (Code: A2)
        /// </summary>
        AmperePerCentimetre,

        /// <summary>
        /// British thermal unit (international table) per second square foot degree Rankine (Code: A20)
        /// </summary>
        BritishThermalUnit_internationalTable_PerSecondSquareFootDegreeRankine,

        /// <summary>
        /// British thermal unit (international table) per pound degree Rankine (Code: A21)
        /// </summary>
        BritishThermalUnit_internationalTable_PerPoundDegreeRankine,

        /// <summary>
        /// British thermal unit (international table) per second foot degree Rankine (Code: A22)
        /// </summary>
        BritishThermalUnit_internationalTable_PerSecondFootDegreeRankine,

        /// <summary>
        /// British thermal unit (international table) per hour square foot degree Rankine (Code: A23)
        /// </summary>
        BritishThermalUnit_internationalTable_PerHourSquareFootDegreeRankine,

        /// <summary>
        /// Candela per square metre (Code: A24)
        /// </summary>
        CandelaPerSquareMetre,

        /// <summary>
        /// Coulomb metre (Code: A26)
        /// </summary>
        CoulombMetre,

        /// <summary>
        /// Coulomb metre squared per volt (Code: A27)
        /// </summary>
        CoulombMetreSquaredPerVolt,

        /// <summary>
        /// Coulomb per cubic centimetre (Code: A28)
        /// </summary>
        CoulombPerCubicCentimetre,

        /// <summary>
        /// Coulomb per cubic metre (Code: A29)
        /// </summary>
        CoulombPerCubicMetre,

        /// <summary>
        /// Ampere per millimetre (Code: A3)
        /// </summary>
        AmperePerMillimetre,

        /// <summary>
        /// Coulomb per cubic millimetre (Code: A30)
        /// </summary>
        CoulombPerCubicMillimetre,

        /// <summary>
        /// Coulomb per kilogram second (Code: A31)
        /// </summary>
        CoulombPerKilogramSecond,

        /// <summary>
        /// Coulomb per mole (Code: A32)
        /// </summary>
        CoulombPerMole,

        /// <summary>
        /// Coulomb per square centimetre (Code: A33)
        /// </summary>
        CoulombPerSquareCentimetre,

        /// <summary>
        /// Coulomb per square metre (Code: A34)
        /// </summary>
        CoulombPerSquareMetre,

        /// <summary>
        /// Coulomb per square millimetre (Code: A35)
        /// </summary>
        CoulombPerSquareMillimetre,

        /// <summary>
        /// Cubic centimetre per mole (Code: A36)
        /// </summary>
        CubicCentimetrePerMole,

        /// <summary>
        /// Cubic decimetre per mole (Code: A37)
        /// </summary>
        CubicDecimetrePerMole,

        /// <summary>
        /// Cubic metre per coulomb (Code: A38)
        /// </summary>
        CubicMetrePerCoulomb,

        /// <summary>
        /// Cubic metre per kilogram (Code: A39)
        /// </summary>
        CubicMetrePerKilogram,

        /// <summary>
        /// Ampere per square centimetre (Code: A4)
        /// </summary>
        AmperePerSquareCentimetre,

        /// <summary>
        /// Cubic metre per mole (Code: A40)
        /// </summary>
        CubicMetrePerMole,

        /// <summary>
        /// Ampere per square metre (Code: A41)
        /// </summary>
        AmperePerSquareMetre,

        /// <summary>
        /// Curie per kilogram (Code: A42)
        /// </summary>
        CuriePerKilogram,

        /// <summary>
        /// Deadweight tonnage (Code: A43)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the difference between the weight of a ship when completely empty and its weight when completely loaded, expressed as the number of tons.
        /// </remarks>
        DeadweightTonnage,

        /// <summary>
        /// Decalitre (Code: A44)
        /// </summary>
        Decalitre,

        /// <summary>
        /// Decametre (Code: A45)
        /// </summary>
        Decametre,

        /// <summary>
        /// Decitex (Code: A47)
        /// </summary>
        /// <remarks>
        /// A unit of yarn density. One decitex equals a mass of 1 gram per 10 kilometres of length.
        /// </remarks>
        Decitex,

        /// <summary>
        /// Degree Rankine (Code: A48)
        /// </summary>
        /// <remarks>
        /// Refer ISO 80000-5 (Quantities and units — Part 5: Thermodynamics)
        /// </remarks>
        DegreeRankine,

        /// <summary>
        /// Denier (Code: A49)
        /// </summary>
        /// <remarks>
        /// A unit of yarn density. One denier equals a mass of 1 gram per 9 kilometres of length.
        /// </remarks>
        Denier_UnitOfYarnDensity,

        /// <summary>
        /// Ampere square metre (Code: A5)
        /// </summary>
        AmpereSquareMetre,

        /// <summary>
        /// Electronvolt (Code: A53)
        /// </summary>
        Electronvolt,

        /// <summary>
        /// Electronvolt per metre (Code: A54)
        /// </summary>
        ElectronvoltPerMetre,

        /// <summary>
        /// Electronvolt square metre (Code: A55)
        /// </summary>
        ElectronvoltSquareMetre,

        /// <summary>
        /// Electronvolt square metre per kilogram (Code: A56)
        /// </summary>
        ElectronvoltSquareMetrePerKilogram,

        /// <summary>
        /// 8-part cloud cover (Code: A59)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of eighth-parts as a measure of the celestial dome cloud coverage. Synonym: OKTA , OCTA
        /// </remarks>
        EightPartCloudCover,

        /// <summary>
        /// Ampere per square metre kelvin squared (Code: A6)
        /// </summary>
        AmperePerSquareMetreKelvinSquared,

        /// <summary>
        /// Exajoule (Code: A68)
        /// </summary>
        Exajoule,

        /// <summary>
        /// Farad per metre (Code: A69)
        /// </summary>
        FaradPerMetre,

        /// <summary>
        /// Ampere per square millimetre (Code: A7)
        /// </summary>
        AmperePerSquareMillimetre,

        /// <summary>
        /// Femtojoule (Code: A70)
        /// </summary>
        Femtojoule,

        /// <summary>
        /// Femtometre (Code: A71)
        /// </summary>
        Femtometre,

        /// <summary>
        /// Foot per second squared (Code: A73)
        /// </summary>
        FootPerSecondSquared,

        /// <summary>
        /// Foot pound-force per second (Code: A74)
        /// </summary>
        FootPoundForcePerSecond,

        /// <summary>
        /// Freight ton (Code: A75)
        /// </summary>
        /// <remarks>
        /// A unit of information typically used for billing purposes, defined as either the number of metric tons or the number of cubic metres, whichever is the larger.
        /// </remarks>
        FreightTon,

        /// <summary>
        /// Gal (Code: A76)
        /// </summary>
        Gal,

        /// <summary>
        /// Ampere second (Code: A8)
        /// </summary>
        AmpereSecond,

        /// <summary>
        /// Gigacoulomb per cubic metre (Code: A84)
        /// </summary>
        GigacoulombPerCubicMetre,

        /// <summary>
        /// Gigaelectronvolt (Code: A85)
        /// </summary>
        Gigaelectronvolt,

        /// <summary>
        /// Gigahertz (Code: A86)
        /// </summary>
        Gigahertz,

        /// <summary>
        /// Gigaohm (Code: A87)
        /// </summary>
        Gigaohm,

        /// <summary>
        /// Gigaohm metre (Code: A88)
        /// </summary>
        GigaohmMetre,

        /// <summary>
        /// Gigapascal (Code: A89)
        /// </summary>
        Gigapascal,

        /// <summary>
        /// Rate (Code: A9)
        /// </summary>
        /// <remarks>
        /// A unit of quantity expressed as a rate for usage of a facility or service.
        /// </remarks>
        Rate,

        /// <summary>
        /// Gigawatt (Code: A90)
        /// </summary>
        Gigawatt,

        /// <summary>
        /// Gon (Code: A91)
        /// </summary>
        /// <remarks>
        /// Synonym: grade
        /// </remarks>
        Gon,

        /// <summary>
        /// Gram per cubic metre (Code: A93)
        /// </summary>
        GramPerCubicMetre,

        /// <summary>
        /// Gram per mole (Code: A94)
        /// </summary>
        GramPerMole,

        /// <summary>
        /// Gray (Code: A95)
        /// </summary>
        Gray,

        /// <summary>
        /// Gray per second (Code: A96)
        /// </summary>
        GrayPerSecond,

        /// <summary>
        /// Hectopascal (Code: A97)
        /// </summary>
        Hectopascal,

        /// <summary>
        /// Henry per metre (Code: A98)
        /// </summary>
        HenryPerMetre,

        /// <summary>
        /// Bit (Code: A99)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to one binary digit.
        /// </remarks>
        Bit,

        /// <summary>
        /// Ball (Code: AA)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of balls (ball: object formed in the shape of sphere).
        /// </remarks>
        Ball_UnitOfCount,

        /// <summary>
        /// Bulk pack (Code: AB)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of items per bulk pack.
        /// </remarks>
        BulkPack,

        /// <summary>
        /// Acre (Code: ACR)
        /// </summary>
        Acre,

        /// <summary>
        /// Activity (Code: ACT)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of activities (activity: a unit of work or action).
        /// </remarks>
        Activity,

        /// <summary>
        /// Byte (Code: AD)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 8 bits.
        /// </remarks>
        Byte,

        /// <summary>
        /// Ampere per metre (Code: AE)
        /// </summary>
        AmperePerMetre,

        /// <summary>
        /// Additional minute (Code: AH)
        /// </summary>
        /// <remarks>
        /// A unit of time defining the number of minutes in addition to the referenced minutes.
        /// </remarks>
        AdditionalMinute,

        /// <summary>
        /// Average minute per call (Code: AI)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of minutes for the average interval of a call.
        /// </remarks>
        AverageMinutePerCall,

        /// <summary>
        /// Fathom (Code: AK)
        /// </summary>
        Fathom,

        /// <summary>
        /// Access line (Code: AL)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of telephone access lines.
        /// </remarks>
        AccessLine,

        /// <summary>
        /// Ampere hour (Code: AMH)
        /// </summary>
        /// <remarks>
        /// A unit of electric charge defining the amount of charge accumulated by a steady flow of one ampere for one hour.
        /// </remarks>
        AmpereHour,

        /// <summary>
        /// Ampere (Code: AMP)
        /// </summary>
        Ampere,

        /// <summary>
        /// Year (Code: ANN)
        /// </summary>
        /// <remarks>
        /// Unit of time equal to 365,25 days. Synonym: Julian year
        /// </remarks>
        Year,

        /// <summary>
        /// Troy ounce or apothecary ounce (Code: APZ)
        /// </summary>
        TroyOunceOrApothecaryOunce,

        /// <summary>
        /// Anti-hemophilic factor (AHF) unit (Code: AQ)
        /// </summary>
        /// <remarks>
        /// A unit of measure for blood potency (US).
        /// </remarks>
        AntiHemophilicFactor_AHF_Unit,

        /// <summary>
        /// Assortment (Code: AS)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of assortments (assortment: set of items grouped in a mixed collection).
        /// </remarks>
        Assortment,

        /// <summary>
        /// Alcoholic strength by mass (Code: ASM)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the alcoholic strength of a liquid.
        /// </remarks>
        AlcoholicStrengthByMass,

        /// <summary>
        /// Alcoholic strength by volume (Code: ASU)
        /// </summary>
        /// <remarks>
        /// A unit of volume defining the alcoholic strength of a liquid (e.g. spirit, wine, beer, etc), often at a specific temperature.
        /// </remarks>
        AlcoholicStrengthByVolume,

        /// <summary>
        /// Standard atmosphere (Code: ATM)
        /// </summary>
        StandardAtmosphere,

        /// <summary>
        /// American wire gauge (Code: AWG)
        /// </summary>
        /// <remarks>
        /// A unit of distance used for measuring the diameter of small tubes or wires such as the outer diameter of hypotermic or suture needles.
        /// </remarks>
        AmericanWireGauge,

        /// <summary>
        /// Assembly (Code: AY)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of assemblies (assembly: items that consist of component parts).
        /// </remarks>
        Assembly,

        /// <summary>
        /// British thermal unit (international table) per pound (Code: AZ)
        /// </summary>
        BritishThermalUnit_internationalTable_PerPound,

        /// <summary>
        /// Barrel (US) per day (Code: B1)
        /// </summary>
        Barrel_US_PerDay,

        /// <summary>
        /// Bit per second (Code: B10)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to one binary digit per second.
        /// </remarks>
        BitPerSecond,

        /// <summary>
        /// Joule per kilogram kelvin (Code: B11)
        /// </summary>
        JoulePerKilogramKelvin,

        /// <summary>
        /// Joule per metre (Code: B12)
        /// </summary>
        JoulePerMetre,

        /// <summary>
        /// Joule per square metre (Code: B13)
        /// </summary>
        /// <remarks>
        /// Synonym: joule per metre squared
        /// </remarks>
        JoulePerSquareMetre,

        /// <summary>
        /// Joule per metre to the fourth power (Code: B14)
        /// </summary>
        JoulePerMetreToTheFourthPower,

        /// <summary>
        /// Joule per mole (Code: B15)
        /// </summary>
        JoulePerMole,

        /// <summary>
        /// Joule per mole kelvin (Code: B16)
        /// </summary>
        JoulePerMoleKelvin,

        /// <summary>
        /// Credit (Code: B17)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of entries made to the credit side of an account.
        /// </remarks>
        Credit,

        /// <summary>
        /// Joule second (Code: B18)
        /// </summary>
        JouleSecond,

        /// <summary>
        /// Digit (Code: B19)
        /// </summary>
        /// <remarks>
        /// A unit of information defining the quantity of numerals used to form a number.
        /// </remarks>
        Digit,

        /// <summary>
        /// Joule square metre per kilogram (Code: B20)
        /// </summary>
        JouleSquareMetrePerKilogram,

        /// <summary>
        /// Kelvin per watt (Code: B21)
        /// </summary>
        KelvinPerWatt,

        /// <summary>
        /// Kiloampere (Code: B22)
        /// </summary>
        Kiloampere,

        /// <summary>
        /// Kiloampere per square metre (Code: B23)
        /// </summary>
        KiloamperePerSquareMetre,

        /// <summary>
        /// Kiloampere per metre (Code: B24)
        /// </summary>
        KiloamperePerMetre,

        /// <summary>
        /// Kilobecquerel per kilogram (Code: B25)
        /// </summary>
        KilobecquerelPerKilogram,

        /// <summary>
        /// Kilocoulomb (Code: B26)
        /// </summary>
        Kilocoulomb,

        /// <summary>
        /// Kilocoulomb per cubic metre (Code: B27)
        /// </summary>
        KilocoulombPerCubicMetre,

        /// <summary>
        /// Kilocoulomb per square metre (Code: B28)
        /// </summary>
        KilocoulombPerSquareMetre,

        /// <summary>
        /// Kiloelectronvolt (Code: B29)
        /// </summary>
        Kiloelectronvolt,

        /// <summary>
        /// Batting pound (Code: B3)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of pounds of wadded fibre.
        /// </remarks>
        BattingPound,

        /// <summary>
        /// Gibibit (Code: B30)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2³⁰ bits (binary digits).
        /// </remarks>
        Gibibit,

        /// <summary>
        /// Kilogram metre per second (Code: B31)
        /// </summary>
        KilogramMetrePerSecond,

        /// <summary>
        /// Kilogram metre squared (Code: B32)
        /// </summary>
        KilogramMetreSquared,

        /// <summary>
        /// Kilogram metre squared per second (Code: B33)
        /// </summary>
        KilogramMetreSquaredPerSecond,

        /// <summary>
        /// Kilogram per cubic decimetre (Code: B34)
        /// </summary>
        KilogramPerCubicDecimetre,

        /// <summary>
        /// Kilogram per litre (Code: B35)
        /// </summary>
        KilogramPerLitre,

        /// <summary>
        /// Barrel, imperial (Code: B4)
        /// </summary>
        /// <remarks>
        /// A unit of volume used to measure beer. One beer barrel equals 36 imperial gallons.
        /// </remarks>
        Barrel_Imperial,

        /// <summary>
        /// Kilojoule per kelvin (Code: B41)
        /// </summary>
        KilojoulePerKelvin,

        /// <summary>
        /// Kilojoule per kilogram (Code: B42)
        /// </summary>
        KilojoulePerKilogram,

        /// <summary>
        /// Kilojoule per kilogram kelvin (Code: B43)
        /// </summary>
        KilojoulePerKilogramKelvin,

        /// <summary>
        /// Kilojoule per mole (Code: B44)
        /// </summary>
        KilojoulePerMole,

        /// <summary>
        /// Kilomole (Code: B45)
        /// </summary>
        Kilomole,

        /// <summary>
        /// Kilomole per cubic metre (Code: B46)
        /// </summary>
        KilomolePerCubicMetre,

        /// <summary>
        /// Kilonewton (Code: B47)
        /// </summary>
        Kilonewton,

        /// <summary>
        /// Kilonewton metre (Code: B48)
        /// </summary>
        KilonewtonMetre,

        /// <summary>
        /// Kiloohm (Code: B49)
        /// </summary>
        Kiloohm,

        /// <summary>
        /// Kiloohm metre (Code: B50)
        /// </summary>
        KiloohmMetre,

        /// <summary>
        /// Kilosecond (Code: B52)
        /// </summary>
        Kilosecond,

        /// <summary>
        /// Kilosiemens (Code: B53)
        /// </summary>
        Kilosiemens,

        /// <summary>
        /// Kilosiemens per metre (Code: B54)
        /// </summary>
        KilosiemensPerMetre,

        /// <summary>
        /// Kilovolt per metre (Code: B55)
        /// </summary>
        KilovoltPerMetre,

        /// <summary>
        /// Kiloweber per metre (Code: B56)
        /// </summary>
        KiloweberPerMetre,

        /// <summary>
        /// Light year (Code: B57)
        /// </summary>
        /// <remarks>
        /// A unit of length defining the distance that light travels in a vacuum in one year.
        /// </remarks>
        LightYear,

        /// <summary>
        /// Litre per mole (Code: B58)
        /// </summary>
        LitrePerMole,

        /// <summary>
        /// Lumen hour (Code: B59)
        /// </summary>
        LumenHour,

        /// <summary>
        /// Lumen per square metre (Code: B60)
        /// </summary>
        LumenPerSquareMetre,

        /// <summary>
        /// Lumen per watt (Code: B61)
        /// </summary>
        LumenPerWatt,

        /// <summary>
        /// Lumen second (Code: B62)
        /// </summary>
        LumenSecond,

        /// <summary>
        /// Lux hour (Code: B63)
        /// </summary>
        LuxHour,

        /// <summary>
        /// Lux second (Code: B64)
        /// </summary>
        LuxSecond,

        /// <summary>
        /// Megaampere per square metre (Code: B66)
        /// </summary>
        MegaamperePerSquareMetre,

        /// <summary>
        /// Megabecquerel per kilogram (Code: B67)
        /// </summary>
        MegabecquerelPerKilogram,

        /// <summary>
        /// Gigabit (Code: B68)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10⁹ bits (binary digits).
        /// </remarks>
        Gigabit,

        /// <summary>
        /// Megacoulomb per cubic metre (Code: B69)
        /// </summary>
        MegacoulombPerCubicMetre,

        /// <summary>
        /// Cycle (Code: B7)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of cycles (cycle: a recurrent period of definite duration).
        /// </remarks>
        Cycle,

        /// <summary>
        /// Megacoulomb per square metre (Code: B70)
        /// </summary>
        MegacoulombPerSquareMetre,

        /// <summary>
        /// Megaelectronvolt (Code: B71)
        /// </summary>
        Megaelectronvolt,

        /// <summary>
        /// Megagram per cubic metre (Code: B72)
        /// </summary>
        MegagramPerCubicMetre,

        /// <summary>
        /// Meganewton (Code: B73)
        /// </summary>
        Meganewton,

        /// <summary>
        /// Meganewton metre (Code: B74)
        /// </summary>
        MeganewtonMetre,

        /// <summary>
        /// Megaohm (Code: B75)
        /// </summary>
        Megaohm,

        /// <summary>
        /// Megaohm metre (Code: B76)
        /// </summary>
        MegaohmMetre,

        /// <summary>
        /// Megasiemens per metre (Code: B77)
        /// </summary>
        MegasiemensPerMetre,

        /// <summary>
        /// Megavolt (Code: B78)
        /// </summary>
        Megavolt,

        /// <summary>
        /// Megavolt per metre (Code: B79)
        /// </summary>
        MegavoltPerMetre,

        /// <summary>
        /// Joule per cubic metre (Code: B8)
        /// </summary>
        JoulePerCubicMetre,

        /// <summary>
        /// Gigabit per second (Code: B80)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10⁹ bits (binary digits) per second.
        /// </remarks>
        GigabitPerSecond,

        /// <summary>
        /// Reciprocal metre squared reciprocal second (Code: B81)
        /// </summary>
        ReciprocalMetreSquaredReciprocalSecond,

        /// <summary>
        /// Inch per linear foot (Code: B82)
        /// </summary>
        /// <remarks>
        /// A unit of length defining the number of inches per linear foot.
        /// </remarks>
        InchPerLinearFoot,

        /// <summary>
        /// Metre to the fourth power (Code: B83)
        /// </summary>
        MetreToTheFourthPower,

        /// <summary>
        /// Microampere (Code: B84)
        /// </summary>
        Microampere,

        /// <summary>
        /// Microbar (Code: B85)
        /// </summary>
        Microbar,

        /// <summary>
        /// Microcoulomb (Code: B86)
        /// </summary>
        Microcoulomb,

        /// <summary>
        /// Microcoulomb per cubic metre (Code: B87)
        /// </summary>
        MicrocoulombPerCubicMetre,

        /// <summary>
        /// Microcoulomb per square metre (Code: B88)
        /// </summary>
        MicrocoulombPerSquareMetre,

        /// <summary>
        /// Microfarad per metre (Code: B89)
        /// </summary>
        MicrofaradPerMetre,

        /// <summary>
        /// Microhenry (Code: B90)
        /// </summary>
        Microhenry,

        /// <summary>
        /// Microhenry per metre (Code: B91)
        /// </summary>
        MicrohenryPerMetre,

        /// <summary>
        /// Micronewton (Code: B92)
        /// </summary>
        Micronewton,

        /// <summary>
        /// Micronewton metre (Code: B93)
        /// </summary>
        MicronewtonMetre,

        /// <summary>
        /// Microohm (Code: B94)
        /// </summary>
        Microohm,

        /// <summary>
        /// Microohm metre (Code: B95)
        /// </summary>
        MicroohmMetre,

        /// <summary>
        /// Micropascal (Code: B96)
        /// </summary>
        Micropascal,

        /// <summary>
        /// Microradian (Code: B97)
        /// </summary>
        Microradian,

        /// <summary>
        /// Microsecond (Code: B98)
        /// </summary>
        Microsecond,

        /// <summary>
        /// Microsiemens (Code: B99)
        /// </summary>
        Microsiemens,

        /// <summary>
        /// Bar [unit of pressure] (Code: BAR)
        /// </summary>
        Bar_UnitOfPressure,

        /// <summary>
        /// Base box (Code: BB)
        /// </summary>
        /// <remarks>
        /// A unit of area of 112 sheets of tin mil products (tin plate, tin free steel or black plate) 14 by 20 inches, or 31,360 square inches.
        /// </remarks>
        BaseBox,

        /// <summary>
        /// Board foot (Code: BFT)
        /// </summary>
        /// <remarks>
        /// A unit of volume defining the number of cords (cord: a stack of firewood of 128 cubic feet).
        /// </remarks>
        BoardFoot,

        /// <summary>
        /// Brake horse power (Code: BHP)
        /// </summary>
        BrakeHorsePower,

        /// <summary>
        /// Billion (EUR) (Code: BIL)
        /// </summary>
        /// <remarks>
        /// Synonym: trillion (US)
        /// </remarks>
        Billion_EUR,

        /// <summary>
        /// Dry barrel (US) (Code: BLD)
        /// </summary>
        DryBarrel_US,

        /// <summary>
        /// Barrel (US) (Code: BLL)
        /// </summary>
        Barrel_US,

        /// <summary>
        /// Hundred board foot (Code: BP)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one hundred board foot.
        /// </remarks>
        HundredBoardFoot,

        /// <summary>
        /// Beats per minute (Code: BPM)
        /// </summary>
        /// <remarks>
        /// The number of beats per minute.
        /// </remarks>
        BeatsPerMinute,

        /// <summary>
        /// Becquerel (Code: BQL)
        /// </summary>
        Becquerel,

        /// <summary>
        /// British thermal unit (international table) (Code: BTU)
        /// </summary>
        BritishThermalUnit_internationalTable,

        /// <summary>
        /// Bushel (US) (Code: BUA)
        /// </summary>
        Bushel_US,

        /// <summary>
        /// Bushel (UK) (Code: BUI)
        /// </summary>
        Bushel_UK,

        /// <summary>
        /// Call (Code: C0)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of calls (call: communication session or visitation).
        /// </remarks>
        Call,

        /// <summary>
        /// Millifarad (Code: C10)
        /// </summary>
        Millifarad,

        /// <summary>
        /// Milligal (Code: C11)
        /// </summary>
        Milligal,

        /// <summary>
        /// Milligram per metre (Code: C12)
        /// </summary>
        MilligramPerMetre,

        /// <summary>
        /// Milligray (Code: C13)
        /// </summary>
        Milligray,

        /// <summary>
        /// Millihenry (Code: C14)
        /// </summary>
        Millihenry,

        /// <summary>
        /// Millijoule (Code: C15)
        /// </summary>
        Millijoule,

        /// <summary>
        /// Millimetre per second (Code: C16)
        /// </summary>
        MillimetrePerSecond,

        /// <summary>
        /// Millimetre squared per second (Code: C17)
        /// </summary>
        MillimetreSquaredPerSecond,

        /// <summary>
        /// Millimole (Code: C18)
        /// </summary>
        Millimole,

        /// <summary>
        /// Mole per kilogram (Code: C19)
        /// </summary>
        MolePerKilogram,

        /// <summary>
        /// Millinewton (Code: C20)
        /// </summary>
        Millinewton,

        /// <summary>
        /// Kibibit (Code: C21)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2¹⁰ (1024) bits (binary digits).
        /// </remarks>
        Kibibit,

        /// <summary>
        /// Millinewton per metre (Code: C22)
        /// </summary>
        MillinewtonPerMetre,

        /// <summary>
        /// Milliohm metre (Code: C23)
        /// </summary>
        MilliohmMetre,

        /// <summary>
        /// Millipascal second (Code: C24)
        /// </summary>
        MillipascalSecond,

        /// <summary>
        /// Milliradian (Code: C25)
        /// </summary>
        Milliradian,

        /// <summary>
        /// Millisecond (Code: C26)
        /// </summary>
        Millisecond,

        /// <summary>
        /// Millisiemens (Code: C27)
        /// </summary>
        Millisiemens,

        /// <summary>
        /// Millisievert (Code: C28)
        /// </summary>
        Millisievert,

        /// <summary>
        /// Millitesla (Code: C29)
        /// </summary>
        Millitesla,

        /// <summary>
        /// Microvolt per metre (Code: C3)
        /// </summary>
        MicrovoltPerMetre,

        /// <summary>
        /// Millivolt per metre (Code: C30)
        /// </summary>
        MillivoltPerMetre,

        /// <summary>
        /// Milliwatt (Code: C31)
        /// </summary>
        Milliwatt,

        /// <summary>
        /// Milliwatt per square metre (Code: C32)
        /// </summary>
        MilliwattPerSquareMetre,

        /// <summary>
        /// Milliweber (Code: C33)
        /// </summary>
        Milliweber,

        /// <summary>
        /// Mole (Code: C34)
        /// </summary>
        Mole,

        /// <summary>
        /// Mole per cubic decimetre (Code: C35)
        /// </summary>
        MolePerCubicDecimetre,

        /// <summary>
        /// Mole per cubic metre (Code: C36)
        /// </summary>
        MolePerCubicMetre,

        /// <summary>
        /// Kilobit (Code: C37)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10³ (1000) bits (binary digits).
        /// </remarks>
        Kilobit,

        /// <summary>
        /// Mole per litre (Code: C38)
        /// </summary>
        MolePerLitre,

        /// <summary>
        /// Nanoampere (Code: C39)
        /// </summary>
        Nanoampere,

        /// <summary>
        /// Nanocoulomb (Code: C40)
        /// </summary>
        Nanocoulomb,

        /// <summary>
        /// Nanofarad (Code: C41)
        /// </summary>
        Nanofarad,

        /// <summary>
        /// Nanofarad per metre (Code: C42)
        /// </summary>
        NanofaradPerMetre,

        /// <summary>
        /// Nanohenry (Code: C43)
        /// </summary>
        Nanohenry,

        /// <summary>
        /// Nanohenry per metre (Code: C44)
        /// </summary>
        NanohenryPerMetre,

        /// <summary>
        /// Nanometre (Code: C45)
        /// </summary>
        Nanometre,

        /// <summary>
        /// Nanoohm metre (Code: C46)
        /// </summary>
        NanoohmMetre,

        /// <summary>
        /// Nanosecond (Code: C47)
        /// </summary>
        Nanosecond,

        /// <summary>
        /// Nanotesla (Code: C48)
        /// </summary>
        Nanotesla,

        /// <summary>
        /// Nanowatt (Code: C49)
        /// </summary>
        Nanowatt,

        /// <summary>
        /// Neper (Code: C50)
        /// </summary>
        Neper,

        /// <summary>
        /// Neper per second (Code: C51)
        /// </summary>
        NeperPerSecond,

        /// <summary>
        /// Picometre (Code: C52)
        /// </summary>
        Picometre,

        /// <summary>
        /// Newton metre second (Code: C53)
        /// </summary>
        NewtonMetreSecond,

        /// <summary>
        /// Newton metre squared per kilogram squared (Code: C54)
        /// </summary>
        NewtonMetreSquaredPerKilogramSquared,

        /// <summary>
        /// Newton per square metre (Code: C55)
        /// </summary>
        NewtonPerSquareMetre,

        /// <summary>
        /// Newton per square millimetre (Code: C56)
        /// </summary>
        NewtonPerSquareMillimetre,

        /// <summary>
        /// Newton second (Code: C57)
        /// </summary>
        NewtonSecond,

        /// <summary>
        /// Newton second per metre (Code: C58)
        /// </summary>
        NewtonSecondPerMetre,

        /// <summary>
        /// Octave (Code: C59)
        /// </summary>
        /// <remarks>
        /// A unit used in music to describe the ratio in frequency between notes.
        /// </remarks>
        Octave,

        /// <summary>
        /// Ohm centimetre (Code: C60)
        /// </summary>
        OhmCentimetre,

        /// <summary>
        /// Ohm metre (Code: C61)
        /// </summary>
        OhmMetre,

        /// <summary>
        /// One (Code: C62)
        /// </summary>
        /// <remarks>
        /// Synonym: unit
        /// </remarks>
        One,

        /// <summary>
        /// Parsec (Code: C63)
        /// </summary>
        Parsec,

        /// <summary>
        /// Pascal per kelvin (Code: C64)
        /// </summary>
        PascalPerKelvin,

        /// <summary>
        /// Pascal second (Code: C65)
        /// </summary>
        PascalSecond,

        /// <summary>
        /// Pascal second per cubic metre (Code: C66)
        /// </summary>
        PascalSecondPerCubicMetre,

        /// <summary>
        /// Pascal second per metre (Code: C67)
        /// </summary>
        PascalSecondPerMetre,

        /// <summary>
        /// Petajoule (Code: C68)
        /// </summary>
        Petajoule,

        /// <summary>
        /// Phon (Code: C69)
        /// </summary>
        /// <remarks>
        /// A unit of subjective sound loudness. A sound has loudness p phons if it seems to the listener to be equal in loudness to the sound of a pure tone of frequency 1 kilohertz and strength p decibels.
        /// </remarks>
        Phon,

        /// <summary>
        /// Centipoise (Code: C7)
        /// </summary>
        Centipoise,

        /// <summary>
        /// Picoampere (Code: C70)
        /// </summary>
        Picoampere,

        /// <summary>
        /// Picocoulomb (Code: C71)
        /// </summary>
        Picocoulomb,

        /// <summary>
        /// Picofarad per metre (Code: C72)
        /// </summary>
        PicofaradPerMetre,

        /// <summary>
        /// Picohenry (Code: C73)
        /// </summary>
        Picohenry,

        /// <summary>
        /// Kilobit per second (Code: C74)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10³ (1000) bits (binary digits) per second.
        /// </remarks>
        KilobitPerSecond,

        /// <summary>
        /// Picowatt (Code: C75)
        /// </summary>
        Picowatt,

        /// <summary>
        /// Picowatt per square metre (Code: C76)
        /// </summary>
        PicowattPerSquareMetre,

        /// <summary>
        /// Pound-force (Code: C78)
        /// </summary>
        PoundForce,

        /// <summary>
        /// Kilovolt ampere hour (Code: C79)
        /// </summary>
        /// <remarks>
        /// A unit of accumulated energy of 1000 volt amperes over a period of one hour.
        /// </remarks>
        KilovoltAmpereHour,

        /// <summary>
        /// Millicoulomb per kilogram (Code: C8)
        /// </summary>
        MillicoulombPerKilogram,

        /// <summary>
        /// Rad (Code: C80)
        /// </summary>
        Rad,

        /// <summary>
        /// Radian (Code: C81)
        /// </summary>
        Radian,

        /// <summary>
        /// Radian square metre per mole (Code: C82)
        /// </summary>
        RadianSquareMetrePerMole,

        /// <summary>
        /// Radian square metre per kilogram (Code: C83)
        /// </summary>
        RadianSquareMetrePerKilogram,

        /// <summary>
        /// Radian per metre (Code: C84)
        /// </summary>
        RadianPerMetre,

        /// <summary>
        /// Reciprocal angstrom (Code: C85)
        /// </summary>
        ReciprocalAngstrom,

        /// <summary>
        /// Reciprocal cubic metre (Code: C86)
        /// </summary>
        ReciprocalCubicMetre,

        /// <summary>
        /// Reciprocal cubic metre per second (Code: C87)
        /// </summary>
        /// <remarks>
        /// Synonym: reciprocal second per cubic metre
        /// </remarks>
        ReciprocalCubicMetrePerSecond,

        /// <summary>
        /// Reciprocal electron volt per cubic metre (Code: C88)
        /// </summary>
        ReciprocalElectronVoltPerCubicMetre,

        /// <summary>
        /// Reciprocal henry (Code: C89)
        /// </summary>
        ReciprocalHenry,

        /// <summary>
        /// Coil group (Code: C9)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of coil groups (coil group: groups of items arranged by lengths of those items placed in a joined sequence of concentric circles).
        /// </remarks>
        CoilGroup,

        /// <summary>
        /// Reciprocal joule per cubic metre (Code: C90)
        /// </summary>
        ReciprocalJoulePerCubicMetre,

        /// <summary>
        /// Reciprocal kelvin or kelvin to the power minus one (Code: C91)
        /// </summary>
        ReciprocalKelvinOrKelvinToThePowerMinusOne,

        /// <summary>
        /// Reciprocal metre (Code: C92)
        /// </summary>
        ReciprocalMetre,

        /// <summary>
        /// Reciprocal square metre (Code: C93)
        /// </summary>
        /// <remarks>
        /// Synonym: reciprocal metre squared
        /// </remarks>
        ReciprocalSquareMetre,

        /// <summary>
        /// Reciprocal minute (Code: C94)
        /// </summary>
        ReciprocalMinute,

        /// <summary>
        /// Reciprocal mole (Code: C95)
        /// </summary>
        ReciprocalMole,

        /// <summary>
        /// Reciprocal pascal or pascal to the power minus one (Code: C96)
        /// </summary>
        ReciprocalPascalOrPascalToThePowerMinusOne,

        /// <summary>
        /// Reciprocal second (Code: C97)
        /// </summary>
        ReciprocalSecond,

        /// <summary>
        /// Reciprocal second per metre squared (Code: C99)
        /// </summary>
        ReciprocalSecondPerMetreSquared,

        /// <summary>
        /// Carrying capacity in metric ton (Code: CCT)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the carrying capacity, expressed as the number of metric tons.
        /// </remarks>
        CarryingCapacityInMetricTon,

        /// <summary>
        /// Candela (Code: CDL)
        /// </summary>
        Candela,

        /// <summary>
        /// Degree Celsius (Code: CEL)
        /// </summary>
        /// <remarks>
        /// Refer ISO 80000-5 (Quantities and units — Part 5: Thermodynamics)
        /// </remarks>
        DegreeCelsius,

        /// <summary>
        /// Hundred (Code: CEN)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of units in multiples of 100.
        /// </remarks>
        Hundred,

        /// <summary>
        /// Card (Code: CG)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of units of card (card: thick stiff paper or cardboard).
        /// </remarks>
        Card_UnitOfCount,

        /// <summary>
        /// Centigram (Code: CGM)
        /// </summary>
        Centigram,

        /// <summary>
        /// Coulomb per kilogram (Code: CKG)
        /// </summary>
        CoulombPerKilogram,

        /// <summary>
        /// Hundred leave (Code: CLF)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of leaves, expressed in units of one hundred leaves.
        /// </remarks>
        HundredLeave,

        /// <summary>
        /// Centilitre (Code: CLT)
        /// </summary>
        Centilitre,

        /// <summary>
        /// Square centimetre (Code: CMK)
        /// </summary>
        SquareCentimetre,

        /// <summary>
        /// Cubic centimetre (Code: CMQ)
        /// </summary>
        CubicCentimetre,

        /// <summary>
        /// Centimetre (Code: CMT)
        /// </summary>
        Centimetre,

        /// <summary>
        /// Hundred pack (Code: CNP)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of hundred-packs (hundred-pack: set of one hundred items packaged together).
        /// </remarks>
        HundredPack,

        /// <summary>
        /// Cental (UK) (Code: CNT)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one hundred weight (US).
        /// </remarks>
        Cental_UK,

        /// <summary>
        /// Coulomb (Code: COU)
        /// </summary>
        Coulomb,

        /// <summary>
        /// Content gram (Code: CTG)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of grams of a named item in a product.
        /// </remarks>
        ContentGram,

        /// <summary>
        /// Metric carat (Code: CTM)
        /// </summary>
        MetricCarat,

        /// <summary>
        /// Content ton (metric) (Code: CTN)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of metric tons of a named item in a product.
        /// </remarks>
        ContentTon_metric,

        /// <summary>
        /// Curie (Code: CUR)
        /// </summary>
        Curie,

        /// <summary>
        /// Hundred pound (cwt) / hundred weight (US) (Code: CWA)
        /// </summary>
        HundredPound_cwt_PerHundredWeight_US,

        /// <summary>
        /// Hundred weight (UK) (Code: CWI)
        /// </summary>
        HundredWeight_UK,

        /// <summary>
        /// Kilowatt hour per hour (Code: D03)
        /// </summary>
        /// <remarks>
        /// A unit of accumulated energy of a thousand watts over a period of one hour.
        /// </remarks>
        KilowattHourPerHour,

        /// <summary>
        /// Lot [unit of weight] (Code: D04)
        /// </summary>
        /// <remarks>
        /// A unit of weight equal to about 1/2 ounce or 15 grams.
        /// </remarks>
        Lot_UnitOfWeight,

        /// <summary>
        /// Reciprocal second per steradian (Code: D1)
        /// </summary>
        ReciprocalSecondPerSteradian,

        /// <summary>
        /// Siemens per metre (Code: D10)
        /// </summary>
        SiemensPerMetre,

        /// <summary>
        /// Mebibit (Code: D11)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2²⁰ (1048576) bits (binary digits).
        /// </remarks>
        Mebibit,

        /// <summary>
        /// Siemens square metre per mole (Code: D12)
        /// </summary>
        SiemensSquareMetrePerMole,

        /// <summary>
        /// Sievert (Code: D13)
        /// </summary>
        Sievert,

        /// <summary>
        /// Sone (Code: D15)
        /// </summary>
        /// <remarks>
        /// A unit of subjective sound loudness. One sone is the loudness of a pure tone of frequency one kilohertz and strength 40 decibels.
        /// </remarks>
        Sone,

        /// <summary>
        /// Square centimetre per erg (Code: D16)
        /// </summary>
        SquareCentimetrePerErg,

        /// <summary>
        /// Square centimetre per steradian erg (Code: D17)
        /// </summary>
        SquareCentimetrePerSteradianErg,

        /// <summary>
        /// Metre kelvin (Code: D18)
        /// </summary>
        MetreKelvin,

        /// <summary>
        /// Square metre kelvin per watt (Code: D19)
        /// </summary>
        SquareMetreKelvinPerWatt,

        /// <summary>
        /// Reciprocal second per steradian metre squared (Code: D2)
        /// </summary>
        ReciprocalSecondPerSteradianMetreSquared,

        /// <summary>
        /// Square metre per joule (Code: D20)
        /// </summary>
        SquareMetrePerJoule,

        /// <summary>
        /// Square metre per kilogram (Code: D21)
        /// </summary>
        SquareMetrePerKilogram,

        /// <summary>
        /// Square metre per mole (Code: D22)
        /// </summary>
        SquareMetrePerMole,

        /// <summary>
        /// Pen gram (protein) (Code: D23)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of grams of amino acid prescribed for parenteral/enteral therapy.
        /// </remarks>
        PenGram_protein,

        /// <summary>
        /// Square metre per steradian (Code: D24)
        /// </summary>
        SquareMetrePerSteradian,

        /// <summary>
        /// Square metre per steradian joule (Code: D25)
        /// </summary>
        SquareMetrePerSteradianJoule,

        /// <summary>
        /// Square metre per volt second (Code: D26)
        /// </summary>
        SquareMetrePerVoltSecond,

        /// <summary>
        /// Steradian (Code: D27)
        /// </summary>
        Steradian,

        /// <summary>
        /// Terahertz (Code: D29)
        /// </summary>
        Terahertz,

        /// <summary>
        /// Terajoule (Code: D30)
        /// </summary>
        Terajoule,

        /// <summary>
        /// Terawatt (Code: D31)
        /// </summary>
        Terawatt,

        /// <summary>
        /// Terawatt hour (Code: D32)
        /// </summary>
        TerawattHour,

        /// <summary>
        /// Tesla (Code: D33)
        /// </summary>
        Tesla,

        /// <summary>
        /// Tex (Code: D34)
        /// </summary>
        /// <remarks>
        /// A unit of yarn density. One decitex equals a mass of 1 gram per 1 kilometre of length.
        /// </remarks>
        Tex,

        /// <summary>
        /// Megabit (Code: D36)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10⁶ (1000000) bits (binary digits).
        /// </remarks>
        Megabit,

        /// <summary>
        /// Tonne per cubic metre (Code: D41)
        /// </summary>
        TonnePerCubicMetre,

        /// <summary>
        /// Tropical year (Code: D42)
        /// </summary>
        TropicalYear,

        /// <summary>
        /// Unified atomic mass unit (Code: D43)
        /// </summary>
        UnifiedAtomicMassUnit,

        /// <summary>
        /// Var (Code: D44)
        /// </summary>
        /// <remarks>
        /// The name of the unit is an acronym for volt-ampere-reactive.
        /// </remarks>
        Var,

        /// <summary>
        /// Volt squared per kelvin squared (Code: D45)
        /// </summary>
        VoltSquaredPerKelvinSquared,

        /// <summary>
        /// Volt - ampere (Code: D46)
        /// </summary>
        VoltAmpere,

        /// <summary>
        /// Volt per centimetre (Code: D47)
        /// </summary>
        VoltPerCentimetre,

        /// <summary>
        /// Volt per kelvin (Code: D48)
        /// </summary>
        VoltPerKelvin,

        /// <summary>
        /// Millivolt per kelvin (Code: D49)
        /// </summary>
        MillivoltPerKelvin,

        /// <summary>
        /// Kilogram per square centimetre (Code: D5)
        /// </summary>
        KilogramPerSquareCentimetre,

        /// <summary>
        /// Volt per metre (Code: D50)
        /// </summary>
        VoltPerMetre,

        /// <summary>
        /// Volt per millimetre (Code: D51)
        /// </summary>
        VoltPerMillimetre,

        /// <summary>
        /// Watt per kelvin (Code: D52)
        /// </summary>
        WattPerKelvin,

        /// <summary>
        /// Watt per metre kelvin (Code: D53)
        /// </summary>
        WattPerMetreKelvin,

        /// <summary>
        /// Watt per square metre (Code: D54)
        /// </summary>
        WattPerSquareMetre,

        /// <summary>
        /// Watt per square metre kelvin (Code: D55)
        /// </summary>
        WattPerSquareMetreKelvin,

        /// <summary>
        /// Watt per square metre kelvin to the fourth power (Code: D56)
        /// </summary>
        WattPerSquareMetreKelvinToTheFourthPower,

        /// <summary>
        /// Watt per steradian (Code: D57)
        /// </summary>
        WattPerSteradian,

        /// <summary>
        /// Watt per steradian square metre (Code: D58)
        /// </summary>
        WattPerSteradianSquareMetre,

        /// <summary>
        /// Weber per metre (Code: D59)
        /// </summary>
        WeberPerMetre,

        /// <summary>
        /// Roentgen per second (Code: D6)
        /// </summary>
        RoentgenPerSecond,

        /// <summary>
        /// Weber per millimetre (Code: D60)
        /// </summary>
        WeberPerMillimetre,

        /// <summary>
        /// Minute [unit of angle] (Code: D61)
        /// </summary>
        Minute_UnitOfAngle,

        /// <summary>
        /// Second [unit of angle] (Code: D62)
        /// </summary>
        Second_UnitOfAngle,

        /// <summary>
        /// Book (Code: D63)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of books (book: set of items bound together or written document of a material whole).
        /// </remarks>
        Book,

        /// <summary>
        /// Round (Code: D65)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of rounds (round: A circular or cylindrical object).
        /// </remarks>
        Round,

        /// <summary>
        /// Number of words (Code: D68)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of words.
        /// </remarks>
        NumberOfWords,

        /// <summary>
        /// Inch to the fourth power (Code: D69)
        /// </summary>
        InchToTheFourthPower,

        /// <summary>
        /// Joule square metre (Code: D73)
        /// </summary>
        JouleSquareMetre,

        /// <summary>
        /// Kilogram per mole (Code: D74)
        /// </summary>
        KilogramPerMole,

        /// <summary>
        /// Megacoulomb (Code: D77)
        /// </summary>
        Megacoulomb,

        /// <summary>
        /// Megajoule per second (Code: D78)
        /// </summary>
        /// <remarks>
        /// A unit of accumulated energy equal to one million joules per second.
        /// </remarks>
        MegajoulePerSecond,

        /// <summary>
        /// Microwatt (Code: D80)
        /// </summary>
        Microwatt,

        /// <summary>
        /// Microtesla (Code: D81)
        /// </summary>
        Microtesla,

        /// <summary>
        /// Microvolt (Code: D82)
        /// </summary>
        Microvolt,

        /// <summary>
        /// Millinewton metre (Code: D83)
        /// </summary>
        MillinewtonMetre,

        /// <summary>
        /// Microwatt per square metre (Code: D85)
        /// </summary>
        MicrowattPerSquareMetre,

        /// <summary>
        /// Millicoulomb (Code: D86)
        /// </summary>
        Millicoulomb,

        /// <summary>
        /// Millimole per kilogram (Code: D87)
        /// </summary>
        MillimolePerKilogram,

        /// <summary>
        /// Millicoulomb per cubic metre (Code: D88)
        /// </summary>
        MillicoulombPerCubicMetre,

        /// <summary>
        /// Millicoulomb per square metre (Code: D89)
        /// </summary>
        MillicoulombPerSquareMetre,

        /// <summary>
        /// Rem (Code: D91)
        /// </summary>
        Rem,

        /// <summary>
        /// Second per cubic metre (Code: D93)
        /// </summary>
        SecondPerCubicMetre,

        /// <summary>
        /// Second per cubic metre radian (Code: D94)
        /// </summary>
        SecondPerCubicMetreRadian,

        /// <summary>
        /// Joule per gram (Code: D95)
        /// </summary>
        JoulePerGram,

        /// <summary>
        /// Decare (Code: DAA)
        /// </summary>
        Decare,

        /// <summary>
        /// Ten day (Code: DAD)
        /// </summary>
        /// <remarks>
        /// A unit of time defining the number of days in multiples of 10.
        /// </remarks>
        TenDay,

        /// <summary>
        /// Day (Code: DAY)
        /// </summary>
        Day,

        /// <summary>
        /// Dry pound (Code: DB)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of pounds of a product, disregarding the water content of the product.
        /// </remarks>
        DryPound,

        /// <summary>
        /// Decibel-milliwatts (Code: DBM)
        /// </summary>
        DecibelMilliwatts,

        /// <summary>
        /// Decibel watt (Code: DBW)
        /// </summary>
        DecibelWatt,

        /// <summary>
        /// Degree [unit of angle] (Code: DD)
        /// </summary>
        Degree_UnitOfAngle,

        /// <summary>
        /// Decade (Code: DEC)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of decades (decade: quantity equal to 10 or time equal to 10 years).
        /// </remarks>
        Decade,

        /// <summary>
        /// Decigram (Code: DG)
        /// </summary>
        Decigram,

        /// <summary>
        /// Decagram (Code: DJ)
        /// </summary>
        Decagram,

        /// <summary>
        /// Decilitre (Code: DLT)
        /// </summary>
        Decilitre,

        /// <summary>
        /// Cubic decametre (Code: DMA)
        /// </summary>
        CubicDecametre,

        /// <summary>
        /// Square decimetre (Code: DMK)
        /// </summary>
        SquareDecimetre,

        /// <summary>
        /// Standard kilolitre (Code: DMO)
        /// </summary>
        /// <remarks>
        /// A unit of volume defining the number of kilolitres of a product at a temperature of 15 degrees Celsius, especially in relation to hydrocarbon oils.
        /// </remarks>
        StandardKilolitre,

        /// <summary>
        /// Cubic decimetre (Code: DMQ)
        /// </summary>
        CubicDecimetre,

        /// <summary>
        /// Decimetre (Code: DMT)
        /// </summary>
        Decimetre,

        /// <summary>
        /// Decinewton metre (Code: DN)
        /// </summary>
        DecinewtonMetre,

        /// <summary>
        /// Dozen piece (Code: DPC)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of pieces in multiples of 12 (piece: a single item, article or exemplar).
        /// </remarks>
        DozenPiece,

        /// <summary>
        /// Dozen pair (Code: DPR)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of pairs in multiples of 12 (pair: item described by two's).
        /// </remarks>
        DozenPair,

        /// <summary>
        /// Displacement tonnage (Code: DPT)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the volume of sea water a ship displaces, expressed as the number of tons.
        /// </remarks>
        DisplacementTonnage,

        /// <summary>
        /// Dram (US) (Code: DRA)
        /// </summary>
        /// <remarks>
        /// Synonym: drachm (UK), troy dram
        /// </remarks>
        Dram_US,

        /// <summary>
        /// Dram (UK) (Code: DRI)
        /// </summary>
        /// <remarks>
        /// Synonym: avoirdupois dram
        /// </remarks>
        Dram_UK,

        /// <summary>
        /// Dozen roll (Code: DRL)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of rolls, expressed in twelve roll units.
        /// </remarks>
        DozenRoll,

        /// <summary>
        /// Dry ton (Code: DT)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of tons of a product, disregarding the water content of the product.
        /// </remarks>
        DryTon,

        /// <summary>
        /// Decitonne (Code: DTN)
        /// </summary>
        /// <remarks>
        /// Synonym: centner, metric 100 kg; quintal, metric 100 kg
        /// </remarks>
        Decitonne,

        /// <summary>
        /// Pennyweight (Code: DWT)
        /// </summary>
        Pennyweight,

        /// <summary>
        /// Dozen (Code: DZN)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of units in multiples of 12.
        /// </remarks>
        Dozen,

        /// <summary>
        /// Dozen pack (Code: DZP)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of packs in multiples of 12 (pack: standard packaging unit).
        /// </remarks>
        DozenPack,

        /// <summary>
        /// Newton per square centimetre (Code: E01)
        /// </summary>
        /// <remarks>
        /// A measure of pressure expressed in newtons per square centimetre.
        /// </remarks>
        NewtonPerSquareCentimetre,

        /// <summary>
        /// Megawatt hour per hour (Code: E07)
        /// </summary>
        /// <remarks>
        /// A unit of accumulated energy of a million watts over a period of one hour.
        /// </remarks>
        MegawattHourPerHour,

        /// <summary>
        /// Megawatt per hertz (Code: E08)
        /// </summary>
        /// <remarks>
        /// A unit of energy expressed as the load change in million watts that will cause a frequency shift of one hertz.
        /// </remarks>
        MegawattPerHertz,

        /// <summary>
        /// Milliampere hour (Code: E09)
        /// </summary>
        /// <remarks>
        /// A unit of power load delivered at the rate of one thousandth of an ampere over a period of one hour.
        /// </remarks>
        MilliampereHour,

        /// <summary>
        /// Degree day (Code: E10)
        /// </summary>
        /// <remarks>
        /// A unit of measure used in meteorology and engineering to measure the demand for heating or cooling over a given period of days.
        /// </remarks>
        DegreeDay,

        /// <summary>
        /// Mille (Code: E12)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of cigarettes in units of 1000.
        /// </remarks>
        Mille,

        /// <summary>
        /// Kilocalorie (international table) (Code: E14)
        /// </summary>
        /// <remarks>
        /// A unit of heat energy equal to one thousand calories.
        /// </remarks>
        Kilocalorie_internationalTable,

        /// <summary>
        /// Kilocalorie (thermochemical) per hour (Code: E15)
        /// </summary>
        /// <remarks>
        /// A unit of energy equal to one thousand calories per hour.
        /// </remarks>
        Kilocalorie_thermochemical_PerHour,

        /// <summary>
        /// Million Btu(IT) per hour (Code: E16)
        /// </summary>
        /// <remarks>
        /// A unit of power equal to one million British thermal units per hour.
        /// </remarks>
        MillionBtu_IT_PerHour,

        /// <summary>
        /// Cubic foot per second (Code: E17)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one cubic foot passing a given point in a period of one second.
        /// </remarks>
        CubicFootPerSecond,

        /// <summary>
        /// Tonne per hour (Code: E18)
        /// </summary>
        /// <remarks>
        /// A unit of weight or mass equal to one tonne per hour.
        /// </remarks>
        TonnePerHour,

        /// <summary>
        /// Ping (Code: E19)
        /// </summary>
        /// <remarks>
        /// A unit of area equal to 3.3 square metres.
        /// </remarks>
        Ping,

        /// <summary>
        /// Megabit per second (Code: E20)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10⁶ (1000000) bits (binary digits) per second.
        /// </remarks>
        MegabitPerSecond,

        /// <summary>
        /// Shares (Code: E21)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of shares (share: a total or portion of the parts into which a business entity’s capital is divided).
        /// </remarks>
        Shares,

        /// <summary>
        /// TEU (Code: E22)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of twenty-foot equivalent units (TEUs) as a measure of containerized cargo capacity.
        /// </remarks>
        TEU,

        /// <summary>
        /// Tyre (Code: E23)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of tyres (a solid or air-filled covering placed around a wheel rim to form a soft contact with the road, absorb shock and provide traction).
        /// </remarks>
        Tyre_UnitOfCount,

        /// <summary>
        /// Active unit (Code: E25)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of active units within a substance.
        /// </remarks>
        ActiveUnit,

        /// <summary>
        /// Dose (Code: E27)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of doses (dose: a definite quantity of a medicine or drug).
        /// </remarks>
        Dose,

        /// <summary>
        /// Air dry ton (Code: E28)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of tons of a product, disregarding the water content of the product.
        /// </remarks>
        AirDryTon,

        /// <summary>
        /// Strand (Code: E30)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of strands (strand: long, thin, flexible, single thread, strip of fibre, constituent filament or multiples of the same, twisted together).
        /// </remarks>
        Strand,

        /// <summary>
        /// Square metre per litre (Code: E31)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of square metres per litre.
        /// </remarks>
        SquareMetrePerLitre,

        /// <summary>
        /// Litre per hour (Code: E32)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of litres per hour.
        /// </remarks>
        LitrePerHour,

        /// <summary>
        /// Foot per thousand (Code: E33)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of feet per thousand units.
        /// </remarks>
        FootPerThousand,

        /// <summary>
        /// Gigabyte (Code: E34)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10⁹ bytes.
        /// </remarks>
        Gigabyte,

        /// <summary>
        /// Terabyte (Code: E35)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10¹² bytes.
        /// </remarks>
        Terabyte,

        /// <summary>
        /// Petabyte (Code: E36)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10¹⁵ bytes.
        /// </remarks>
        Petabyte,

        /// <summary>
        /// Pixel (Code: E37)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of pixels (pixel: picture element).
        /// </remarks>
        Pixel,

        /// <summary>
        /// Megapixel (Code: E38)
        /// </summary>
        /// <remarks>
        /// A unit of count equal to 10⁶ (1000000) pixels (picture elements).
        /// </remarks>
        Megapixel,

        /// <summary>
        /// Dots per inch (Code: E39)
        /// </summary>
        /// <remarks>
        /// A unit of information defining the number of dots per linear inch as a measure of the resolution or sharpness of a graphic image.
        /// </remarks>
        DotsPerInch,

        /// <summary>
        /// Gross kilogram (Code: E4)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the total number of kilograms before deductions.
        /// </remarks>
        GrossKilogram,

        /// <summary>
        /// Part per hundred thousand (Code: E40)
        /// </summary>
        /// <remarks>
        /// A unit of proportion equal to 10⁻⁵.
        /// </remarks>
        PartPerHundredThousand,

        /// <summary>
        /// Kilogram-force per square millimetre (Code: E41)
        /// </summary>
        /// <remarks>
        /// A unit of pressure defining the number of kilograms force per square millimetre.
        /// </remarks>
        KilogramForcePerSquareMillimetre,

        /// <summary>
        /// Kilogram-force per square centimetre (Code: E42)
        /// </summary>
        /// <remarks>
        /// A unit of pressure defining the number of kilograms force per square centimetre.
        /// </remarks>
        KilogramForcePerSquareCentimetre,

        /// <summary>
        /// Joule per square centimetre (Code: E43)
        /// </summary>
        /// <remarks>
        /// A unit of energy defining the number of joules per square centimetre.
        /// </remarks>
        JoulePerSquareCentimetre,

        /// <summary>
        /// Kilogram-force metre per square centimetre (Code: E44)
        /// </summary>
        /// <remarks>
        /// A unit of torsion defining the torque kilogram-force metre per square centimetre.
        /// </remarks>
        KilogramForceMetrePerSquareCentimetre,

        /// <summary>
        /// Milliohm (Code: E45)
        /// </summary>
        Milliohm,

        /// <summary>
        /// Kilowatt hour per cubic metre (Code: E46)
        /// </summary>
        /// <remarks>
        /// A unit of energy consumption expressed as kilowatt hour per cubic metre.
        /// </remarks>
        KilowattHourPerCubicMetre,

        /// <summary>
        /// Kilowatt hour per kelvin (Code: E47)
        /// </summary>
        /// <remarks>
        /// A unit of energy consumption expressed as kilowatt hour per kelvin.
        /// </remarks>
        KilowattHourPerKelvin,

        /// <summary>
        /// Service unit (Code: E48)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of service units (service unit: defined period / property / facility / utility of supply).
        /// </remarks>
        ServiceUnit,

        /// <summary>
        /// Working day (Code: E49)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of working days (working day: a day on which work is ordinarily performed).
        /// </remarks>
        WorkingDay,

        /// <summary>
        /// Accounting unit (Code: E50)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of accounting units.
        /// </remarks>
        AccountingUnit,

        /// <summary>
        /// Job (Code: E51)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of jobs.
        /// </remarks>
        Job,

        /// <summary>
        /// Run foot (Code: E52)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number feet per run.
        /// </remarks>
        RunFoot,

        /// <summary>
        /// Test (Code: E53)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of tests.
        /// </remarks>
        Test,

        /// <summary>
        /// Trip (Code: E54)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of trips.
        /// </remarks>
        Trip,

        /// <summary>
        /// Use (Code: E55)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of times an object is used.
        /// </remarks>
        Use,

        /// <summary>
        /// Well (Code: E56)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of wells.
        /// </remarks>
        Well,

        /// <summary>
        /// Zone (Code: E57)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of zones.
        /// </remarks>
        Zone,

        /// <summary>
        /// Exabit per second (Code: E58)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10¹⁸ bits (binary digits) per second.
        /// </remarks>
        ExabitPerSecond,

        /// <summary>
        /// Exbibyte (Code: E59)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁶⁰ bytes.
        /// </remarks>
        Exbibyte,

        /// <summary>
        /// Pebibyte (Code: E60)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁵⁰ bytes.
        /// </remarks>
        Pebibyte,

        /// <summary>
        /// Tebibyte (Code: E61)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁴⁰ bytes.
        /// </remarks>
        Tebibyte,

        /// <summary>
        /// Gibibyte (Code: E62)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2³⁰ bytes.
        /// </remarks>
        Gibibyte,

        /// <summary>
        /// Mebibyte (Code: E63)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2²⁰ bytes.
        /// </remarks>
        Mebibyte,

        /// <summary>
        /// Kibibyte (Code: E64)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2¹⁰ bytes.
        /// </remarks>
        Kibibyte,

        /// <summary>
        /// Exbibit per metre (Code: E65)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁶⁰ bits (binary digits) per metre.
        /// </remarks>
        ExbibitPerMetre,

        /// <summary>
        /// Exbibit per square metre (Code: E66)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁶⁰ bits (binary digits) per square metre.
        /// </remarks>
        ExbibitPerSquareMetre,

        /// <summary>
        /// Exbibit per cubic metre (Code: E67)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁶⁰ bits (binary digits) per cubic metre.
        /// </remarks>
        ExbibitPerCubicMetre,

        /// <summary>
        /// Gigabyte per second (Code: E68)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10⁹ bytes per second.
        /// </remarks>
        GigabytePerSecond,

        /// <summary>
        /// Gibibit per metre (Code: E69)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2³⁰ bits (binary digits) per metre.
        /// </remarks>
        GibibitPerMetre,

        /// <summary>
        /// Gibibit per square metre (Code: E70)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2³⁰ bits (binary digits) per square metre.
        /// </remarks>
        GibibitPerSquareMetre,

        /// <summary>
        /// Gibibit per cubic metre (Code: E71)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2³⁰ bits (binary digits) per cubic metre.
        /// </remarks>
        GibibitPerCubicMetre,

        /// <summary>
        /// Kibibit per metre (Code: E72)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2¹⁰ bits (binary digits) per metre.
        /// </remarks>
        KibibitPerMetre,

        /// <summary>
        /// Kibibit per square metre (Code: E73)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2¹⁰ bits (binary digits) per square metre.
        /// </remarks>
        KibibitPerSquareMetre,

        /// <summary>
        /// Kibibit per cubic metre (Code: E74)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2¹⁰ bits (binary digits) per cubic metre.
        /// </remarks>
        KibibitPerCubicMetre,

        /// <summary>
        /// Mebibit per metre (Code: E75)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2²⁰ bits (binary digits) per metre.
        /// </remarks>
        MebibitPerMetre,

        /// <summary>
        /// Mebibit per square metre (Code: E76)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2²⁰ bits (binary digits) per square metre.
        /// </remarks>
        MebibitPerSquareMetre,

        /// <summary>
        /// Mebibit per cubic metre (Code: E77)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2²⁰ bits (binary digits) per cubic metre.
        /// </remarks>
        MebibitPerCubicMetre,

        /// <summary>
        /// Petabit (Code: E78)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10¹⁵ bits (binary digits).
        /// </remarks>
        Petabit,

        /// <summary>
        /// Petabit per second (Code: E79)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10¹⁵ bits (binary digits) per second.
        /// </remarks>
        PetabitPerSecond,

        /// <summary>
        /// Pebibit per metre (Code: E80)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁵⁰ bits (binary digits) per metre.
        /// </remarks>
        PebibitPerMetre,

        /// <summary>
        /// Pebibit per square metre (Code: E81)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁵⁰ bits (binary digits) per square metre.
        /// </remarks>
        PebibitPerSquareMetre,

        /// <summary>
        /// Pebibit per cubic metre (Code: E82)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁵⁰ bits (binary digits) per cubic metre.
        /// </remarks>
        PebibitPerCubicMetre,

        /// <summary>
        /// Terabit (Code: E83)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10¹² bits (binary digits).
        /// </remarks>
        Terabit,

        /// <summary>
        /// Terabit per second (Code: E84)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10¹² bits (binary digits) per second.
        /// </remarks>
        TerabitPerSecond,

        /// <summary>
        /// Tebibit per metre (Code: E85)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁴⁰ bits (binary digits) per metre.
        /// </remarks>
        TebibitPerMetre,

        /// <summary>
        /// Tebibit per cubic metre (Code: E86)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁴⁰ bits (binary digits) per cubic metre.
        /// </remarks>
        TebibitPerCubicMetre,

        /// <summary>
        /// Tebibit per square metre (Code: E87)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 2⁴⁰ bits (binary digits) per square metre.
        /// </remarks>
        TebibitPerSquareMetre,

        /// <summary>
        /// Bit per metre (Code: E88)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 1 bit (binary digit) per metre.
        /// </remarks>
        BitPerMetre,

        /// <summary>
        /// Bit per square metre (Code: E89)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 1 bit (binary digit) per square metre.
        /// </remarks>
        BitPerSquareMetre,

        /// <summary>
        /// Reciprocal centimetre (Code: E90)
        /// </summary>
        ReciprocalCentimetre,

        /// <summary>
        /// Reciprocal day (Code: E91)
        /// </summary>
        ReciprocalDay,

        /// <summary>
        /// Cubic decimetre per hour (Code: E92)
        /// </summary>
        CubicDecimetrePerHour,

        /// <summary>
        /// Kilogram per hour (Code: E93)
        /// </summary>
        KilogramPerHour,

        /// <summary>
        /// Kilomole per second (Code: E94)
        /// </summary>
        KilomolePerSecond,

        /// <summary>
        /// Mole per second (Code: E95)
        /// </summary>
        MolePerSecond,

        /// <summary>
        /// Degree per second (Code: E96)
        /// </summary>
        DegreePerSecond,

        /// <summary>
        /// Millimetre per degree Celcius metre (Code: E97)
        /// </summary>
        MillimetrePerDegreeCelciusMetre,

        /// <summary>
        /// Degree Celsius per kelvin (Code: E98)
        /// </summary>
        DegreeCelsiusPerKelvin,

        /// <summary>
        /// Hectopascal per bar (Code: E99)
        /// </summary>
        HectopascalPerBar,

        /// <summary>
        /// Each (Code: EA)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of items regarded as separate units.
        /// </remarks>
        Each,

        /// <summary>
        /// Electronic mail box (Code: EB)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of electronic mail boxes.
        /// </remarks>
        ElectronicMailBox,

        /// <summary>
        /// Equivalent gallon (Code: EQ)
        /// </summary>
        /// <remarks>
        /// A unit of volume defining the number of gallons of product produced from concentrate.
        /// </remarks>
        EquivalentGallon,

        /// <summary>
        /// Bit per cubic metre (Code: F01)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 1 bit (binary digit) per cubic metre.
        /// </remarks>
        BitPerCubicMetre,

        /// <summary>
        /// Kelvin per kelvin (Code: F02)
        /// </summary>
        KelvinPerKelvin,

        /// <summary>
        /// Kilopascal per bar (Code: F03)
        /// </summary>
        KilopascalPerBar,

        /// <summary>
        /// Millibar per bar (Code: F04)
        /// </summary>
        MillibarPerBar,

        /// <summary>
        /// Megapascal per bar (Code: F05)
        /// </summary>
        MegapascalPerBar,

        /// <summary>
        /// Poise per bar (Code: F06)
        /// </summary>
        PoisePerBar,

        /// <summary>
        /// Pascal per bar (Code: F07)
        /// </summary>
        PascalPerBar,

        /// <summary>
        /// Milliampere per inch (Code: F08)
        /// </summary>
        MilliamperePerInch,

        /// <summary>
        /// Kelvin per hour (Code: F10)
        /// </summary>
        KelvinPerHour,

        /// <summary>
        /// Kelvin per minute (Code: F11)
        /// </summary>
        KelvinPerMinute,

        /// <summary>
        /// Kelvin per second (Code: F12)
        /// </summary>
        KelvinPerSecond,

        /// <summary>
        /// Slug (Code: F13)
        /// </summary>
        /// <remarks>
        /// A unit of mass. One slug is the mass accelerated at 1 foot per second per second by a force of 1 pound.
        /// </remarks>
        Slug,

        /// <summary>
        /// Gram per kelvin (Code: F14)
        /// </summary>
        GramPerKelvin,

        /// <summary>
        /// Kilogram per kelvin (Code: F15)
        /// </summary>
        KilogramPerKelvin,

        /// <summary>
        /// Milligram per kelvin (Code: F16)
        /// </summary>
        MilligramPerKelvin,

        /// <summary>
        /// Pound-force per foot (Code: F17)
        /// </summary>
        PoundForcePerFoot,

        /// <summary>
        /// Kilogram square centimetre (Code: F18)
        /// </summary>
        KilogramSquareCentimetre,

        /// <summary>
        /// Kilogram square millimetre (Code: F19)
        /// </summary>
        KilogramSquareMillimetre,

        /// <summary>
        /// Pound inch squared (Code: F20)
        /// </summary>
        PoundInchSquared,

        /// <summary>
        /// Pound-force inch (Code: F21)
        /// </summary>
        PoundForceInch,

        /// <summary>
        /// Pound-force foot per ampere (Code: F22)
        /// </summary>
        PoundForceFootPerAmpere,

        /// <summary>
        /// Gram per cubic decimetre (Code: F23)
        /// </summary>
        GramPerCubicDecimetre,

        /// <summary>
        /// Kilogram per kilomol (Code: F24)
        /// </summary>
        KilogramPerKilomol,

        /// <summary>
        /// Gram per hertz (Code: F25)
        /// </summary>
        GramPerHertz,

        /// <summary>
        /// Gram per day (Code: F26)
        /// </summary>
        GramPerDay,

        /// <summary>
        /// Gram per hour (Code: F27)
        /// </summary>
        GramPerHour,

        /// <summary>
        /// Gram per minute (Code: F28)
        /// </summary>
        GramPerMinute,

        /// <summary>
        /// Gram per second (Code: F29)
        /// </summary>
        GramPerSecond,

        /// <summary>
        /// Kilogram per day (Code: F30)
        /// </summary>
        KilogramPerDay,

        /// <summary>
        /// Kilogram per minute (Code: F31)
        /// </summary>
        KilogramPerMinute,

        /// <summary>
        /// Milligram per day (Code: F32)
        /// </summary>
        MilligramPerDay,

        /// <summary>
        /// Milligram per minute (Code: F33)
        /// </summary>
        MilligramPerMinute,

        /// <summary>
        /// Milligram per second (Code: F34)
        /// </summary>
        MilligramPerSecond,

        /// <summary>
        /// Gram per day kelvin (Code: F35)
        /// </summary>
        GramPerDayKelvin,

        /// <summary>
        /// Gram per hour kelvin (Code: F36)
        /// </summary>
        GramPerHourKelvin,

        /// <summary>
        /// Gram per minute kelvin (Code: F37)
        /// </summary>
        GramPerMinuteKelvin,

        /// <summary>
        /// Gram per second kelvin (Code: F38)
        /// </summary>
        GramPerSecondKelvin,

        /// <summary>
        /// Kilogram per day kelvin (Code: F39)
        /// </summary>
        KilogramPerDayKelvin,

        /// <summary>
        /// Kilogram per hour kelvin (Code: F40)
        /// </summary>
        KilogramPerHourKelvin,

        /// <summary>
        /// Kilogram per minute kelvin (Code: F41)
        /// </summary>
        KilogramPerMinuteKelvin,

        /// <summary>
        /// Kilogram per second kelvin (Code: F42)
        /// </summary>
        KilogramPerSecondKelvin,

        /// <summary>
        /// Milligram per day kelvin (Code: F43)
        /// </summary>
        MilligramPerDayKelvin,

        /// <summary>
        /// Milligram per hour kelvin (Code: F44)
        /// </summary>
        MilligramPerHourKelvin,

        /// <summary>
        /// Milligram per minute kelvin (Code: F45)
        /// </summary>
        MilligramPerMinuteKelvin,

        /// <summary>
        /// Milligram per second kelvin (Code: F46)
        /// </summary>
        MilligramPerSecondKelvin,

        /// <summary>
        /// Newton per millimetre (Code: F47)
        /// </summary>
        NewtonPerMillimetre,

        /// <summary>
        /// Pound-force per inch (Code: F48)
        /// </summary>
        PoundForcePerInch,

        /// <summary>
        /// Rod [unit of distance] (Code: F49)
        /// </summary>
        /// <remarks>
        /// A unit of distance equal to 5.5 yards (16 feet 6 inches).
        /// </remarks>
        Rod_UnitOfDistance,

        /// <summary>
        /// Micrometre per kelvin (Code: F50)
        /// </summary>
        MicrometrePerKelvin,

        /// <summary>
        /// Centimetre per kelvin (Code: F51)
        /// </summary>
        CentimetrePerKelvin,

        /// <summary>
        /// Metre per kelvin (Code: F52)
        /// </summary>
        MetrePerKelvin,

        /// <summary>
        /// Millimetre per kelvin (Code: F53)
        /// </summary>
        MillimetrePerKelvin,

        /// <summary>
        /// Milliohm per metre (Code: F54)
        /// </summary>
        MilliohmPerMetre,

        /// <summary>
        /// Ohm per mile (statute mile) (Code: F55)
        /// </summary>
        OhmPerMile_statuteMile,

        /// <summary>
        /// Ohm per kilometre (Code: F56)
        /// </summary>
        OhmPerKilometre,

        /// <summary>
        /// Milliampere per pound-force per square inch (Code: F57)
        /// </summary>
        MilliamperePerPoundForcePerSquareInch,

        /// <summary>
        /// Reciprocal bar (Code: F58)
        /// </summary>
        ReciprocalBar,

        /// <summary>
        /// Milliampere per bar (Code: F59)
        /// </summary>
        MilliamperePerBar,

        /// <summary>
        /// Degree Celsius per bar (Code: F60)
        /// </summary>
        DegreeCelsiusPerBar,

        /// <summary>
        /// Kelvin per bar (Code: F61)
        /// </summary>
        KelvinPerBar,

        /// <summary>
        /// Gram per day bar (Code: F62)
        /// </summary>
        GramPerDayBar,

        /// <summary>
        /// Gram per hour bar (Code: F63)
        /// </summary>
        GramPerHourBar,

        /// <summary>
        /// Gram per minute bar (Code: F64)
        /// </summary>
        GramPerMinuteBar,

        /// <summary>
        /// Gram per second bar (Code: F65)
        /// </summary>
        GramPerSecondBar,

        /// <summary>
        /// Kilogram per day bar (Code: F66)
        /// </summary>
        KilogramPerDayBar,

        /// <summary>
        /// Kilogram per hour bar (Code: F67)
        /// </summary>
        KilogramPerHourBar,

        /// <summary>
        /// Kilogram per minute bar (Code: F68)
        /// </summary>
        KilogramPerMinuteBar,

        /// <summary>
        /// Kilogram per second bar (Code: F69)
        /// </summary>
        KilogramPerSecondBar,

        /// <summary>
        /// Milligram per day bar (Code: F70)
        /// </summary>
        MilligramPerDayBar,

        /// <summary>
        /// Milligram per hour bar (Code: F71)
        /// </summary>
        MilligramPerHourBar,

        /// <summary>
        /// Milligram per minute bar (Code: F72)
        /// </summary>
        MilligramPerMinuteBar,

        /// <summary>
        /// Milligram per second bar (Code: F73)
        /// </summary>
        MilligramPerSecondBar,

        /// <summary>
        /// Gram per bar (Code: F74)
        /// </summary>
        GramPerBar,

        /// <summary>
        /// Milligram per bar (Code: F75)
        /// </summary>
        MilligramPerBar,

        /// <summary>
        /// Milliampere per millimetre (Code: F76)
        /// </summary>
        MilliamperePerMillimetre,

        /// <summary>
        /// Pascal second per kelvin (Code: F77)
        /// </summary>
        PascalSecondPerKelvin,

        /// <summary>
        /// Inch of water (Code: F78)
        /// </summary>
        InchOfWater,

        /// <summary>
        /// Inch of mercury (Code: F79)
        /// </summary>
        InchOfMercury,

        /// <summary>
        /// Water horse power (Code: F80)
        /// </summary>
        /// <remarks>
        /// A unit of power defining the amount of power required to move a given volume of water against acceleration of gravity to a specified elevation (pressure head).
        /// </remarks>
        WaterHorsePower,

        /// <summary>
        /// Bar per kelvin (Code: F81)
        /// </summary>
        BarPerKelvin,

        /// <summary>
        /// Hectopascal per kelvin (Code: F82)
        /// </summary>
        HectopascalPerKelvin,

        /// <summary>
        /// Kilopascal per kelvin (Code: F83)
        /// </summary>
        KilopascalPerKelvin,

        /// <summary>
        /// Millibar per kelvin (Code: F84)
        /// </summary>
        MillibarPerKelvin,

        /// <summary>
        /// Megapascal per kelvin (Code: F85)
        /// </summary>
        MegapascalPerKelvin,

        /// <summary>
        /// Poise per kelvin (Code: F86)
        /// </summary>
        PoisePerKelvin,

        /// <summary>
        /// Volt per litre minute (Code: F87)
        /// </summary>
        VoltPerLitreMinute,

        /// <summary>
        /// Newton centimetre (Code: F88)
        /// </summary>
        NewtonCentimetre,

        /// <summary>
        /// Newton metre per degree (Code: F89)
        /// </summary>
        NewtonMetrePerDegree,

        /// <summary>
        /// Newton metre per ampere (Code: F90)
        /// </summary>
        NewtonMetrePerAmpere,

        /// <summary>
        /// Bar litre per second (Code: F91)
        /// </summary>
        BarLitrePerSecond,

        /// <summary>
        /// Bar cubic metre per second (Code: F92)
        /// </summary>
        BarCubicMetrePerSecond,

        /// <summary>
        /// Hectopascal litre per second (Code: F93)
        /// </summary>
        HectopascalLitrePerSecond,

        /// <summary>
        /// Hectopascal cubic metre per second (Code: F94)
        /// </summary>
        HectopascalCubicMetrePerSecond,

        /// <summary>
        /// Millibar litre per second (Code: F95)
        /// </summary>
        MillibarLitrePerSecond,

        /// <summary>
        /// Millibar cubic metre per second (Code: F96)
        /// </summary>
        MillibarCubicMetrePerSecond,

        /// <summary>
        /// Megapascal litre per second (Code: F97)
        /// </summary>
        MegapascalLitrePerSecond,

        /// <summary>
        /// Megapascal cubic metre per second (Code: F98)
        /// </summary>
        MegapascalCubicMetrePerSecond,

        /// <summary>
        /// Pascal litre per second (Code: F99)
        /// </summary>
        PascalLitrePerSecond,

        /// <summary>
        /// Degree Fahrenheit (Code: FAH)
        /// </summary>
        /// <remarks>
        /// Refer ISO 80000-5 (Quantities and units — Part 5: Thermodynamics)
        /// </remarks>
        DegreeFahrenheit,

        /// <summary>
        /// Farad (Code: FAR)
        /// </summary>
        Farad,

        /// <summary>
        /// Fibre metre (Code: FBM)
        /// </summary>
        /// <remarks>
        /// A unit of length defining the number of metres of individual fibre.
        /// </remarks>
        FibreMetre,

        /// <summary>
        /// Thousand cubic foot (Code: FC)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one thousand cubic foot.
        /// </remarks>
        ThousandCubicFoot,

        /// <summary>
        /// Hundred cubic metre (Code: FF)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one hundred cubic metres.
        /// </remarks>
        HundredCubicMetre,

        /// <summary>
        /// Micromole (Code: FH)
        /// </summary>
        Micromole,

        /// <summary>
        /// Failures in time (Code: FIT)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of failures that can be expected over a specified time interval. Failure rates of semiconductor components are often specified as FIT (failures in time unit) where 1 FIT = 10⁻⁹ /h.
        /// </remarks>
        FailuresInTime,

        /// <summary>
        /// Flake ton (Code: FL)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of tons of a flaked substance (flake: a small flattish fragment).
        /// </remarks>
        FlakeTon,

        /// <summary>
        /// Formazin nephelometric unit (Code: FNU)
        /// </summary>
        FormazinNephelometricUnit,

        /// <summary>
        /// Foot (Code: FOT)
        /// </summary>
        Foot,

        /// <summary>
        /// Pound per square foot (Code: FP)
        /// </summary>
        PoundPerSquareFoot,

        /// <summary>
        /// Foot per minute (Code: FR)
        /// </summary>
        FootPerMinute,

        /// <summary>
        /// Foot per second (Code: FS)
        /// </summary>
        FootPerSecond,

        /// <summary>
        /// Square foot (Code: FTK)
        /// </summary>
        SquareFoot,

        /// <summary>
        /// Cubic foot (Code: FTQ)
        /// </summary>
        CubicFoot,

        /// <summary>
        /// Pascal cubic metre per second (Code: G01)
        /// </summary>
        PascalCubicMetrePerSecond,

        /// <summary>
        /// Centimetre per bar (Code: G04)
        /// </summary>
        CentimetrePerBar,

        /// <summary>
        /// Metre per bar (Code: G05)
        /// </summary>
        MetrePerBar,

        /// <summary>
        /// Millimetre per bar (Code: G06)
        /// </summary>
        MillimetrePerBar,

        /// <summary>
        /// Square inch per second (Code: G08)
        /// </summary>
        SquareInchPerSecond,

        /// <summary>
        /// Square metre per second kelvin (Code: G09)
        /// </summary>
        SquareMetrePerSecondKelvin,

        /// <summary>
        /// Stokes per kelvin (Code: G10)
        /// </summary>
        StokesPerKelvin,

        /// <summary>
        /// Gram per cubic centimetre bar (Code: G11)
        /// </summary>
        GramPerCubicCentimetreBar,

        /// <summary>
        /// Gram per cubic decimetre bar (Code: G12)
        /// </summary>
        GramPerCubicDecimetreBar,

        /// <summary>
        /// Gram per litre bar (Code: G13)
        /// </summary>
        GramPerLitreBar,

        /// <summary>
        /// Gram per cubic metre bar (Code: G14)
        /// </summary>
        GramPerCubicMetreBar,

        /// <summary>
        /// Gram per millilitre bar (Code: G15)
        /// </summary>
        GramPerMillilitreBar,

        /// <summary>
        /// Kilogram per cubic centimetre bar (Code: G16)
        /// </summary>
        KilogramPerCubicCentimetreBar,

        /// <summary>
        /// Kilogram per litre bar (Code: G17)
        /// </summary>
        KilogramPerLitreBar,

        /// <summary>
        /// Kilogram per cubic metre bar (Code: G18)
        /// </summary>
        KilogramPerCubicMetreBar,

        /// <summary>
        /// Newton metre per kilogram (Code: G19)
        /// </summary>
        NewtonMetrePerKilogram,

        /// <summary>
        /// US gallon per minute (Code: G2)
        /// </summary>
        USGallonPerMinute,

        /// <summary>
        /// Pound-force foot per pound (Code: G20)
        /// </summary>
        PoundForceFootPerPound,

        /// <summary>
        /// Cup [unit of volume] (Code: G21)
        /// </summary>
        Cup_UnitOfVolume,

        /// <summary>
        /// Peck (Code: G23)
        /// </summary>
        Peck,

        /// <summary>
        /// Tablespoon (US) (Code: G24)
        /// </summary>
        Tablespoon_US,

        /// <summary>
        /// Teaspoon (US) (Code: G25)
        /// </summary>
        Teaspoon_US,

        /// <summary>
        /// Stere (Code: G26)
        /// </summary>
        Stere,

        /// <summary>
        /// Cubic centimetre per kelvin (Code: G27)
        /// </summary>
        CubicCentimetrePerKelvin,

        /// <summary>
        /// Litre per kelvin (Code: G28)
        /// </summary>
        LitrePerKelvin,

        /// <summary>
        /// Cubic metre per kelvin (Code: G29)
        /// </summary>
        CubicMetrePerKelvin,

        /// <summary>
        /// Imperial gallon per minute (Code: G3)
        /// </summary>
        ImperialGallonPerMinute,

        /// <summary>
        /// Millilitre per kelvin (Code: G30)
        /// </summary>
        MillilitrePerKelvin,

        /// <summary>
        /// Kilogram per cubic centimetre (Code: G31)
        /// </summary>
        KilogramPerCubicCentimetre,

        /// <summary>
        /// Ounce (avoirdupois) per cubic yard (Code: G32)
        /// </summary>
        Ounce_avoirdupois_PerCubicYard,

        /// <summary>
        /// Gram per cubic centimetre kelvin (Code: G33)
        /// </summary>
        GramPerCubicCentimetreKelvin,

        /// <summary>
        /// Gram per cubic decimetre kelvin (Code: G34)
        /// </summary>
        GramPerCubicDecimetreKelvin,

        /// <summary>
        /// Gram per litre kelvin (Code: G35)
        /// </summary>
        GramPerLitreKelvin,

        /// <summary>
        /// Gram per cubic metre kelvin (Code: G36)
        /// </summary>
        GramPerCubicMetreKelvin,

        /// <summary>
        /// Gram per millilitre kelvin (Code: G37)
        /// </summary>
        GramPerMillilitreKelvin,

        /// <summary>
        /// Kilogram per cubic centimetre kelvin (Code: G38)
        /// </summary>
        KilogramPerCubicCentimetreKelvin,

        /// <summary>
        /// Kilogram per litre kelvin (Code: G39)
        /// </summary>
        KilogramPerLitreKelvin,

        /// <summary>
        /// Kilogram per cubic metre kelvin (Code: G40)
        /// </summary>
        KilogramPerCubicMetreKelvin,

        /// <summary>
        /// Square metre per second bar (Code: G41)
        /// </summary>
        SquareMetrePerSecondBar,

        /// <summary>
        /// Microsiemens per centimetre (Code: G42)
        /// </summary>
        MicrosiemensPerCentimetre,

        /// <summary>
        /// Microsiemens per metre (Code: G43)
        /// </summary>
        MicrosiemensPerMetre,

        /// <summary>
        /// Nanosiemens per centimetre (Code: G44)
        /// </summary>
        NanosiemensPerCentimetre,

        /// <summary>
        /// Nanosiemens per metre (Code: G45)
        /// </summary>
        NanosiemensPerMetre,

        /// <summary>
        /// Stokes per bar (Code: G46)
        /// </summary>
        StokesPerBar,

        /// <summary>
        /// Cubic centimetre per day (Code: G47)
        /// </summary>
        CubicCentimetrePerDay,

        /// <summary>
        /// Cubic centimetre per hour (Code: G48)
        /// </summary>
        CubicCentimetrePerHour,

        /// <summary>
        /// Cubic centimetre per minute (Code: G49)
        /// </summary>
        CubicCentimetrePerMinute,

        /// <summary>
        /// Gallon (US) per hour (Code: G50)
        /// </summary>
        Gallon_US_PerHour,

        /// <summary>
        /// Litre per second (Code: G51)
        /// </summary>
        LitrePerSecond,

        /// <summary>
        /// Cubic metre per day (Code: G52)
        /// </summary>
        CubicMetrePerDay,

        /// <summary>
        /// Cubic metre per minute (Code: G53)
        /// </summary>
        CubicMetrePerMinute,

        /// <summary>
        /// Millilitre per day (Code: G54)
        /// </summary>
        MillilitrePerDay,

        /// <summary>
        /// Millilitre per hour (Code: G55)
        /// </summary>
        MillilitrePerHour,

        /// <summary>
        /// Cubic inch per hour (Code: G56)
        /// </summary>
        CubicInchPerHour,

        /// <summary>
        /// Cubic inch per minute (Code: G57)
        /// </summary>
        CubicInchPerMinute,

        /// <summary>
        /// Cubic inch per second (Code: G58)
        /// </summary>
        CubicInchPerSecond,

        /// <summary>
        /// Milliampere per litre minute (Code: G59)
        /// </summary>
        MilliamperePerLitreMinute,

        /// <summary>
        /// Volt per bar (Code: G60)
        /// </summary>
        VoltPerBar,

        /// <summary>
        /// Cubic centimetre per day kelvin (Code: G61)
        /// </summary>
        CubicCentimetrePerDayKelvin,

        /// <summary>
        /// Cubic centimetre per hour kelvin (Code: G62)
        /// </summary>
        CubicCentimetrePerHourKelvin,

        /// <summary>
        /// Cubic centimetre per minute kelvin (Code: G63)
        /// </summary>
        CubicCentimetrePerMinuteKelvin,

        /// <summary>
        /// Cubic centimetre per second kelvin (Code: G64)
        /// </summary>
        CubicCentimetrePerSecondKelvin,

        /// <summary>
        /// Litre per day kelvin (Code: G65)
        /// </summary>
        LitrePerDayKelvin,

        /// <summary>
        /// Litre per hour kelvin (Code: G66)
        /// </summary>
        LitrePerHourKelvin,

        /// <summary>
        /// Litre per minute kelvin (Code: G67)
        /// </summary>
        LitrePerMinuteKelvin,

        /// <summary>
        /// Litre per second kelvin (Code: G68)
        /// </summary>
        LitrePerSecondKelvin,

        /// <summary>
        /// Cubic metre per day kelvin (Code: G69)
        /// </summary>
        CubicMetrePerDayKelvin,

        /// <summary>
        /// Cubic metre per hour kelvin (Code: G70)
        /// </summary>
        CubicMetrePerHourKelvin,

        /// <summary>
        /// Cubic metre per minute kelvin (Code: G71)
        /// </summary>
        CubicMetrePerMinuteKelvin,

        /// <summary>
        /// Cubic metre per second kelvin (Code: G72)
        /// </summary>
        CubicMetrePerSecondKelvin,

        /// <summary>
        /// Millilitre per day kelvin (Code: G73)
        /// </summary>
        MillilitrePerDayKelvin,

        /// <summary>
        /// Millilitre per hour kelvin (Code: G74)
        /// </summary>
        MillilitrePerHourKelvin,

        /// <summary>
        /// Millilitre per minute kelvin (Code: G75)
        /// </summary>
        MillilitrePerMinuteKelvin,

        /// <summary>
        /// Millilitre per second kelvin (Code: G76)
        /// </summary>
        MillilitrePerSecondKelvin,

        /// <summary>
        /// Millimetre to the fourth power (Code: G77)
        /// </summary>
        MillimetreToTheFourthPower,

        /// <summary>
        /// Cubic centimetre per day bar (Code: G78)
        /// </summary>
        CubicCentimetrePerDayBar,

        /// <summary>
        /// Cubic centimetre per hour bar (Code: G79)
        /// </summary>
        CubicCentimetrePerHourBar,

        /// <summary>
        /// Cubic centimetre per minute bar (Code: G80)
        /// </summary>
        CubicCentimetrePerMinuteBar,

        /// <summary>
        /// Cubic centimetre per second bar (Code: G81)
        /// </summary>
        CubicCentimetrePerSecondBar,

        /// <summary>
        /// Litre per day bar (Code: G82)
        /// </summary>
        LitrePerDayBar,

        /// <summary>
        /// Litre per hour bar (Code: G83)
        /// </summary>
        LitrePerHourBar,

        /// <summary>
        /// Litre per minute bar (Code: G84)
        /// </summary>
        LitrePerMinuteBar,

        /// <summary>
        /// Litre per second bar (Code: G85)
        /// </summary>
        LitrePerSecondBar,

        /// <summary>
        /// Cubic metre per day bar (Code: G86)
        /// </summary>
        CubicMetrePerDayBar,

        /// <summary>
        /// Cubic metre per hour bar (Code: G87)
        /// </summary>
        CubicMetrePerHourBar,

        /// <summary>
        /// Cubic metre per minute bar (Code: G88)
        /// </summary>
        CubicMetrePerMinuteBar,

        /// <summary>
        /// Cubic metre per second bar (Code: G89)
        /// </summary>
        CubicMetrePerSecondBar,

        /// <summary>
        /// Millilitre per day bar (Code: G90)
        /// </summary>
        MillilitrePerDayBar,

        /// <summary>
        /// Millilitre per hour bar (Code: G91)
        /// </summary>
        MillilitrePerHourBar,

        /// <summary>
        /// Millilitre per minute bar (Code: G92)
        /// </summary>
        MillilitrePerMinuteBar,

        /// <summary>
        /// Millilitre per second bar (Code: G93)
        /// </summary>
        MillilitrePerSecondBar,

        /// <summary>
        /// Cubic centimetre per bar (Code: G94)
        /// </summary>
        CubicCentimetrePerBar,

        /// <summary>
        /// Litre per bar (Code: G95)
        /// </summary>
        LitrePerBar,

        /// <summary>
        /// Cubic metre per bar (Code: G96)
        /// </summary>
        CubicMetrePerBar,

        /// <summary>
        /// Millilitre per bar (Code: G97)
        /// </summary>
        MillilitrePerBar,

        /// <summary>
        /// Microhenry per kiloohm (Code: G98)
        /// </summary>
        MicrohenryPerKiloohm,

        /// <summary>
        /// Microhenry per ohm (Code: G99)
        /// </summary>
        MicrohenryPerOhm,

        /// <summary>
        /// Gallon (US) per day (Code: GB)
        /// </summary>
        Gallon_US_PerDay,

        /// <summary>
        /// Gigabecquerel (Code: GBQ)
        /// </summary>
        Gigabecquerel,

        /// <summary>
        /// Gram, dry weight (Code: GDW)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of grams of a product, disregarding the water content of the product.
        /// </remarks>
        Gram_DryWeight,

        /// <summary>
        /// Pound per gallon (US) (Code: GE)
        /// </summary>
        PoundPerGallon_US,

        /// <summary>
        /// Gram per metre (gram per 100 centimetres) (Code: GF)
        /// </summary>
        GramPerMetre_gramPer100Centimetres,

        /// <summary>
        /// Gram of fissile isotope (Code: GFI)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of grams of a fissile isotope (fissile isotope: an isotope whose nucleus is able to be split when irradiated with low energy neutrons).
        /// </remarks>
        GramOfFissileIsotope,

        /// <summary>
        /// Great gross (Code: GGR)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of units in multiples of 1728 (12 x 12 x 12).
        /// </remarks>
        GreatGross,

        /// <summary>
        /// Gill (US) (Code: GIA)
        /// </summary>
        Gill_US,

        /// <summary>
        /// Gram, including container (Code: GIC)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of grams of a product, including its container.
        /// </remarks>
        Gram_IncludingContainer,

        /// <summary>
        /// Gill (UK) (Code: GII)
        /// </summary>
        Gill_UK,

        /// <summary>
        /// Gram, including inner packaging (Code: GIP)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of grams of a product, including its inner packaging materials.
        /// </remarks>
        Gram_IncludingInnerPackaging,

        /// <summary>
        /// Gram per millilitre (Code: GJ)
        /// </summary>
        GramPerMillilitre,

        /// <summary>
        /// Gram per litre (Code: GL)
        /// </summary>
        GramPerLitre,

        /// <summary>
        /// Dry gallon (US) (Code: GLD)
        /// </summary>
        DryGallon_US,

        /// <summary>
        /// Gallon (UK) (Code: GLI)
        /// </summary>
        Gallon_UK,

        /// <summary>
        /// Gallon (US) (Code: GLL)
        /// </summary>
        Gallon_US,

        /// <summary>
        /// Gram per square metre (Code: GM)
        /// </summary>
        GramPerSquareMetre,

        /// <summary>
        /// Milligram per square metre (Code: GO)
        /// </summary>
        MilligramPerSquareMetre,

        /// <summary>
        /// Milligram per cubic metre (Code: GP)
        /// </summary>
        MilligramPerCubicMetre,

        /// <summary>
        /// Microgram per cubic metre (Code: GQ)
        /// </summary>
        MicrogramPerCubicMetre,

        /// <summary>
        /// Gram (Code: GRM)
        /// </summary>
        Gram,

        /// <summary>
        /// Grain (Code: GRN)
        /// </summary>
        Grain,

        /// <summary>
        /// Gross (Code: GRO)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of units in multiples of 144 (12 x 12).
        /// </remarks>
        Gross,

        /// <summary>
        /// Gigajoule (Code: GV)
        /// </summary>
        Gigajoule,

        /// <summary>
        /// Gigawatt hour (Code: GWH)
        /// </summary>
        GigawattHour,

        /// <summary>
        /// Henry per kiloohm (Code: H03)
        /// </summary>
        HenryPerKiloohm,

        /// <summary>
        /// Henry per ohm (Code: H04)
        /// </summary>
        HenryPerOhm,

        /// <summary>
        /// Millihenry per kiloohm (Code: H05)
        /// </summary>
        MillihenryPerKiloohm,

        /// <summary>
        /// Millihenry per ohm (Code: H06)
        /// </summary>
        MillihenryPerOhm,

        /// <summary>
        /// Pascal second per bar (Code: H07)
        /// </summary>
        PascalSecondPerBar,

        /// <summary>
        /// Microbecquerel (Code: H08)
        /// </summary>
        Microbecquerel,

        /// <summary>
        /// Reciprocal year (Code: H09)
        /// </summary>
        ReciprocalYear,

        /// <summary>
        /// Reciprocal hour (Code: H10)
        /// </summary>
        ReciprocalHour,

        /// <summary>
        /// Reciprocal month (Code: H11)
        /// </summary>
        ReciprocalMonth,

        /// <summary>
        /// Degree Celsius per hour (Code: H12)
        /// </summary>
        DegreeCelsiusPerHour,

        /// <summary>
        /// Degree Celsius per minute (Code: H13)
        /// </summary>
        DegreeCelsiusPerMinute,

        /// <summary>
        /// Degree Celsius per second (Code: H14)
        /// </summary>
        DegreeCelsiusPerSecond,

        /// <summary>
        /// Square centimetre per gram (Code: H15)
        /// </summary>
        SquareCentimetrePerGram,

        /// <summary>
        /// Square decametre (Code: H16)
        /// </summary>
        /// <remarks>
        /// Synonym: are
        /// </remarks>
        SquareDecametre,

        /// <summary>
        /// Square hectometre (Code: H18)
        /// </summary>
        /// <remarks>
        /// Synonym: hectare
        /// </remarks>
        SquareHectometre,

        /// <summary>
        /// Cubic hectometre (Code: H19)
        /// </summary>
        CubicHectometre,

        /// <summary>
        /// Cubic kilometre (Code: H20)
        /// </summary>
        CubicKilometre,

        /// <summary>
        /// Blank (Code: H21)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of blanks.
        /// </remarks>
        Blank,

        /// <summary>
        /// Volt square inch per pound-force (Code: H22)
        /// </summary>
        VoltSquareInchPerPoundForce,

        /// <summary>
        /// Volt per inch (Code: H23)
        /// </summary>
        VoltPerInch,

        /// <summary>
        /// Volt per microsecond (Code: H24)
        /// </summary>
        VoltPerMicrosecond,

        /// <summary>
        /// Percent per kelvin (Code: H25)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to the SI base unit Kelvin.
        /// </remarks>
        PercentPerKelvin,

        /// <summary>
        /// Ohm per metre (Code: H26)
        /// </summary>
        OhmPerMetre,

        /// <summary>
        /// Degree per metre (Code: H27)
        /// </summary>
        DegreePerMetre,

        /// <summary>
        /// Microfarad per kilometre (Code: H28)
        /// </summary>
        MicrofaradPerKilometre,

        /// <summary>
        /// Microgram per litre (Code: H29)
        /// </summary>
        MicrogramPerLitre,

        /// <summary>
        /// Square micrometre (square micron) (Code: H30)
        /// </summary>
        SquareMicrometre_squareMicron,

        /// <summary>
        /// Ampere per kilogram (Code: H31)
        /// </summary>
        AmperePerKilogram,

        /// <summary>
        /// Ampere squared second (Code: H32)
        /// </summary>
        AmpereSquaredSecond,

        /// <summary>
        /// Farad per kilometre (Code: H33)
        /// </summary>
        FaradPerKilometre,

        /// <summary>
        /// Hertz metre (Code: H34)
        /// </summary>
        HertzMetre,

        /// <summary>
        /// Kelvin metre per watt (Code: H35)
        /// </summary>
        KelvinMetrePerWatt,

        /// <summary>
        /// Megaohm per kilometre (Code: H36)
        /// </summary>
        MegaohmPerKilometre,

        /// <summary>
        /// Megaohm per metre (Code: H37)
        /// </summary>
        MegaohmPerMetre,

        /// <summary>
        /// Megaampere (Code: H38)
        /// </summary>
        Megaampere,

        /// <summary>
        /// Megahertz kilometre (Code: H39)
        /// </summary>
        MegahertzKilometre,

        /// <summary>
        /// Newton per ampere (Code: H40)
        /// </summary>
        NewtonPerAmpere,

        /// <summary>
        /// Newton metre watt to the power minus 0,5 (Code: H41)
        /// </summary>
        NewtonMetreWattToThePowerMinus0_5,

        /// <summary>
        /// Pascal per metre (Code: H42)
        /// </summary>
        PascalPerMetre,

        /// <summary>
        /// Siemens per centimetre (Code: H43)
        /// </summary>
        SiemensPerCentimetre,

        /// <summary>
        /// Teraohm (Code: H44)
        /// </summary>
        Teraohm,

        /// <summary>
        /// Volt second per metre (Code: H45)
        /// </summary>
        VoltSecondPerMetre,

        /// <summary>
        /// Volt per second (Code: H46)
        /// </summary>
        VoltPerSecond,

        /// <summary>
        /// Watt per cubic metre (Code: H47)
        /// </summary>
        WattPerCubicMetre,

        /// <summary>
        /// Attofarad (Code: H48)
        /// </summary>
        Attofarad,

        /// <summary>
        /// Centimetre per hour (Code: H49)
        /// </summary>
        CentimetrePerHour,

        /// <summary>
        /// Reciprocal cubic centimetre (Code: H50)
        /// </summary>
        ReciprocalCubicCentimetre,

        /// <summary>
        /// Decibel per kilometre (Code: H51)
        /// </summary>
        DecibelPerKilometre,

        /// <summary>
        /// Decibel per metre (Code: H52)
        /// </summary>
        DecibelPerMetre,

        /// <summary>
        /// Kilogram per bar (Code: H53)
        /// </summary>
        KilogramPerBar,

        /// <summary>
        /// Kilogram per cubic decimetre kelvin (Code: H54)
        /// </summary>
        KilogramPerCubicDecimetreKelvin,

        /// <summary>
        /// Kilogram per cubic decimetre bar (Code: H55)
        /// </summary>
        KilogramPerCubicDecimetreBar,

        /// <summary>
        /// Kilogram per square metre second (Code: H56)
        /// </summary>
        KilogramPerSquareMetreSecond,

        /// <summary>
        /// Inch per two pi radiant (Code: H57)
        /// </summary>
        InchPerTwoPiRadiant,

        /// <summary>
        /// Metre per volt second (Code: H58)
        /// </summary>
        MetrePerVoltSecond,

        /// <summary>
        /// Square metre per newton (Code: H59)
        /// </summary>
        SquareMetrePerNewton,

        /// <summary>
        /// Cubic metre per cubic metre (Code: H60)
        /// </summary>
        CubicMetrePerCubicMetre,

        /// <summary>
        /// Millisiemens per centimetre (Code: H61)
        /// </summary>
        MillisiemensPerCentimetre,

        /// <summary>
        /// Millivolt per minute (Code: H62)
        /// </summary>
        MillivoltPerMinute,

        /// <summary>
        /// Milligram per square centimetre (Code: H63)
        /// </summary>
        MilligramPerSquareCentimetre,

        /// <summary>
        /// Milligram per gram (Code: H64)
        /// </summary>
        MilligramPerGram,

        /// <summary>
        /// Millilitre per cubic metre (Code: H65)
        /// </summary>
        MillilitrePerCubicMetre,

        /// <summary>
        /// Millimetre per year (Code: H66)
        /// </summary>
        MillimetrePerYear,

        /// <summary>
        /// Millimetre per hour (Code: H67)
        /// </summary>
        MillimetrePerHour,

        /// <summary>
        /// Millimole per gram (Code: H68)
        /// </summary>
        MillimolePerGram,

        /// <summary>
        /// Picopascal per kilometre (Code: H69)
        /// </summary>
        PicopascalPerKilometre,

        /// <summary>
        /// Picosecond (Code: H70)
        /// </summary>
        Picosecond,

        /// <summary>
        /// Percent per month (Code: H71)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to a month.
        /// </remarks>
        PercentPerMonth,

        /// <summary>
        /// Percent per hectobar (Code: H72)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to 100-fold of the unit bar.
        /// </remarks>
        PercentPerHectobar,

        /// <summary>
        /// Percent per decakelvin (Code: H73)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to 10-fold of the SI base unit Kelvin.
        /// </remarks>
        PercentPerDecakelvin,

        /// <summary>
        /// Watt per metre (Code: H74)
        /// </summary>
        WattPerMetre,

        /// <summary>
        /// Decapascal (Code: H75)
        /// </summary>
        Decapascal,

        /// <summary>
        /// Gram per millimetre (Code: H76)
        /// </summary>
        GramPerMillimetre,

        /// <summary>
        /// Module width (Code: H77)
        /// </summary>
        /// <remarks>
        /// A unit of measure used to describe the breadth of electronic assemblies as an installation standard or mounting dimension.
        /// </remarks>
        ModuleWidth,

        /// <summary>
        /// French gauge (Code: H79)
        /// </summary>
        /// <remarks>
        /// A unit of distance used for measuring the diameter of small tubes such as urological instruments and catheters. Synonym: French, Charrière, Charrière gauge
        /// </remarks>
        FrenchGauge,

        /// <summary>
        /// Rack unit (Code: H80)
        /// </summary>
        /// <remarks>
        /// A unit of measure used to describe the height in rack units of equipment intended for mounting in a 19-inch rack or a 23-inch rack. One rack unit is 1.75 inches (44.45 mm) high.
        /// </remarks>
        RackUnit,

        /// <summary>
        /// Millimetre per minute (Code: H81)
        /// </summary>
        MillimetrePerMinute,

        /// <summary>
        /// Big point (Code: H82)
        /// </summary>
        /// <remarks>
        /// A unit of length defining the number of big points (big point: Adobe software(US) defines the big point to be exactly 1/72 inch (0.013 888 9 inch or 0.352 777 8 millimeters))
        /// </remarks>
        BigPoint,

        /// <summary>
        /// Litre per kilogram (Code: H83)
        /// </summary>
        LitrePerKilogram,

        /// <summary>
        /// Gram millimetre (Code: H84)
        /// </summary>
        GramMillimetre,

        /// <summary>
        /// Reciprocal week (Code: H85)
        /// </summary>
        ReciprocalWeek,

        /// <summary>
        /// Piece (Code: H87)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of pieces (piece: a single item, article or exemplar).
        /// </remarks>
        Piece_UnitOfCount,

        /// <summary>
        /// Megaohm kilometre (Code: H88)
        /// </summary>
        MegaohmKilometre,

        /// <summary>
        /// Percent per ohm (Code: H89)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to the SI derived unit ohm.
        /// </remarks>
        PercentPerOhm,

        /// <summary>
        /// Percent per degree (Code: H90)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to an angle of one degree.
        /// </remarks>
        PercentPerDegree,

        /// <summary>
        /// Percent per ten thousand (Code: H91)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to multiples of ten thousand.
        /// </remarks>
        PercentPerTenThousand,

        /// <summary>
        /// Percent per one hundred thousand (Code: H92)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to multiples of one hundred thousand.
        /// </remarks>
        PercentPerOneHundredThousand,

        /// <summary>
        /// Percent per hundred (Code: H93)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to multiples of one hundred.
        /// </remarks>
        PercentPerHundred,

        /// <summary>
        /// Percent per thousand (Code: H94)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to multiples of one thousand.
        /// </remarks>
        PercentPerThousand,

        /// <summary>
        /// Percent per volt (Code: H95)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to the SI derived unit volt.
        /// </remarks>
        PercentPerVolt,

        /// <summary>
        /// Percent per bar (Code: H96)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to an atmospheric pressure of one bar.
        /// </remarks>
        PercentPerBar,

        /// <summary>
        /// Percent per inch (Code: H98)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to an inch.
        /// </remarks>
        PercentPerInch,

        /// <summary>
        /// Percent per metre (Code: H99)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to a metre.
        /// </remarks>
        PercentPerMetre,

        /// <summary>
        /// Hank (Code: HA)
        /// </summary>
        /// <remarks>
        /// A unit of length, typically for yarn.
        /// </remarks>
        Hank,

        /// <summary>
        /// Piece Day (Code: HAD)
        /// </summary>
        PieceDay,

        /// <summary>
        /// Hectobar (Code: HBA)
        /// </summary>
        Hectobar,

        /// <summary>
        /// Hundred boxes (Code: HBX)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of boxes in multiples of one hundred box units.
        /// </remarks>
        HundredBoxes,

        /// <summary>
        /// Hundred count (Code: HC)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of units counted in multiples of 100.
        /// </remarks>
        HundredCount,

        /// <summary>
        /// Hundred kilogram, dry weight (Code: HDW)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of hundred kilograms of a product, disregarding the water content of the product.
        /// </remarks>
        HundredKilogram_DryWeight,

        /// <summary>
        /// Head (Code: HEA)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of heads (head: a person or animal considered as one of a number).
        /// </remarks>
        Head,

        /// <summary>
        /// Hectogram (Code: HGM)
        /// </summary>
        Hectogram,

        /// <summary>
        /// Hundred cubic foot (Code: HH)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one hundred cubic foot.
        /// </remarks>
        HundredCubicFoot,

        /// <summary>
        /// Hundred international unit (Code: HIU)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of international units in multiples of 100.
        /// </remarks>
        HundredInternationalUnit,

        /// <summary>
        /// Hundred kilogram, net mass (Code: HKM)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of hundred kilograms of a product, after deductions.
        /// </remarks>
        HundredKilogram_NetMass,

        /// <summary>
        /// Hectolitre (Code: HLT)
        /// </summary>
        Hectolitre,

        /// <summary>
        /// Mile per hour (statute mile) (Code: HM)
        /// </summary>
        MilePerHour_statuteMile,

        /// <summary>
        /// Piece Month (Code: HMO)
        /// </summary>
        PieceMonth,

        /// <summary>
        /// Million cubic metre (Code: HMQ)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one million cubic metres.
        /// </remarks>
        MillionCubicMetre,

        /// <summary>
        /// Hectometre (Code: HMT)
        /// </summary>
        Hectometre,

        /// <summary>
        /// Hectolitre of pure alcohol (Code: HPA)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one hundred litres of pure alcohol.
        /// </remarks>
        HectolitreOfPureAlcohol,

        /// <summary>
        /// Hertz (Code: HTZ)
        /// </summary>
        Hertz,

        /// <summary>
        /// Hour (Code: HUR)
        /// </summary>
        Hour,

        /// <summary>
        /// Inch pound (pound inch) (Code: IA)
        /// </summary>
        InchPound_poundInch,

        /// <summary>
        /// Person (Code: IE)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of persons.
        /// </remarks>
        Person,

        /// <summary>
        /// Inch (Code: INH)
        /// </summary>
        Inch,

        /// <summary>
        /// Square inch (Code: INK)
        /// </summary>
        SquareInch,

        /// <summary>
        /// Cubic inch (Code: INQ)
        /// </summary>
        /// <remarks>
        /// Synonym: inch cubed
        /// </remarks>
        CubicInch,

        /// <summary>
        /// International sugar degree (Code: ISD)
        /// </summary>
        /// <remarks>
        /// A unit of measure defining the sugar content of a solution, expressed in degrees.
        /// </remarks>
        InternationalSugarDegree,

        /// <summary>
        /// Inch per second (Code: IU)
        /// </summary>
        InchPerSecond,

        /// <summary>
        /// International unit per gram (Code: IUG)
        /// </summary>
        InternationalUnitPerGram,

        /// <summary>
        /// Inch per second squared (Code: IV)
        /// </summary>
        InchPerSecondSquared,

        /// <summary>
        /// Percent per millimetre (Code: J10)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to a millimetre.
        /// </remarks>
        PercentPerMillimetre,

        /// <summary>
        /// Per mille per psi (Code: J12)
        /// </summary>
        /// <remarks>
        /// A unit of pressure equal to one thousandth of a psi (pound-force per square inch).
        /// </remarks>
        PerMillePerPsi,

        /// <summary>
        /// Degree API (Code: J13)
        /// </summary>
        /// <remarks>
        /// A unit of relative density as a measure of how heavy or light a petroleum liquid is compared to water (API: American Petroleum Institute).
        /// </remarks>
        DegreeAPI,

        /// <summary>
        /// Degree Baume (origin scale) (Code: J14)
        /// </summary>
        /// <remarks>
        /// A traditional unit of relative density for liquids. Named after Antoine Baumé.
        /// </remarks>
        DegreeBaume_originScale,

        /// <summary>
        /// Degree Baume (US heavy) (Code: J15)
        /// </summary>
        /// <remarks>
        /// A unit of relative density for liquids heavier than water.
        /// </remarks>
        DegreeBaume_USHeavy,

        /// <summary>
        /// Degree Baume (US light) (Code: J16)
        /// </summary>
        /// <remarks>
        /// A unit of relative density for liquids lighter than water.
        /// </remarks>
        DegreeBaume_USLight,

        /// <summary>
        /// Degree Balling (Code: J17)
        /// </summary>
        /// <remarks>
        /// A unit of density as a measure of sugar content, especially of beer wort. Named after Karl Balling.
        /// </remarks>
        DegreeBalling,

        /// <summary>
        /// Degree Brix (Code: J18)
        /// </summary>
        /// <remarks>
        /// A unit of proportion used in measuring the dissolved sugar-to-water mass ratio of a liquid. Named after Adolf Brix.
        /// </remarks>
        DegreeBrix,

        /// <summary>
        /// Degree Fahrenheit hour square foot per British thermal unit (thermochemical) (Code: J19)
        /// </summary>
        DegreeFahrenheitHourSquareFootPerBritishThermalUnit_thermochemical,

        /// <summary>
        /// Joule per kilogram (Code: J2)
        /// </summary>
        JoulePerKilogram,

        /// <summary>
        /// Degree Fahrenheit per kelvin (Code: J20)
        /// </summary>
        DegreeFahrenheitPerKelvin,

        /// <summary>
        /// Degree Fahrenheit per bar (Code: J21)
        /// </summary>
        DegreeFahrenheitPerBar,

        /// <summary>
        /// Degree Fahrenheit hour square foot per British thermal unit (international table) (Code: J22)
        /// </summary>
        DegreeFahrenheitHourSquareFootPerBritishThermalUnit_internationalTable,

        /// <summary>
        /// Degree Fahrenheit per hour (Code: J23)
        /// </summary>
        DegreeFahrenheitPerHour,

        /// <summary>
        /// Degree Fahrenheit per minute (Code: J24)
        /// </summary>
        DegreeFahrenheitPerMinute,

        /// <summary>
        /// Degree Fahrenheit per second (Code: J25)
        /// </summary>
        DegreeFahrenheitPerSecond,

        /// <summary>
        /// Reciprocal degree Fahrenheit (Code: J26)
        /// </summary>
        ReciprocalDegreeFahrenheit,

        /// <summary>
        /// Degree Oechsle (Code: J27)
        /// </summary>
        /// <remarks>
        /// A unit of density as a measure of sugar content of must, the unfermented liqueur from which wine is made. Named after Ferdinand Oechsle.
        /// </remarks>
        DegreeOechsle,

        /// <summary>
        /// Degree Rankine per hour (Code: J28)
        /// </summary>
        DegreeRankinePerHour,

        /// <summary>
        /// Degree Rankine per minute (Code: J29)
        /// </summary>
        DegreeRankinePerMinute,

        /// <summary>
        /// Degree Rankine per second (Code: J30)
        /// </summary>
        DegreeRankinePerSecond,

        /// <summary>
        /// Degree Twaddell (Code: J31)
        /// </summary>
        /// <remarks>
        /// A unit of density for liquids that are heavier than water. 1 degree Twaddle represents a difference in specific gravity of 0.005.
        /// </remarks>
        DegreeTwaddell,

        /// <summary>
        /// Micropoise (Code: J32)
        /// </summary>
        Micropoise,

        /// <summary>
        /// Microgram per kilogram (Code: J33)
        /// </summary>
        MicrogramPerKilogram,

        /// <summary>
        /// Microgram per cubic metre kelvin (Code: J34)
        /// </summary>
        MicrogramPerCubicMetreKelvin,

        /// <summary>
        /// Microgram per cubic metre bar (Code: J35)
        /// </summary>
        MicrogramPerCubicMetreBar,

        /// <summary>
        /// Microlitre per litre (Code: J36)
        /// </summary>
        MicrolitrePerLitre,

        /// <summary>
        /// Baud (Code: J38)
        /// </summary>
        /// <remarks>
        /// A unit of signal transmission speed equal to one signalling event per second.
        /// </remarks>
        Baud,

        /// <summary>
        /// British thermal unit (mean) (Code: J39)
        /// </summary>
        BritishThermalUnit_mean,

        /// <summary>
        /// British thermal unit (international table) foot per hour square foot degree Fahrenheit (Code: J40)
        /// </summary>
        BritishThermalUnit_internationalTable_FootPerHourSquareFootDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (international table) inch per hour square foot degree Fahrenheit (Code: J41)
        /// </summary>
        BritishThermalUnit_internationalTable_InchPerHourSquareFootDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (international table) inch per second square foot degree Fahrenheit (Code: J42)
        /// </summary>
        BritishThermalUnit_internationalTable_InchPerSecondSquareFootDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (international table) per pound degree Fahrenheit (Code: J43)
        /// </summary>
        BritishThermalUnit_internationalTable_PerPoundDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (international table) per minute (Code: J44)
        /// </summary>
        BritishThermalUnit_internationalTable_PerMinute,

        /// <summary>
        /// British thermal unit (international table) per second (Code: J45)
        /// </summary>
        BritishThermalUnit_internationalTable_PerSecond,

        /// <summary>
        /// British thermal unit (thermochemical) foot per hour square foot degree Fahrenheit (Code: J46)
        /// </summary>
        BritishThermalUnit_thermochemical_FootPerHourSquareFootDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (thermochemical) per hour (Code: J47)
        /// </summary>
        BritishThermalUnit_thermochemical_PerHour,

        /// <summary>
        /// British thermal unit (thermochemical) inch per hour square foot degree Fahrenheit (Code: J48)
        /// </summary>
        BritishThermalUnit_thermochemical_InchPerHourSquareFootDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (thermochemical) inch per second square foot degree Fahrenheit (Code: J49)
        /// </summary>
        BritishThermalUnit_thermochemical_InchPerSecondSquareFootDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (thermochemical) per pound degree Fahrenheit (Code: J50)
        /// </summary>
        BritishThermalUnit_thermochemical_PerPoundDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (thermochemical) per minute (Code: J51)
        /// </summary>
        BritishThermalUnit_thermochemical_PerMinute,

        /// <summary>
        /// British thermal unit (thermochemical) per second (Code: J52)
        /// </summary>
        BritishThermalUnit_thermochemical_PerSecond,

        /// <summary>
        /// Coulomb square metre per kilogram (Code: J53)
        /// </summary>
        CoulombSquareMetrePerKilogram,

        /// <summary>
        /// Megabaud (Code: J54)
        /// </summary>
        /// <remarks>
        /// A unit of signal transmission speed equal to 10⁶ (1000000) signaling events per second.
        /// </remarks>
        Megabaud,

        /// <summary>
        /// Watt second (Code: J55)
        /// </summary>
        WattSecond,

        /// <summary>
        /// Bar per bar (Code: J56)
        /// </summary>
        BarPerBar,

        /// <summary>
        /// Barrel (UK petroleum) (Code: J57)
        /// </summary>
        Barrel_UKPetroleum,

        /// <summary>
        /// Barrel (UK petroleum) per minute (Code: J58)
        /// </summary>
        Barrel_UKPetroleum_PerMinute,

        /// <summary>
        /// Barrel (UK petroleum) per day (Code: J59)
        /// </summary>
        Barrel_UKPetroleum_PerDay,

        /// <summary>
        /// Barrel (UK petroleum) per hour (Code: J60)
        /// </summary>
        Barrel_UKPetroleum_PerHour,

        /// <summary>
        /// Barrel (UK petroleum) per second (Code: J61)
        /// </summary>
        Barrel_UKPetroleum_PerSecond,

        /// <summary>
        /// Barrel (US petroleum) per hour (Code: J62)
        /// </summary>
        Barrel_USPetroleum_PerHour,

        /// <summary>
        /// Barrel (US petroleum) per second (Code: J63)
        /// </summary>
        Barrel_USPetroleum_PerSecond,

        /// <summary>
        /// Bushel (UK) per day (Code: J64)
        /// </summary>
        Bushel_UK_PerDay,

        /// <summary>
        /// Bushel (UK) per hour (Code: J65)
        /// </summary>
        Bushel_UK_PerHour,

        /// <summary>
        /// Bushel (UK) per minute (Code: J66)
        /// </summary>
        Bushel_UK_PerMinute,

        /// <summary>
        /// Bushel (UK) per second (Code: J67)
        /// </summary>
        Bushel_UK_PerSecond,

        /// <summary>
        /// Bushel (US dry) per day (Code: J68)
        /// </summary>
        Bushel_USDry_PerDay,

        /// <summary>
        /// Bushel (US dry) per hour (Code: J69)
        /// </summary>
        Bushel_USDry_PerHour,

        /// <summary>
        /// Bushel (US dry) per minute (Code: J70)
        /// </summary>
        Bushel_USDry_PerMinute,

        /// <summary>
        /// Bushel (US dry) per second (Code: J71)
        /// </summary>
        Bushel_USDry_PerSecond,

        /// <summary>
        /// Centinewton metre (Code: J72)
        /// </summary>
        CentinewtonMetre,

        /// <summary>
        /// Centipoise per kelvin (Code: J73)
        /// </summary>
        CentipoisePerKelvin,

        /// <summary>
        /// Centipoise per bar (Code: J74)
        /// </summary>
        CentipoisePerBar,

        /// <summary>
        /// Calorie (mean) (Code: J75)
        /// </summary>
        Calorie_mean,

        /// <summary>
        /// Calorie (international table) per gram degree Celsius (Code: J76)
        /// </summary>
        Calorie_internationalTable_PerGramDegreeCelsius,

        /// <summary>
        /// Calorie (thermochemical) per centimetre second degree Celsius (Code: J78)
        /// </summary>
        Calorie_thermochemical_PerCentimetreSecondDegreeCelsius,

        /// <summary>
        /// Calorie (thermochemical) per gram degree Celsius (Code: J79)
        /// </summary>
        Calorie_thermochemical_PerGramDegreeCelsius,

        /// <summary>
        /// Calorie (thermochemical) per minute (Code: J81)
        /// </summary>
        Calorie_thermochemical_PerMinute,

        /// <summary>
        /// Calorie (thermochemical) per second (Code: J82)
        /// </summary>
        Calorie_thermochemical_PerSecond,

        /// <summary>
        /// Clo (Code: J83)
        /// </summary>
        Clo,

        /// <summary>
        /// Centimetre per second kelvin (Code: J84)
        /// </summary>
        CentimetrePerSecondKelvin,

        /// <summary>
        /// Centimetre per second bar (Code: J85)
        /// </summary>
        CentimetrePerSecondBar,

        /// <summary>
        /// Cubic centimetre per cubic metre (Code: J87)
        /// </summary>
        CubicCentimetrePerCubicMetre,

        /// <summary>
        /// Cubic decimetre per day (Code: J90)
        /// </summary>
        CubicDecimetrePerDay,

        /// <summary>
        /// Cubic decimetre per cubic metre (Code: J91)
        /// </summary>
        CubicDecimetrePerCubicMetre,

        /// <summary>
        /// Cubic decimetre per minute (Code: J92)
        /// </summary>
        CubicDecimetrePerMinute,

        /// <summary>
        /// Cubic decimetre per second (Code: J93)
        /// </summary>
        CubicDecimetrePerSecond,

        /// <summary>
        /// Ounce (UK fluid) per day (Code: J95)
        /// </summary>
        Ounce_UKFluid_PerDay,

        /// <summary>
        /// Ounce (UK fluid) per hour (Code: J96)
        /// </summary>
        Ounce_UKFluid_PerHour,

        /// <summary>
        /// Ounce (UK fluid) per minute (Code: J97)
        /// </summary>
        Ounce_UKFluid_PerMinute,

        /// <summary>
        /// Ounce (UK fluid) per second (Code: J98)
        /// </summary>
        Ounce_UKFluid_PerSecond,

        /// <summary>
        /// Ounce (US fluid) per day (Code: J99)
        /// </summary>
        Ounce_USFluid_PerDay,

        /// <summary>
        /// Joule per kelvin (Code: JE)
        /// </summary>
        JoulePerKelvin,

        /// <summary>
        /// Megajoule per kilogram (Code: JK)
        /// </summary>
        MegajoulePerKilogram,

        /// <summary>
        /// Megajoule per cubic metre (Code: JM)
        /// </summary>
        MegajoulePerCubicMetre,

        /// <summary>
        /// Pipeline joint (Code: JNT)
        /// </summary>
        /// <remarks>
        /// A count of the number of pipeline joints.
        /// </remarks>
        PipelineJoint,

        /// <summary>
        /// Joule (Code: JOU)
        /// </summary>
        Joule,

        /// <summary>
        /// Hundred metre (Code: JPS)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of 100 metre lengths.
        /// </remarks>
        HundredMetre,

        /// <summary>
        /// Number of jewels (Code: JWL)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of jewels (jewel: precious stone).
        /// </remarks>
        NumberOfJewels,

        /// <summary>
        /// Kilowatt demand (Code: K1)
        /// </summary>
        /// <remarks>
        /// A unit of measure defining the power load measured at predetermined intervals.
        /// </remarks>
        KilowattDemand,

        /// <summary>
        /// Ounce (US fluid) per hour (Code: K10)
        /// </summary>
        Ounce_USFluid_PerHour,

        /// <summary>
        /// Ounce (US fluid) per minute (Code: K11)
        /// </summary>
        Ounce_USFluid_PerMinute,

        /// <summary>
        /// Ounce (US fluid) per second (Code: K12)
        /// </summary>
        Ounce_USFluid_PerSecond,

        /// <summary>
        /// Foot per degree Fahrenheit (Code: K13)
        /// </summary>
        FootPerDegreeFahrenheit,

        /// <summary>
        /// Foot per hour (Code: K14)
        /// </summary>
        FootPerHour,

        /// <summary>
        /// Foot pound-force per hour (Code: K15)
        /// </summary>
        FootPoundForcePerHour,

        /// <summary>
        /// Foot pound-force per minute (Code: K16)
        /// </summary>
        FootPoundForcePerMinute,

        /// <summary>
        /// Foot per psi (Code: K17)
        /// </summary>
        FootPerPsi,

        /// <summary>
        /// Foot per second degree Fahrenheit (Code: K18)
        /// </summary>
        FootPerSecondDegreeFahrenheit,

        /// <summary>
        /// Foot per second psi (Code: K19)
        /// </summary>
        FootPerSecondPsi,

        /// <summary>
        /// Kilovolt ampere reactive demand (Code: K2)
        /// </summary>
        /// <remarks>
        /// A unit of measure defining the reactive power demand equal to one kilovolt ampere of reactive power.
        /// </remarks>
        KilovoltAmpereReactiveDemand,

        /// <summary>
        /// Reciprocal cubic foot (Code: K20)
        /// </summary>
        ReciprocalCubicFoot,

        /// <summary>
        /// Cubic foot per degree Fahrenheit (Code: K21)
        /// </summary>
        CubicFootPerDegreeFahrenheit,

        /// <summary>
        /// Cubic foot per day (Code: K22)
        /// </summary>
        CubicFootPerDay,

        /// <summary>
        /// Cubic foot per psi (Code: K23)
        /// </summary>
        CubicFootPerPsi,

        /// <summary>
        /// Gallon (UK) per day (Code: K26)
        /// </summary>
        Gallon_UK_PerDay,

        /// <summary>
        /// Gallon (UK) per hour (Code: K27)
        /// </summary>
        Gallon_UK_PerHour,

        /// <summary>
        /// Gallon (UK) per second (Code: K28)
        /// </summary>
        Gallon_UK_PerSecond,

        /// <summary>
        /// Kilovolt ampere reactive hour (Code: K3)
        /// </summary>
        /// <remarks>
        /// A unit of measure defining the accumulated reactive energy equal to one kilovolt ampere of reactive power per hour.
        /// </remarks>
        KilovoltAmpereReactiveHour,

        /// <summary>
        /// Gallon (US liquid) per second (Code: K30)
        /// </summary>
        Gallon_USLiquid_PerSecond,

        /// <summary>
        /// Gram-force per square centimetre (Code: K31)
        /// </summary>
        GramForcePerSquareCentimetre,

        /// <summary>
        /// Gill (UK) per day (Code: K32)
        /// </summary>
        Gill_UK_PerDay,

        /// <summary>
        /// Gill (UK) per hour (Code: K33)
        /// </summary>
        Gill_UK_PerHour,

        /// <summary>
        /// Gill (UK) per minute (Code: K34)
        /// </summary>
        Gill_UK_PerMinute,

        /// <summary>
        /// Gill (UK) per second (Code: K35)
        /// </summary>
        Gill_UK_PerSecond,

        /// <summary>
        /// Gill (US) per day (Code: K36)
        /// </summary>
        Gill_US_PerDay,

        /// <summary>
        /// Gill (US) per hour (Code: K37)
        /// </summary>
        Gill_US_PerHour,

        /// <summary>
        /// Gill (US) per minute (Code: K38)
        /// </summary>
        Gill_US_PerMinute,

        /// <summary>
        /// Gill (US) per second (Code: K39)
        /// </summary>
        Gill_US_PerSecond,

        /// <summary>
        /// Standard acceleration of free fall (Code: K40)
        /// </summary>
        StandardAccelerationOfFreeFall,

        /// <summary>
        /// Grain per gallon (US) (Code: K41)
        /// </summary>
        GrainPerGallon_US,

        /// <summary>
        /// Horsepower (boiler) (Code: K42)
        /// </summary>
        Horsepower_boiler,

        /// <summary>
        /// Horsepower (electric) (Code: K43)
        /// </summary>
        Horsepower_electric,

        /// <summary>
        /// Inch per degree Fahrenheit (Code: K45)
        /// </summary>
        InchPerDegreeFahrenheit,

        /// <summary>
        /// Inch per psi (Code: K46)
        /// </summary>
        InchPerPsi,

        /// <summary>
        /// Inch per second degree Fahrenheit (Code: K47)
        /// </summary>
        InchPerSecondDegreeFahrenheit,

        /// <summary>
        /// Inch per second psi (Code: K48)
        /// </summary>
        InchPerSecondPsi,

        /// <summary>
        /// Reciprocal cubic inch (Code: K49)
        /// </summary>
        ReciprocalCubicInch,

        /// <summary>
        /// Kilobaud (Code: K50)
        /// </summary>
        /// <remarks>
        /// A unit of signal transmission speed equal to 10³ (1000) signaling events per second.
        /// </remarks>
        Kilobaud,

        /// <summary>
        /// Kilocalorie (mean) (Code: K51)
        /// </summary>
        Kilocalorie_mean,

        /// <summary>
        /// Kilocalorie (international table) per hour metre degree Celsius (Code: K52)
        /// </summary>
        Kilocalorie_internationalTable_PerHourMetreDegreeCelsius,

        /// <summary>
        /// Kilocalorie (thermochemical) (Code: K53)
        /// </summary>
        Kilocalorie_thermochemical,

        /// <summary>
        /// Kilocalorie (thermochemical) per minute (Code: K54)
        /// </summary>
        Kilocalorie_thermochemical_PerMinute,

        /// <summary>
        /// Kilocalorie (thermochemical) per second (Code: K55)
        /// </summary>
        Kilocalorie_thermochemical_PerSecond,

        /// <summary>
        /// Kilomole per hour (Code: K58)
        /// </summary>
        KilomolePerHour,

        /// <summary>
        /// Kilomole per cubic metre kelvin (Code: K59)
        /// </summary>
        KilomolePerCubicMetreKelvin,

        /// <summary>
        /// Kilolitre (Code: K6)
        /// </summary>
        Kilolitre,

        /// <summary>
        /// Kilomole per cubic metre bar (Code: K60)
        /// </summary>
        KilomolePerCubicMetreBar,

        /// <summary>
        /// Kilomole per minute (Code: K61)
        /// </summary>
        KilomolePerMinute,

        /// <summary>
        /// Litre per litre (Code: K62)
        /// </summary>
        LitrePerLitre,

        /// <summary>
        /// Reciprocal litre (Code: K63)
        /// </summary>
        ReciprocalLitre,

        /// <summary>
        /// Pound (avoirdupois) per degree Fahrenheit (Code: K64)
        /// </summary>
        Pound_avoirdupois_PerDegreeFahrenheit,

        /// <summary>
        /// Pound (avoirdupois) square foot (Code: K65)
        /// </summary>
        Pound_avoirdupois_SquareFoot,

        /// <summary>
        /// Pound (avoirdupois) per day (Code: K66)
        /// </summary>
        Pound_avoirdupois_PerDay,

        /// <summary>
        /// Pound per foot hour (Code: K67)
        /// </summary>
        PoundPerFootHour,

        /// <summary>
        /// Pound per foot second (Code: K68)
        /// </summary>
        PoundPerFootSecond,

        /// <summary>
        /// Pound (avoirdupois) per cubic foot degree Fahrenheit (Code: K69)
        /// </summary>
        Pound_avoirdupois_PerCubicFootDegreeFahrenheit,

        /// <summary>
        /// Pound (avoirdupois) per cubic foot psi (Code: K70)
        /// </summary>
        Pound_avoirdupois_PerCubicFootPsi,

        /// <summary>
        /// Pound (avoirdupois) per gallon (UK) (Code: K71)
        /// </summary>
        Pound_avoirdupois_PerGallon_UK,

        /// <summary>
        /// Pound (avoirdupois) per hour degree Fahrenheit (Code: K73)
        /// </summary>
        Pound_avoirdupois_PerHourDegreeFahrenheit,

        /// <summary>
        /// Pound (avoirdupois) per hour psi (Code: K74)
        /// </summary>
        Pound_avoirdupois_PerHourPsi,

        /// <summary>
        /// Pound (avoirdupois) per cubic inch degree Fahrenheit (Code: K75)
        /// </summary>
        Pound_avoirdupois_PerCubicInchDegreeFahrenheit,

        /// <summary>
        /// Pound (avoirdupois) per cubic inch psi (Code: K76)
        /// </summary>
        Pound_avoirdupois_PerCubicInchPsi,

        /// <summary>
        /// Pound (avoirdupois) per psi (Code: K77)
        /// </summary>
        Pound_avoirdupois_PerPsi,

        /// <summary>
        /// Pound (avoirdupois) per minute (Code: K78)
        /// </summary>
        Pound_avoirdupois_PerMinute,

        /// <summary>
        /// Pound (avoirdupois) per minute degree Fahrenheit (Code: K79)
        /// </summary>
        Pound_avoirdupois_PerMinuteDegreeFahrenheit,

        /// <summary>
        /// Pound (avoirdupois) per minute psi (Code: K80)
        /// </summary>
        Pound_avoirdupois_PerMinutePsi,

        /// <summary>
        /// Pound (avoirdupois) per second (Code: K81)
        /// </summary>
        Pound_avoirdupois_PerSecond,

        /// <summary>
        /// Pound (avoirdupois) per second degree Fahrenheit (Code: K82)
        /// </summary>
        Pound_avoirdupois_PerSecondDegreeFahrenheit,

        /// <summary>
        /// Pound (avoirdupois) per second psi (Code: K83)
        /// </summary>
        Pound_avoirdupois_PerSecondPsi,

        /// <summary>
        /// Pound per cubic yard (Code: K84)
        /// </summary>
        PoundPerCubicYard,

        /// <summary>
        /// Pound-force per square foot (Code: K85)
        /// </summary>
        PoundForcePerSquareFoot,

        /// <summary>
        /// Pound-force per square inch degree Fahrenheit (Code: K86)
        /// </summary>
        PoundForcePerSquareInchDegreeFahrenheit,

        /// <summary>
        /// Psi cubic inch per second (Code: K87)
        /// </summary>
        PsiCubicInchPerSecond,

        /// <summary>
        /// Psi litre per second (Code: K88)
        /// </summary>
        PsiLitrePerSecond,

        /// <summary>
        /// Psi cubic metre per second (Code: K89)
        /// </summary>
        PsiCubicMetrePerSecond,

        /// <summary>
        /// Psi cubic yard per second (Code: K90)
        /// </summary>
        PsiCubicYardPerSecond,

        /// <summary>
        /// Pound-force second per square foot (Code: K91)
        /// </summary>
        PoundForceSecondPerSquareFoot,

        /// <summary>
        /// Pound-force second per square inch (Code: K92)
        /// </summary>
        PoundForceSecondPerSquareInch,

        /// <summary>
        /// Reciprocal psi (Code: K93)
        /// </summary>
        ReciprocalPsi,

        /// <summary>
        /// Quart (UK liquid) per day (Code: K94)
        /// </summary>
        Quart_UKLiquid_PerDay,

        /// <summary>
        /// Quart (UK liquid) per hour (Code: K95)
        /// </summary>
        Quart_UKLiquid_PerHour,

        /// <summary>
        /// Quart (UK liquid) per minute (Code: K96)
        /// </summary>
        Quart_UKLiquid_PerMinute,

        /// <summary>
        /// Quart (UK liquid) per second (Code: K97)
        /// </summary>
        Quart_UKLiquid_PerSecond,

        /// <summary>
        /// Quart (US liquid) per day (Code: K98)
        /// </summary>
        Quart_USLiquid_PerDay,

        /// <summary>
        /// Quart (US liquid) per hour (Code: K99)
        /// </summary>
        Quart_USLiquid_PerHour,

        /// <summary>
        /// Cake (Code: KA)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of cakes (cake: object shaped into a flat, compact mass).
        /// </remarks>
        Cake,

        /// <summary>
        /// Katal (Code: KAT)
        /// </summary>
        /// <remarks>
        /// A unit of catalytic activity defining the catalytic activity of enzymes and other catalysts.
        /// </remarks>
        Katal,

        /// <summary>
        /// Kilocharacter (Code: KB)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10³ (1000) characters.
        /// </remarks>
        Kilocharacter,

        /// <summary>
        /// Kilobar (Code: KBA)
        /// </summary>
        Kilobar,

        /// <summary>
        /// Kilogram of choline chloride (Code: KCC)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of choline chloride.
        /// </remarks>
        KilogramOfCholineChloride,

        /// <summary>
        /// Kilogram drained net weight (Code: KDW)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the net number of kilograms of a product, disregarding the liquid content of the product.
        /// </remarks>
        KilogramDrainedNetWeight,

        /// <summary>
        /// Kelvin (Code: KEL)
        /// </summary>
        /// <remarks>
        /// Refer ISO 80000-5 (Quantities and units — Part 5: Thermodynamics)
        /// </remarks>
        Kelvin,

        /// <summary>
        /// Kilogram (Code: KGM)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams.
        /// </remarks>
        Kilogram,

        /// <summary>
        /// Kilogram per second (Code: KGS)
        /// </summary>
        KilogramPerSecond,

        /// <summary>
        /// Kilogram of hydrogen peroxide (Code: KHY)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of hydrogen peroxide.
        /// </remarks>
        KilogramOfHydrogenPeroxide,

        /// <summary>
        /// Kilohertz (Code: KHZ)
        /// </summary>
        Kilohertz,

        /// <summary>
        /// Kilogram per millimetre width (Code: KI)
        /// </summary>
        KilogramPerMillimetreWidth,

        /// <summary>
        /// Kilogram, including container (Code: KIC)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of kilograms of a product, including its container.
        /// </remarks>
        Kilogram_IncludingContainer,

        /// <summary>
        /// Kilogram, including inner packaging (Code: KIP)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of kilograms of a product, including its inner packaging materials.
        /// </remarks>
        Kilogram_IncludingInnerPackaging,

        /// <summary>
        /// Kilosegment (Code: KJ)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 10³ (1000) segments.
        /// </remarks>
        Kilosegment,

        /// <summary>
        /// Kilojoule (Code: KJO)
        /// </summary>
        Kilojoule,

        /// <summary>
        /// Kilogram per metre (Code: KL)
        /// </summary>
        KilogramPerMetre,

        /// <summary>
        /// Lactic dry material percentage (Code: KLK)
        /// </summary>
        /// <remarks>
        /// A unit of proportion defining the percentage of dry lactic material in a product.
        /// </remarks>
        LacticDryMaterialPercentage,

        /// <summary>
        /// Kilolux (Code: KLX)
        /// </summary>
        /// <remarks>
        /// A unit of illuminance equal to one thousand lux.
        /// </remarks>
        Kilolux,

        /// <summary>
        /// Kilogram of methylamine (Code: KMA)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of methylamine.
        /// </remarks>
        KilogramOfMethylamine,

        /// <summary>
        /// Kilometre per hour (Code: KMH)
        /// </summary>
        KilometrePerHour,

        /// <summary>
        /// Square kilometre (Code: KMK)
        /// </summary>
        SquareKilometre,

        /// <summary>
        /// Kilogram per cubic metre (Code: KMQ)
        /// </summary>
        /// <remarks>
        /// A unit of weight expressed in kilograms of a substance that fills a volume of one cubic metre.
        /// </remarks>
        KilogramPerCubicMetre,

        /// <summary>
        /// Kilometre (Code: KMT)
        /// </summary>
        Kilometre,

        /// <summary>
        /// Kilogram of nitrogen (Code: KNI)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of nitrogen.
        /// </remarks>
        KilogramOfNitrogen,

        /// <summary>
        /// Kilonewton per square metre (Code: KNM)
        /// </summary>
        /// <remarks>
        /// Pressure expressed in kN/m2.
        /// </remarks>
        KilonewtonPerSquareMetre,

        /// <summary>
        /// Kilogram named substance (Code: KNS)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one kilogram of a named substance.
        /// </remarks>
        KilogramNamedSubstance,

        /// <summary>
        /// Knot (Code: KNT)
        /// </summary>
        Knot,

        /// <summary>
        /// Milliequivalence caustic potash per gram of product (Code: KO)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of milligrams of potassium hydroxide per gram of product as a measure of the concentration of potassium hydroxide in the product.
        /// </remarks>
        MilliequivalenceCausticPotashPerGramOfProduct,

        /// <summary>
        /// Kilopascal (Code: KPA)
        /// </summary>
        Kilopascal,

        /// <summary>
        /// Kilogram of potassium hydroxide (caustic potash) (Code: KPH)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of potassium hydroxide (caustic potash).
        /// </remarks>
        KilogramOfPotassiumHydroxide_causticPotash,

        /// <summary>
        /// Kilogram of potassium oxide (Code: KPO)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of potassium oxide.
        /// </remarks>
        KilogramOfPotassiumOxide,

        /// <summary>
        /// Kilogram of phosphorus pentoxide (phosphoric anhydride) (Code: KPP)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of phosphorus pentoxide phosphoric anhydride.
        /// </remarks>
        KilogramOfPhosphorusPentoxide_phosphoricAnhydride,

        /// <summary>
        /// Kiloroentgen (Code: KR)
        /// </summary>
        Kiloroentgen,

        /// <summary>
        /// Kilogram of substance 90 % dry (Code: KSD)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of a named substance that is 90% dry.
        /// </remarks>
        KilogramOfSubstance90PercentDry,

        /// <summary>
        /// Kilogram of sodium hydroxide (caustic soda) (Code: KSH)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of sodium hydroxide (caustic soda).
        /// </remarks>
        KilogramOfSodiumHydroxide_causticSoda,

        /// <summary>
        /// Kit (Code: KT)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of kits (kit: tub, barrel or pail).
        /// </remarks>
        Kit_UnitOfCount,

        /// <summary>
        /// Kilotonne (Code: KTN)
        /// </summary>
        Kilotonne,

        /// <summary>
        /// Kilogram of uranium (Code: KUR)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of uranium.
        /// </remarks>
        KilogramOfUranium,

        /// <summary>
        /// Kilovolt - ampere (Code: KVA)
        /// </summary>
        KilovoltAmpere,

        /// <summary>
        /// Kilovar (Code: KVR)
        /// </summary>
        Kilovar,

        /// <summary>
        /// Kilovolt (Code: KVT)
        /// </summary>
        Kilovolt,

        /// <summary>
        /// Kilogram per millimetre (Code: KW)
        /// </summary>
        KilogramPerMillimetre,

        /// <summary>
        /// Kilowatt hour (Code: KWH)
        /// </summary>
        KilowattHour,

        /// <summary>
        /// Kilowatt hour per normalized cubic metre (Code: KWN)
        /// </summary>
        KilowattHourPerNormalizedCubicMetre,

        /// <summary>
        /// Kilogram of tungsten trioxide (Code: KWO)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of tungsten trioxide.
        /// </remarks>
        KilogramOfTungstenTrioxide,

        /// <summary>
        /// Kilowatt hour per standard cubic metre (Code: KWS)
        /// </summary>
        KilowattHourPerStandardCubicMetre,

        /// <summary>
        /// Kilowatt (Code: KWT)
        /// </summary>
        Kilowatt,

        /// <summary>
        /// Kilowatt year (Code: KWY)
        /// </summary>
        KilowattYear,

        /// <summary>
        /// Millilitre per kilogram (Code: KX)
        /// </summary>
        MillilitrePerKilogram,

        /// <summary>
        /// Quart (US liquid) per minute (Code: L10)
        /// </summary>
        Quart_USLiquid_PerMinute,

        /// <summary>
        /// Quart (US liquid) per second (Code: L11)
        /// </summary>
        Quart_USLiquid_PerSecond,

        /// <summary>
        /// Metre per second kelvin (Code: L12)
        /// </summary>
        MetrePerSecondKelvin,

        /// <summary>
        /// Metre per second bar (Code: L13)
        /// </summary>
        MetrePerSecondBar,

        /// <summary>
        /// Square metre hour degree Celsius per kilocalorie (international table) (Code: L14)
        /// </summary>
        SquareMetreHourDegreeCelsiusPerKilocalorie_internationalTable,

        /// <summary>
        /// Millipascal second per kelvin (Code: L15)
        /// </summary>
        MillipascalSecondPerKelvin,

        /// <summary>
        /// Millipascal second per bar (Code: L16)
        /// </summary>
        MillipascalSecondPerBar,

        /// <summary>
        /// Milligram per cubic metre kelvin (Code: L17)
        /// </summary>
        MilligramPerCubicMetreKelvin,

        /// <summary>
        /// Milligram per cubic metre bar (Code: L18)
        /// </summary>
        MilligramPerCubicMetreBar,

        /// <summary>
        /// Millilitre per litre (Code: L19)
        /// </summary>
        MillilitrePerLitre,

        /// <summary>
        /// Litre per minute (Code: L2)
        /// </summary>
        LitrePerMinute,

        /// <summary>
        /// Reciprocal cubic millimetre (Code: L20)
        /// </summary>
        ReciprocalCubicMillimetre,

        /// <summary>
        /// Cubic millimetre per cubic metre (Code: L21)
        /// </summary>
        CubicMillimetrePerCubicMetre,

        /// <summary>
        /// Mole per hour (Code: L23)
        /// </summary>
        MolePerHour,

        /// <summary>
        /// Mole per kilogram kelvin (Code: L24)
        /// </summary>
        MolePerKilogramKelvin,

        /// <summary>
        /// Mole per kilogram bar (Code: L25)
        /// </summary>
        MolePerKilogramBar,

        /// <summary>
        /// Mole per litre kelvin (Code: L26)
        /// </summary>
        MolePerLitreKelvin,

        /// <summary>
        /// Mole per litre bar (Code: L27)
        /// </summary>
        MolePerLitreBar,

        /// <summary>
        /// Mole per cubic metre kelvin (Code: L28)
        /// </summary>
        MolePerCubicMetreKelvin,

        /// <summary>
        /// Mole per cubic metre bar (Code: L29)
        /// </summary>
        MolePerCubicMetreBar,

        /// <summary>
        /// Mole per minute (Code: L30)
        /// </summary>
        MolePerMinute,

        /// <summary>
        /// Milliroentgen aequivalent men (Code: L31)
        /// </summary>
        MilliroentgenAequivalentMen,

        /// <summary>
        /// Nanogram per kilogram (Code: L32)
        /// </summary>
        NanogramPerKilogram,

        /// <summary>
        /// Ounce (avoirdupois) per day (Code: L33)
        /// </summary>
        Ounce_avoirdupois_PerDay,

        /// <summary>
        /// Ounce (avoirdupois) per hour (Code: L34)
        /// </summary>
        Ounce_avoirdupois_PerHour,

        /// <summary>
        /// Ounce (avoirdupois) per minute (Code: L35)
        /// </summary>
        Ounce_avoirdupois_PerMinute,

        /// <summary>
        /// Ounce (avoirdupois) per second (Code: L36)
        /// </summary>
        Ounce_avoirdupois_PerSecond,

        /// <summary>
        /// Ounce (avoirdupois) per gallon (UK) (Code: L37)
        /// </summary>
        Ounce_avoirdupois_PerGallon_UK,

        /// <summary>
        /// Ounce (avoirdupois) per gallon (US) (Code: L38)
        /// </summary>
        Ounce_avoirdupois_PerGallon_US,

        /// <summary>
        /// Ounce (avoirdupois) per cubic inch (Code: L39)
        /// </summary>
        Ounce_avoirdupois_PerCubicInch,

        /// <summary>
        /// Ounce (avoirdupois)-force (Code: L40)
        /// </summary>
        Ounce_avoirdupois_Force,

        /// <summary>
        /// Ounce (avoirdupois)-force inch (Code: L41)
        /// </summary>
        Ounce_avoirdupois_ForceInch,

        /// <summary>
        /// Picosiemens per metre (Code: L42)
        /// </summary>
        PicosiemensPerMetre,

        /// <summary>
        /// Peck (UK) (Code: L43)
        /// </summary>
        Peck_UK,

        /// <summary>
        /// Peck (UK) per day (Code: L44)
        /// </summary>
        Peck_UK_PerDay,

        /// <summary>
        /// Peck (UK) per hour (Code: L45)
        /// </summary>
        Peck_UK_PerHour,

        /// <summary>
        /// Peck (UK) per minute (Code: L46)
        /// </summary>
        Peck_UK_PerMinute,

        /// <summary>
        /// Peck (UK) per second (Code: L47)
        /// </summary>
        Peck_UK_PerSecond,

        /// <summary>
        /// Peck (US dry) per day (Code: L48)
        /// </summary>
        Peck_USDry_PerDay,

        /// <summary>
        /// Peck (US dry) per hour (Code: L49)
        /// </summary>
        Peck_USDry_PerHour,

        /// <summary>
        /// Peck (US dry) per minute (Code: L50)
        /// </summary>
        Peck_USDry_PerMinute,

        /// <summary>
        /// Peck (US dry) per second (Code: L51)
        /// </summary>
        Peck_USDry_PerSecond,

        /// <summary>
        /// Psi per psi (Code: L52)
        /// </summary>
        PsiPerPsi,

        /// <summary>
        /// Pint (UK) per day (Code: L53)
        /// </summary>
        Pint_UK_PerDay,

        /// <summary>
        /// Pint (UK) per hour (Code: L54)
        /// </summary>
        Pint_UK_PerHour,

        /// <summary>
        /// Pint (UK) per minute (Code: L55)
        /// </summary>
        Pint_UK_PerMinute,

        /// <summary>
        /// Pint (UK) per second (Code: L56)
        /// </summary>
        Pint_UK_PerSecond,

        /// <summary>
        /// Pint (US liquid) per day (Code: L57)
        /// </summary>
        Pint_USLiquid_PerDay,

        /// <summary>
        /// Pint (US liquid) per hour (Code: L58)
        /// </summary>
        Pint_USLiquid_PerHour,

        /// <summary>
        /// Pint (US liquid) per minute (Code: L59)
        /// </summary>
        Pint_USLiquid_PerMinute,

        /// <summary>
        /// Pint (US liquid) per second (Code: L60)
        /// </summary>
        Pint_USLiquid_PerSecond,

        /// <summary>
        /// Slug per day (Code: L63)
        /// </summary>
        SlugPerDay,

        /// <summary>
        /// Slug per foot second (Code: L64)
        /// </summary>
        SlugPerFootSecond,

        /// <summary>
        /// Slug per cubic foot (Code: L65)
        /// </summary>
        SlugPerCubicFoot,

        /// <summary>
        /// Slug per hour (Code: L66)
        /// </summary>
        SlugPerHour,

        /// <summary>
        /// Slug per minute (Code: L67)
        /// </summary>
        SlugPerMinute,

        /// <summary>
        /// Slug per second (Code: L68)
        /// </summary>
        SlugPerSecond,

        /// <summary>
        /// Tonne per kelvin (Code: L69)
        /// </summary>
        TonnePerKelvin,

        /// <summary>
        /// Tonne per bar (Code: L70)
        /// </summary>
        TonnePerBar,

        /// <summary>
        /// Tonne per day (Code: L71)
        /// </summary>
        TonnePerDay,

        /// <summary>
        /// Tonne per day kelvin (Code: L72)
        /// </summary>
        TonnePerDayKelvin,

        /// <summary>
        /// Tonne per day bar (Code: L73)
        /// </summary>
        TonnePerDayBar,

        /// <summary>
        /// Tonne per hour kelvin (Code: L74)
        /// </summary>
        TonnePerHourKelvin,

        /// <summary>
        /// Tonne per hour bar (Code: L75)
        /// </summary>
        TonnePerHourBar,

        /// <summary>
        /// Tonne per cubic metre kelvin (Code: L76)
        /// </summary>
        TonnePerCubicMetreKelvin,

        /// <summary>
        /// Tonne per cubic metre bar (Code: L77)
        /// </summary>
        TonnePerCubicMetreBar,

        /// <summary>
        /// Tonne per minute (Code: L78)
        /// </summary>
        TonnePerMinute,

        /// <summary>
        /// Tonne per minute kelvin (Code: L79)
        /// </summary>
        TonnePerMinuteKelvin,

        /// <summary>
        /// Tonne per minute bar (Code: L80)
        /// </summary>
        TonnePerMinuteBar,

        /// <summary>
        /// Tonne per second (Code: L81)
        /// </summary>
        TonnePerSecond,

        /// <summary>
        /// Tonne per second kelvin (Code: L82)
        /// </summary>
        TonnePerSecondKelvin,

        /// <summary>
        /// Tonne per second bar (Code: L83)
        /// </summary>
        TonnePerSecondBar,

        /// <summary>
        /// Ton (UK shipping) (Code: L84)
        /// </summary>
        Ton_UKShipping,

        /// <summary>
        /// Ton long per day (Code: L85)
        /// </summary>
        TonLongPerDay,

        /// <summary>
        /// Ton (US shipping) (Code: L86)
        /// </summary>
        Ton_USShipping,

        /// <summary>
        /// Ton short per degree Fahrenheit (Code: L87)
        /// </summary>
        TonShortPerDegreeFahrenheit,

        /// <summary>
        /// Ton short per day (Code: L88)
        /// </summary>
        TonShortPerDay,

        /// <summary>
        /// Ton short per hour degree Fahrenheit (Code: L89)
        /// </summary>
        TonShortPerHourDegreeFahrenheit,

        /// <summary>
        /// Ton short per hour psi (Code: L90)
        /// </summary>
        TonShortPerHourPsi,

        /// <summary>
        /// Ton short per psi (Code: L91)
        /// </summary>
        TonShortPerPsi,

        /// <summary>
        /// Ton (UK long) per cubic yard (Code: L92)
        /// </summary>
        Ton_UKLong_PerCubicYard,

        /// <summary>
        /// Ton (US short) per cubic yard (Code: L93)
        /// </summary>
        Ton_USShort_PerCubicYard,

        /// <summary>
        /// Ton-force (US short) (Code: L94)
        /// </summary>
        TonForce_USShort,

        /// <summary>
        /// Common year (Code: L95)
        /// </summary>
        CommonYear,

        /// <summary>
        /// Sidereal year (Code: L96)
        /// </summary>
        SiderealYear,

        /// <summary>
        /// Yard per degree Fahrenheit (Code: L98)
        /// </summary>
        YardPerDegreeFahrenheit,

        /// <summary>
        /// Yard per psi (Code: L99)
        /// </summary>
        YardPerPsi,

        /// <summary>
        /// Pound per cubic inch (Code: LA)
        /// </summary>
        PoundPerCubicInch,

        /// <summary>
        /// Lactose excess percentage (Code: LAC)
        /// </summary>
        /// <remarks>
        /// A unit of proportion defining the percentage of lactose in a product that exceeds a defined percentage level.
        /// </remarks>
        LactoseExcessPercentage,

        /// <summary>
        /// Pound (Code: LBR)
        /// </summary>
        Pound,

        /// <summary>
        /// Troy pound (US) (Code: LBT)
        /// </summary>
        TroyPound_US,

        /// <summary>
        /// Litre per day (Code: LD)
        /// </summary>
        LitrePerDay,

        /// <summary>
        /// Leaf (Code: LEF)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of leaves.
        /// </remarks>
        Leaf,

        /// <summary>
        /// Linear foot (Code: LF)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of feet (12-inch) in length of a uniform width object.
        /// </remarks>
        LinearFoot,

        /// <summary>
        /// Labour hour (Code: LH)
        /// </summary>
        /// <remarks>
        /// A unit of time defining the number of labour hours.
        /// </remarks>
        LabourHour,

        /// <summary>
        /// Link (Code: LK)
        /// </summary>
        /// <remarks>
        /// A unit of distance equal to 0.01 chain.
        /// </remarks>
        Link,

        /// <summary>
        /// Linear metre (Code: LM)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of metres in length of a uniform width object.
        /// </remarks>
        LinearMetre,

        /// <summary>
        /// Length (Code: LN)
        /// </summary>
        /// <remarks>
        /// A unit of distance defining the linear extent of an item measured from end to end.
        /// </remarks>
        Length,

        /// <summary>
        /// Lot [unit of procurement] (Code: LO)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of lots (lot: a collection of associated items).
        /// </remarks>
        Lot_UnitOfProcurement,

        /// <summary>
        /// Liquid pound (Code: LP)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of pounds of a liquid substance.
        /// </remarks>
        LiquidPound,

        /// <summary>
        /// Litre of pure alcohol (Code: LPA)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one litre of pure alcohol.
        /// </remarks>
        LitreOfPureAlcohol,

        /// <summary>
        /// Layer (Code: LR)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of layers.
        /// </remarks>
        Layer,

        /// <summary>
        /// Lump sum (Code: LS)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of whole or a complete monetary amounts.
        /// </remarks>
        LumpSum,

        /// <summary>
        /// Ton (UK) or long ton (US) (Code: LTN)
        /// </summary>
        /// <remarks>
        /// Synonym: gross ton (2240 lb)
        /// </remarks>
        Ton_UK_OrLongTon_US,

        /// <summary>
        /// Litre (Code: LTR)
        /// </summary>
        Litre,

        /// <summary>
        /// Metric ton, lubricating oil (Code: LUB)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of metric tons of lubricating oil.
        /// </remarks>
        MetricTon_LubricatingOil,

        /// <summary>
        /// Lumen (Code: LUM)
        /// </summary>
        Lumen,

        /// <summary>
        /// Lux (Code: LUX)
        /// </summary>
        Lux,

        /// <summary>
        /// Linear yard (Code: LY)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of 36-inch units in length of a uniform width object.
        /// </remarks>
        LinearYard,

        /// <summary>
        /// Milligram per litre (Code: M1)
        /// </summary>
        MilligramPerLitre,

        /// <summary>
        /// Reciprocal cubic yard (Code: M10)
        /// </summary>
        ReciprocalCubicYard,

        /// <summary>
        /// Cubic yard per degree Fahrenheit (Code: M11)
        /// </summary>
        CubicYardPerDegreeFahrenheit,

        /// <summary>
        /// Cubic yard per day (Code: M12)
        /// </summary>
        CubicYardPerDay,

        /// <summary>
        /// Cubic yard per hour (Code: M13)
        /// </summary>
        CubicYardPerHour,

        /// <summary>
        /// Cubic yard per psi (Code: M14)
        /// </summary>
        CubicYardPerPsi,

        /// <summary>
        /// Cubic yard per minute (Code: M15)
        /// </summary>
        CubicYardPerMinute,

        /// <summary>
        /// Cubic yard per second (Code: M16)
        /// </summary>
        CubicYardPerSecond,

        /// <summary>
        /// Kilohertz metre (Code: M17)
        /// </summary>
        KilohertzMetre,

        /// <summary>
        /// Gigahertz metre (Code: M18)
        /// </summary>
        GigahertzMetre,

        /// <summary>
        /// Beaufort (Code: M19)
        /// </summary>
        /// <remarks>
        /// An empirical measure for describing wind speed based mainly on observed sea conditions. The Beaufort scale indicates the wind speed by numbers that typically range from 0 for calm, to 12 for hurricane.
        /// </remarks>
        Beaufort,

        /// <summary>
        /// Reciprocal megakelvin or megakelvin to the power minus one (Code: M20)
        /// </summary>
        ReciprocalMegakelvinOrMegakelvinToThePowerMinusOne,

        /// <summary>
        /// Reciprocal kilovolt - ampere reciprocal hour (Code: M21)
        /// </summary>
        ReciprocalKilovoltAmpereReciprocalHour,

        /// <summary>
        /// Millilitre per square centimetre minute (Code: M22)
        /// </summary>
        MillilitrePerSquareCentimetreMinute,

        /// <summary>
        /// Newton per centimetre (Code: M23)
        /// </summary>
        NewtonPerCentimetre,

        /// <summary>
        /// Ohm kilometre (Code: M24)
        /// </summary>
        OhmKilometre,

        /// <summary>
        /// Percent per degree Celsius (Code: M25)
        /// </summary>
        /// <remarks>
        /// A unit of proportion, equal to 0.01, in relation to a temperature of one degree.
        /// </remarks>
        PercentPerDegreeCelsius,

        /// <summary>
        /// Gigaohm per metre (Code: M26)
        /// </summary>
        GigaohmPerMetre,

        /// <summary>
        /// Megahertz metre (Code: M27)
        /// </summary>
        MegahertzMetre,

        /// <summary>
        /// Kilogram per kilogram (Code: M29)
        /// </summary>
        KilogramPerKilogram,

        /// <summary>
        /// Reciprocal volt - ampere reciprocal second (Code: M30)
        /// </summary>
        ReciprocalVoltAmpereReciprocalSecond,

        /// <summary>
        /// Kilogram per kilometre (Code: M31)
        /// </summary>
        KilogramPerKilometre,

        /// <summary>
        /// Pascal second per litre (Code: M32)
        /// </summary>
        PascalSecondPerLitre,

        /// <summary>
        /// Millimole per litre (Code: M33)
        /// </summary>
        MillimolePerLitre,

        /// <summary>
        /// Newton metre per square metre (Code: M34)
        /// </summary>
        NewtonMetrePerSquareMetre,

        /// <summary>
        /// Millivolt - ampere (Code: M35)
        /// </summary>
        MillivoltAmpere,

        /// <summary>
        /// 30-day month (Code: M36)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of months expressed in multiples of 30 days, one day equals 24 hours.
        /// </remarks>
        ThirtyDayMonth,

        /// <summary>
        /// Actual/360 (Code: M37)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of years expressed in multiples of 360 days, one day equals 24 hours.
        /// </remarks>
        ActualPer360,

        /// <summary>
        /// Kilometre per second squared (Code: M38)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the SI base unit metre divided by the power of the SI base unit second by exponent 2.
        /// </remarks>
        KilometrePerSecondSquared,

        /// <summary>
        /// Centimetre per second squared (Code: M39)
        /// </summary>
        /// <remarks>
        /// 0,01-fold of the SI base unit metre divided by the power of the SI base unit second by exponent 2.
        /// </remarks>
        CentimetrePerSecondSquared,

        /// <summary>
        /// Monetary value (Code: M4)
        /// </summary>
        /// <remarks>
        /// A unit of measure expressed as a monetary amount.
        /// </remarks>
        MonetaryValue,

        /// <summary>
        /// Yard per second squared (Code: M40)
        /// </summary>
        /// <remarks>
        /// Unit of the length according to the Anglo-American and Imperial system of units divided by the power of the SI base unit second by exponent 2.
        /// </remarks>
        YardPerSecondSquared,

        /// <summary>
        /// Millimetre per second squared (Code: M41)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the SI base unit metre divided by the power of the SI base unit second by exponent 2.
        /// </remarks>
        MillimetrePerSecondSquared,

        /// <summary>
        /// Mile (statute mile) per second squared (Code: M42)
        /// </summary>
        /// <remarks>
        /// Unit of the length according to the Imperial system of units divided by the power of the SI base unit second by exponent 2.
        /// </remarks>
        Mile_statuteMile_PerSecondSquared,

        /// <summary>
        /// Mil (Code: M43)
        /// </summary>
        /// <remarks>
        /// Unit to indicate an angle at military zone, equal to the 6400th part of the full circle of the 360° or 2·p·rad.
        /// </remarks>
        Mil,

        /// <summary>
        /// Revolution (Code: M44)
        /// </summary>
        /// <remarks>
        /// Unit to identify an angle of the full circle of 360° or 2·p·rad (Refer ISO/TC12 SI Guide).
        /// </remarks>
        Revolution,

        /// <summary>
        /// Degree [unit of angle] per second squared (Code: M45)
        /// </summary>
        /// <remarks>
        /// 360 part of a full circle divided by the power of the SI base unit second and the exponent 2.
        /// </remarks>
        Degree_UnitOfAngle_PerSecondSquared,

        /// <summary>
        /// Revolution per minute (Code: M46)
        /// </summary>
        /// <remarks>
        /// Unit of the angular velocity.
        /// </remarks>
        RevolutionPerMinute,

        /// <summary>
        /// Circular mil (Code: M47)
        /// </summary>
        /// <remarks>
        /// Unit of an area, of which the size is given by a diameter of length of 1 mm (0,001 in) based on the formula: area = p·(diameter/2)².
        /// </remarks>
        CircularMil,

        /// <summary>
        /// Square mile (based on U.S. survey foot) (Code: M48)
        /// </summary>
        /// <remarks>
        /// Unit of the area, which is mainly common in the agriculture and forestry.
        /// </remarks>
        SquareMile_basedOnU_S_SurveyFoot,

        /// <summary>
        /// Chain (based on U.S. survey foot) (Code: M49)
        /// </summary>
        /// <remarks>
        /// Unit of the length according the Anglo-American system of units.
        /// </remarks>
        Chain_basedOnU_S_SurveyFoot,

        /// <summary>
        /// Microcurie (Code: M5)
        /// </summary>
        Microcurie,

        /// <summary>
        /// Furlong (Code: M50)
        /// </summary>
        /// <remarks>
        /// Unit commonly used in Great Britain at rural distances: 1 furlong = 40 rods = 10 chains (UK) = 1/8 mile = 1/10 furlong = 220 yards = 660 foot.
        /// </remarks>
        Furlong,

        /// <summary>
        /// Foot (U.S. survey) (Code: M51)
        /// </summary>
        /// <remarks>
        /// Unit commonly used in the United States for ordnance survey.
        /// </remarks>
        Foot_U_S_Survey,

        /// <summary>
        /// Mile (based on U.S. survey foot) (Code: M52)
        /// </summary>
        /// <remarks>
        /// Unit commonly used in the United States for ordnance survey.
        /// </remarks>
        Mile_basedOnU_S_SurveyFoot,

        /// <summary>
        /// Metre per pascal (Code: M53)
        /// </summary>
        /// <remarks>
        /// SI base unit metre divided by the derived SI unit pascal.
        /// </remarks>
        MetrePerPascal,

        /// <summary>
        /// Metre per radiant (Code: M55)
        /// </summary>
        /// <remarks>
        /// Unit of the translation factor for implementation from rotation to linear movement.
        /// </remarks>
        MetrePerRadiant,

        /// <summary>
        /// Shake (Code: M56)
        /// </summary>
        /// <remarks>
        /// Unit for a very short period.
        /// </remarks>
        Shake,

        /// <summary>
        /// Mile per minute (Code: M57)
        /// </summary>
        /// <remarks>
        /// Unit of velocity from the Imperial system of units.
        /// </remarks>
        MilePerMinute,

        /// <summary>
        /// Mile per second (Code: M58)
        /// </summary>
        /// <remarks>
        /// Unit of the velocity from the Imperial system of units.
        /// </remarks>
        MilePerSecond,

        /// <summary>
        /// Metre per second pascal (Code: M59)
        /// </summary>
        /// <remarks>
        /// SI base unit meter divided by the product of SI base unit second and the derived SI unit pascal.
        /// </remarks>
        MetrePerSecondPascal,

        /// <summary>
        /// Metre per hour (Code: M60)
        /// </summary>
        /// <remarks>
        /// SI base unit metre divided by the unit hour.
        /// </remarks>
        MetrePerHour,

        /// <summary>
        /// Inch per year (Code: M61)
        /// </summary>
        /// <remarks>
        /// Unit of the length according to the Anglo-American and Imperial system of units divided by the unit common year with 365 days.
        /// </remarks>
        InchPerYear,

        /// <summary>
        /// Kilometre per second (Code: M62)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the SI base unit metre divided by the SI base unit second.
        /// </remarks>
        KilometrePerSecond,

        /// <summary>
        /// Inch per minute (Code: M63)
        /// </summary>
        /// <remarks>
        /// Unit inch according to the Anglo-American and Imperial system of units divided by the unit minute.
        /// </remarks>
        InchPerMinute,

        /// <summary>
        /// Yard per second (Code: M64)
        /// </summary>
        /// <remarks>
        /// Unit yard according to the Anglo-American and Imperial system of units divided by the SI base unit second.
        /// </remarks>
        YardPerSecond,

        /// <summary>
        /// Yard per minute (Code: M65)
        /// </summary>
        /// <remarks>
        /// Unit yard according to the Anglo-American and Imperial system of units divided by the unit minute.
        /// </remarks>
        YardPerMinute,

        /// <summary>
        /// Yard per hour (Code: M66)
        /// </summary>
        /// <remarks>
        /// Unit yard according to the Anglo-American and Imperial system of units divided by the unit hour.
        /// </remarks>
        YardPerHour,

        /// <summary>
        /// Acre-foot (based on U.S. survey foot) (Code: M67)
        /// </summary>
        /// <remarks>
        /// Unit of the volume, which is used in the United States to measure/gauge the capacity of reservoirs.
        /// </remarks>
        AcreFoot_basedOnU_S_SurveyFoot,

        /// <summary>
        /// Cord (128 ft3) (Code: M68)
        /// </summary>
        /// <remarks>
        /// Traditional unit of the volume of stacked firewood which has been measured with a cord.
        /// </remarks>
        Cord_128Ft3,

        /// <summary>
        /// Cubic mile (UK statute) (Code: M69)
        /// </summary>
        /// <remarks>
        /// Unit of volume according to the Imperial system of units.
        /// </remarks>
        CubicMile_UKStatute,

        /// <summary>
        /// Micro-inch (Code: M7)
        /// </summary>
        MicroInch,

        /// <summary>
        /// Ton, register (Code: M70)
        /// </summary>
        /// <remarks>
        /// Traditional unit of the cargo capacity.
        /// </remarks>
        Ton_Register,

        /// <summary>
        /// Cubic metre per pascal (Code: M71)
        /// </summary>
        /// <remarks>
        /// Power of the SI base unit meter by exponent 3 divided by the derived SI base unit pascal.
        /// </remarks>
        CubicMetrePerPascal,

        /// <summary>
        /// Bel (Code: M72)
        /// </summary>
        /// <remarks>
        /// Logarithmic relationship to base 10.
        /// </remarks>
        Bel,

        /// <summary>
        /// Kilogram per cubic metre pascal (Code: M73)
        /// </summary>
        /// <remarks>
        /// SI base unit kilogram divided by the product of the power of the SI base unit metre with exponent 3 and the derived SI unit pascal.
        /// </remarks>
        KilogramPerCubicMetrePascal,

        /// <summary>
        /// Kilogram per pascal (Code: M74)
        /// </summary>
        /// <remarks>
        /// SI base unit kilogram divided by the derived SI unit pascal.
        /// </remarks>
        KilogramPerPascal,

        /// <summary>
        /// Kilopound-force (Code: M75)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the unit of the force pound-force (lbf) according to the Anglo-American system of units with the relationship.
        /// </remarks>
        KilopoundForce,

        /// <summary>
        /// Poundal (Code: M76)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the power, which corresponds to a mass of a pound multiplied with the acceleration of a foot per square second.
        /// </remarks>
        Poundal,

        /// <summary>
        /// Kilogram metre per second squared (Code: M77)
        /// </summary>
        /// <remarks>
        /// Product of the SI base unit kilogram and the SI base unit metre divided by the power of the SI base unit second by exponent 2.
        /// </remarks>
        KilogramMetrePerSecondSquared,

        /// <summary>
        /// Pond (Code: M78)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the unit of the weight, defined as a mass of 1 kg which finds out about a weight strength from 1 kp by the gravitational force at sea level which corresponds to a strength of 9,806 65 newton.
        /// </remarks>
        Pond,

        /// <summary>
        /// Square foot per hour (Code: M79)
        /// </summary>
        /// <remarks>
        /// Power of the unit foot according to the Anglo-American and Imperial system of units by exponent 2 divided by the unit of time hour.
        /// </remarks>
        SquareFootPerHour,

        /// <summary>
        /// Stokes per pascal (Code: M80)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit stokes divided by the derived SI unit pascal.
        /// </remarks>
        StokesPerPascal,

        /// <summary>
        /// Square centimetre per second (Code: M81)
        /// </summary>
        /// <remarks>
        /// 0,000 1-fold of the power of the SI base unit metre by exponent 2 divided by the SI base unit second.
        /// </remarks>
        SquareCentimetrePerSecond,

        /// <summary>
        /// Square metre per second pascal (Code: M82)
        /// </summary>
        /// <remarks>
        /// Power of the SI base unit metre with the exponent 2 divided by the SI base unit second and the derived SI unit pascal.
        /// </remarks>
        SquareMetrePerSecondPascal,

        /// <summary>
        /// Denier (Code: M83)
        /// </summary>
        /// <remarks>
        /// Traditional unit for the indication of the linear mass of textile fibers and yarns.
        /// </remarks>
        Denier_IndicatorOfTheLinearMassOfTextileFibersAndYarns,

        /// <summary>
        /// Pound per yard (Code: M84)
        /// </summary>
        /// <remarks>
        /// Unit for linear mass according to avoirdupois system of units.
        /// </remarks>
        PoundPerYard,

        /// <summary>
        /// Ton, assay (Code: M85)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the mass used in the mineralogy to determine the concentration of precious metals in ore according to the mass of the precious metal in milligrams in a sample of the mass of an assay sound (number of troy ounces in a short ton (1 000 lb)).
        /// </remarks>
        Ton_Assay,

        /// <summary>
        /// Pfund (Code: M86)
        /// </summary>
        /// <remarks>
        /// Outdated unit of the mass used in Germany.
        /// </remarks>
        Pfund,

        /// <summary>
        /// Kilogram per second pascal (Code: M87)
        /// </summary>
        /// <remarks>
        /// SI base unit kilogram divided by the product of the SI base unit second and the derived SI unit pascal.
        /// </remarks>
        KilogramPerSecondPascal,

        /// <summary>
        /// Tonne per month (Code: M88)
        /// </summary>
        /// <remarks>
        /// Unit tonne divided by the unit month.
        /// </remarks>
        TonnePerMonth,

        /// <summary>
        /// Tonne per year (Code: M89)
        /// </summary>
        /// <remarks>
        /// Unit tonne divided by the unit year with 365 days.
        /// </remarks>
        TonnePerYear,

        /// <summary>
        /// Million Btu per 1000 cubic foot (Code: M9)
        /// </summary>
        MillionBtuPer1000CubicFoot,

        /// <summary>
        /// Kilopound per hour (Code: M90)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the unit of the mass avoirdupois pound according to the avoirdupois unit system divided by the unit hour.
        /// </remarks>
        KilopoundPerHour,

        /// <summary>
        /// Pound per pound (Code: M91)
        /// </summary>
        /// <remarks>
        /// Proportion of the mass consisting of the avoirdupois pound according to the avoirdupois unit system divided by the avoirdupois pound according to the avoirdupois unit system.
        /// </remarks>
        PoundPerPound,

        /// <summary>
        /// Pound-force foot (Code: M92)
        /// </summary>
        /// <remarks>
        /// Product of the unit pound-force according to the Anglo-American system of units and the unit foot according to the Anglo-American and the Imperial system of units.
        /// </remarks>
        PoundForceFoot,

        /// <summary>
        /// Newton metre per radian (Code: M93)
        /// </summary>
        /// <remarks>
        /// Product of the derived SI unit newton and the SI base unit metre divided by the unit radian.
        /// </remarks>
        NewtonMetrePerRadian,

        /// <summary>
        /// Kilogram metre (Code: M94)
        /// </summary>
        /// <remarks>
        /// Unit of imbalance as a product of the SI base unit kilogram and the SI base unit metre.
        /// </remarks>
        KilogramMetre,

        /// <summary>
        /// Poundal foot (Code: M95)
        /// </summary>
        /// <remarks>
        /// Product of the non SI-conforming unit of the force poundal and the unit foot according to the Anglo-American and Imperial system of units .
        /// </remarks>
        PoundalFoot,

        /// <summary>
        /// Poundal inch (Code: M96)
        /// </summary>
        /// <remarks>
        /// Product of the non SI-conforming unit of the force poundal and the unit inch according to the Anglo-American and Imperial system of units .
        /// </remarks>
        PoundalInch,

        /// <summary>
        /// Dyne metre (Code: M97)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit of the rotational moment.
        /// </remarks>
        DyneMetre,

        /// <summary>
        /// Kilogram centimetre per second (Code: M98)
        /// </summary>
        /// <remarks>
        /// Product of the SI base unit kilogram and the 0,01-fold of the SI base unit metre divided by the SI base unit second.
        /// </remarks>
        KilogramCentimetrePerSecond,

        /// <summary>
        /// Gram centimetre per second (Code: M99)
        /// </summary>
        /// <remarks>
        /// Product of the 0,001-fold of the SI base unit kilogram and the 0,01-fold of the SI base unit metre divided by the SI base unit second.
        /// </remarks>
        GramCentimetrePerSecond,

        /// <summary>
        /// Megavolt ampere reactive hour (Code: MAH)
        /// </summary>
        /// <remarks>
        /// A unit of electrical reactive power defining the total amount of reactive power across a power system.
        /// </remarks>
        MegavoltAmpereReactiveHour,

        /// <summary>
        /// Megalitre (Code: MAL)
        /// </summary>
        Megalitre,

        /// <summary>
        /// Megametre (Code: MAM)
        /// </summary>
        Megametre,

        /// <summary>
        /// Megavar (Code: MAR)
        /// </summary>
        /// <remarks>
        /// A unit of electrical reactive power represented by a current of one thousand amperes flowing due a potential difference of one thousand volts where the sine of the phase angle between them is 1.
        /// </remarks>
        Megavar,

        /// <summary>
        /// Megawatt (Code: MAW)
        /// </summary>
        /// <remarks>
        /// A unit of power defining the rate of energy transferred or consumed when a current of 1000 amperes flows due to a potential of 1000 volts at unity power factor.
        /// </remarks>
        Megawatt,

        /// <summary>
        /// Thousand standard brick equivalent (Code: MBE)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of one thousand brick equivalent units.
        /// </remarks>
        ThousandStandardBrickEquivalent,

        /// <summary>
        /// Thousand board foot (Code: MBF)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one thousand board foot.
        /// </remarks>
        ThousandBoardFoot,

        /// <summary>
        /// Millibar (Code: MBR)
        /// </summary>
        Millibar,

        /// <summary>
        /// Microgram (Code: MC)
        /// </summary>
        Microgram,

        /// <summary>
        /// Millicurie (Code: MCU)
        /// </summary>
        Millicurie,

        /// <summary>
        /// Air dry metric ton (Code: MD)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of metric tons of a product, disregarding the water content of the product.
        /// </remarks>
        AirDryMetricTon,

        /// <summary>
        /// Milligram (Code: MGM)
        /// </summary>
        Milligram,

        /// <summary>
        /// Megahertz (Code: MHZ)
        /// </summary>
        Megahertz,

        /// <summary>
        /// Square mile (statute mile) (Code: MIK)
        /// </summary>
        SquareMile_statuteMile,

        /// <summary>
        /// Thousand (Code: MIL)
        /// </summary>
        Thousand,

        /// <summary>
        /// Minute [unit of time] (Code: MIN)
        /// </summary>
        Minute_UnitOfTime,

        /// <summary>
        /// Million (Code: MIO)
        /// </summary>
        Million,

        /// <summary>
        /// Million international unit (Code: MIU)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of international units in multiples of 10.
        /// </remarks>
        MillionInternationalUnit,

        /// <summary>
        /// Square Metre Day (Code: MKD)
        /// </summary>
        SquareMetreDay,

        /// <summary>
        /// Square Metre Month (Code: MKM)
        /// </summary>
        SquareMetreMonth,

        /// <summary>
        /// Square Metre Week (Code: MKW)
        /// </summary>
        SquareMetreWeek,

        /// <summary>
        /// Milliard (Code: MLD)
        /// </summary>
        /// <remarks>
        /// Synonym: billion (US)
        /// </remarks>
        Milliard,

        /// <summary>
        /// Millilitre (Code: MLT)
        /// </summary>
        Millilitre,

        /// <summary>
        /// Square millimetre (Code: MMK)
        /// </summary>
        SquareMillimetre,

        /// <summary>
        /// Cubic millimetre (Code: MMQ)
        /// </summary>
        CubicMillimetre,

        /// <summary>
        /// Millimetre (Code: MMT)
        /// </summary>
        Millimetre,

        /// <summary>
        /// Kilogram, dry weight (Code: MND)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of kilograms of a product, disregarding the water content of the product.
        /// </remarks>
        Kilogram_DryWeight,

        /// <summary>
        /// Mega Joule per Normalised cubic Metre (Code: MNJ)
        /// </summary>
        MegaJoulePerNormalisedCubicMetre,

        /// <summary>
        /// Month (Code: MON)
        /// </summary>
        /// <remarks>
        /// Unit of time equal to 1/12 of a year of 365,25 days.
        /// </remarks>
        Month,

        /// <summary>
        /// Megapascal (Code: MPA)
        /// </summary>
        Megapascal,

        /// <summary>
        /// Cubic Metre Day (Code: MQD)
        /// </summary>
        CubicMetreDay,

        /// <summary>
        /// Cubic metre per hour (Code: MQH)
        /// </summary>
        CubicMetrePerHour,

        /// <summary>
        /// Cubic Metre Month (Code: MQM)
        /// </summary>
        CubicMetreMonth,

        /// <summary>
        /// Cubic metre per second (Code: MQS)
        /// </summary>
        CubicMetrePerSecond,

        /// <summary>
        /// Cubic Metre Week (Code: MQW)
        /// </summary>
        CubicMetreWeek,

        /// <summary>
        /// Metre Day (Code: MRD)
        /// </summary>
        MetreDay,

        /// <summary>
        /// Metre Month (Code: MRM)
        /// </summary>
        MetreMonth,

        /// <summary>
        /// Metre Week (Code: MRW)
        /// </summary>
        MetreWeek,

        /// <summary>
        /// Metre per second squared (Code: MSK)
        /// </summary>
        MetrePerSecondSquared,

        /// <summary>
        /// Square metre (Code: MTK)
        /// </summary>
        SquareMetre,

        /// <summary>
        /// Cubic metre (Code: MTQ)
        /// </summary>
        /// <remarks>
        /// Synonym: metre cubed
        /// </remarks>
        CubicMetre,

        /// <summary>
        /// Metre (Code: MTR)
        /// </summary>
        Metre,

        /// <summary>
        /// Metre per second (Code: MTS)
        /// </summary>
        MetrePerSecond,

        /// <summary>
        /// Milihertz (Code: MTZ)
        /// </summary>
        Milihertz,

        /// <summary>
        /// Megavolt - ampere (Code: MVA)
        /// </summary>
        MegavoltAmpere,

        /// <summary>
        /// Megawatt hour (1000 kW.h) (Code: MWH)
        /// </summary>
        /// <remarks>
        /// A unit of power defining the total amount of bulk energy transferred or consumed.
        /// </remarks>
        MegawattHour_1000KW_h,

        /// <summary>
        /// Pen calorie (Code: N1)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of calories prescribed daily for parenteral/enteral therapy.
        /// </remarks>
        PenCalorie,

        /// <summary>
        /// Pound foot per second (Code: N10)
        /// </summary>
        /// <remarks>
        /// Product of the avoirdupois pound according to the avoirdupois unit system and the unit foot according to the Anglo-American and Imperial system of units divided by the SI base unit second.
        /// </remarks>
        PoundFootPerSecond,

        /// <summary>
        /// Pound inch per second (Code: N11)
        /// </summary>
        /// <remarks>
        /// Product of the avoirdupois pound according to the avoirdupois unit system and the unit inch according to the Anglo-American and Imperial system of units divided by the SI base unit second.
        /// </remarks>
        PoundInchPerSecond,

        /// <summary>
        /// Pferdestaerke (Code: N12)
        /// </summary>
        /// <remarks>
        /// Obsolete unit of the power relating to DIN 1301-3:1979: 1 PS = 735,498 75 W.
        /// </remarks>
        Pferdestaerke,

        /// <summary>
        /// Centimetre of mercury (0 ºC) (Code: N13)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of pressure, at which a value of 1 cmHg meets the static pressure, which is generated by a mercury at a temperature of 0 °C with a height of 1 centimetre .
        /// </remarks>
        CentimetreOfMercury_0ºC,

        /// <summary>
        /// Centimetre of water (4 ºC) (Code: N14)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of pressure, at which a value of 1 cmH2O meets the static pressure, which is generated by a head of water at a temperature of 4 °C with a height of 1 centimetre .
        /// </remarks>
        CentimetreOfWater_4ºC,

        /// <summary>
        /// Foot of water (39.2 ºF) (Code: N15)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 ftH2O is equivalent to the static pressure, which is generated by a head of water at a temperature 39,2°F with a height of 1 foot .
        /// </remarks>
        FootOfWater_39_2ºF,

        /// <summary>
        /// Inch of mercury (32 ºF) (Code: N16)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 inHg meets the static pressure, which is generated by a mercury at a temperature of 32°F with a height of 1 inch.
        /// </remarks>
        InchOfMercury_32ºF,

        /// <summary>
        /// Inch of mercury (60 ºF) (Code: N17)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 inHg meets the static pressure, which is generated by a mercury at a temperature of 60°F with a height of 1 inch.
        /// </remarks>
        InchOfMercury_60ºF,

        /// <summary>
        /// Inch of water (39.2 ºF) (Code: N18)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 inH2O meets the static pressure, which is generated by a head of water at a temperature of 39,2°F with a height of 1 inch .
        /// </remarks>
        InchOfWater_39_2ºF,

        /// <summary>
        /// Inch of water (60 ºF) (Code: N19)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 inH2O meets the static pressure, which is generated by a head of water at a temperature of 60°F with a height of 1 inch .
        /// </remarks>
        InchOfWater_60ºF,

        /// <summary>
        /// Kip per square inch (Code: N20)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the pressure according to the Anglo-American system of units as the 1000-fold of the unit of the force pound-force divided by the power of the unit inch by exponent 2.
        /// </remarks>
        KipPerSquareInch,

        /// <summary>
        /// Poundal per square foot (Code: N21)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of pressure by the Imperial system of units according to NIST: 1 pdl/ft² = 1,488 164 Pa.
        /// </remarks>
        PoundalPerSquareFoot,

        /// <summary>
        /// Ounce (avoirdupois) per square inch (Code: N22)
        /// </summary>
        /// <remarks>
        /// Unit of the surface specific mass (avoirdupois ounce according to the avoirdupois system of units according to the surface square inch according to the Anglo-American and Imperial system of units).
        /// </remarks>
        Ounce_avoirdupois_PerSquareInch,

        /// <summary>
        /// Conventional metre of water (Code: N23)
        /// </summary>
        /// <remarks>
        /// Not SI-conforming unit of pressure, whereas a value of 1 mH2O is equivalent to the static pressure, which is produced by one metre high water column .
        /// </remarks>
        ConventionalMetreOfWater,

        /// <summary>
        /// Gram per square millimetre (Code: N24)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the SI base unit kilogram divided by the 0.000 001-fold of the power of the SI base unit meter by exponent 2.
        /// </remarks>
        GramPerSquareMillimetre,

        /// <summary>
        /// Pound per square yard (Code: N25)
        /// </summary>
        /// <remarks>
        /// Unit for areal-related mass as a unit pound according to the avoirdupois unit system divided by the power of the unit yard according to the Anglo-American and Imperial system of units with exponent 2.
        /// </remarks>
        PoundPerSquareYard,

        /// <summary>
        /// Poundal per square inch (Code: N26)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the pressure according to the Imperial system of units (poundal by square inch).
        /// </remarks>
        PoundalPerSquareInch,

        /// <summary>
        /// Foot to the fourth power (Code: N27)
        /// </summary>
        /// <remarks>
        /// Power of the unit foot according to the Anglo-American and Imperial system of units by exponent 4 according to NIST: 1 ft4 = 8,630 975 m4.
        /// </remarks>
        FootToTheFourthPower,

        /// <summary>
        /// Cubic decimetre per kilogram (Code: N28)
        /// </summary>
        /// <remarks>
        /// 0,001 fold of the power of the SI base unit meter by exponent 3 divided by the SI based unit kilogram.
        /// </remarks>
        CubicDecimetrePerKilogram,

        /// <summary>
        /// Cubic foot per pound (Code: N29)
        /// </summary>
        /// <remarks>
        /// Power of the unit foot according to the Anglo-American and Imperial system of units by exponent 3 divided by the unit avoirdupois pound according to the avoirdupois unit system.
        /// </remarks>
        CubicFootPerPound,

        /// <summary>
        /// Print point (Code: N3)
        /// </summary>
        PrintPoint,

        /// <summary>
        /// Cubic inch per pound (Code: N30)
        /// </summary>
        /// <remarks>
        /// Power of the unit inch according to the Anglo-American and Imperial system of units by exponent 3 divided by the avoirdupois pound according to the avoirdupois unit system .
        /// </remarks>
        CubicInchPerPound,

        /// <summary>
        /// Kilonewton per metre (Code: N31)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the derived SI unit newton divided by the SI base unit metre.
        /// </remarks>
        KilonewtonPerMetre,

        /// <summary>
        /// Poundal per inch (Code: N32)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the surface tension according to the Imperial unit system as quotient poundal by inch.
        /// </remarks>
        PoundalPerInch,

        /// <summary>
        /// Pound-force per yard (Code: N33)
        /// </summary>
        /// <remarks>
        /// Unit of force per unit length based on the Anglo-American system of units.
        /// </remarks>
        PoundForcePerYard,

        /// <summary>
        /// Poundal second per square foot (Code: N34)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of viscosity.
        /// </remarks>
        PoundalSecondPerSquareFoot,

        /// <summary>
        /// Poise per pascal (Code: N35)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit poise divided by the derived SI unit pascal.
        /// </remarks>
        PoisePerPascal,

        /// <summary>
        /// Newton second per square metre (Code: N36)
        /// </summary>
        /// <remarks>
        /// Unit of the dynamic viscosity as a product of unit of the pressure (newton by square metre) multiplied with the SI base unit second.
        /// </remarks>
        NewtonSecondPerSquareMetre,

        /// <summary>
        /// Kilogram per metre second (Code: N37)
        /// </summary>
        /// <remarks>
        /// Unit of the dynamic viscosity as a quotient SI base unit kilogram divided by the SI base unit metre and by the SI base unit second.
        /// </remarks>
        KilogramPerMetreSecond,

        /// <summary>
        /// Kilogram per metre minute (Code: N38)
        /// </summary>
        /// <remarks>
        /// Unit of the dynamic viscosity as a quotient SI base unit kilogram divided by the SI base unit metre and by the unit minute.
        /// </remarks>
        KilogramPerMetreMinute,

        /// <summary>
        /// Kilogram per metre day (Code: N39)
        /// </summary>
        /// <remarks>
        /// Unit of the dynamic viscosity as a quotient SI base unit kilogram divided by the SI base unit metre and by the unit day.
        /// </remarks>
        KilogramPerMetreDay,

        /// <summary>
        /// Kilogram per metre hour (Code: N40)
        /// </summary>
        /// <remarks>
        /// Unit of the dynamic viscosity as a quotient SI base unit kilogram divided by the SI base unit metre and by the unit hour.
        /// </remarks>
        KilogramPerMetreHour,

        /// <summary>
        /// Gram per centimetre second (Code: N41)
        /// </summary>
        /// <remarks>
        /// Unit of the dynamic viscosity as a quotient of the 0,001-fold of the SI base unit kilogram divided by the 0,01-fold of the SI base unit metre and SI base unit second.
        /// </remarks>
        GramPerCentimetreSecond,

        /// <summary>
        /// Poundal second per square inch (Code: N42)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of dynamic viscosity according to the Imperial system of units as product unit of the pressure (poundal by square inch) multiplied by the SI base unit second.
        /// </remarks>
        PoundalSecondPerSquareInch,

        /// <summary>
        /// Pound per foot minute (Code: N43)
        /// </summary>
        /// <remarks>
        /// Unit of the dynamic viscosity according to the Anglo-American unit system.
        /// </remarks>
        PoundPerFootMinute,

        /// <summary>
        /// Pound per foot day (Code: N44)
        /// </summary>
        /// <remarks>
        /// Unit of the dynamic viscosity according to the Anglo-American unit system.
        /// </remarks>
        PoundPerFootDay,

        /// <summary>
        /// Cubic metre per second pascal (Code: N45)
        /// </summary>
        /// <remarks>
        /// Power of the SI base unit meter by exponent 3 divided by the product of the SI base unit second and the derived SI base unit pascal.
        /// </remarks>
        CubicMetrePerSecondPascal,

        /// <summary>
        /// Foot poundal (Code: N46)
        /// </summary>
        /// <remarks>
        /// Unit of the work (force-path).
        /// </remarks>
        FootPoundal,

        /// <summary>
        /// Inch poundal (Code: N47)
        /// </summary>
        /// <remarks>
        /// Unit of work (force multiplied by path) according to the Imperial system of units as a product unit inch multiplied by poundal.
        /// </remarks>
        InchPoundal,

        /// <summary>
        /// Watt per square centimetre (Code: N48)
        /// </summary>
        /// <remarks>
        /// Derived SI unit watt divided by the power of the 0,01-fold the SI base unit metre by exponent 2.
        /// </remarks>
        WattPerSquareCentimetre,

        /// <summary>
        /// Watt per square inch (Code: N49)
        /// </summary>
        /// <remarks>
        /// Derived SI unit watt divided by the power of the unit inch according to the Anglo-American and Imperial system of units by exponent 2.
        /// </remarks>
        WattPerSquareInch,

        /// <summary>
        /// British thermal unit (international table) per square foot hour (Code: N50)
        /// </summary>
        /// <remarks>
        /// Unit of the surface heat flux according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_internationalTable_PerSquareFootHour,

        /// <summary>
        /// British thermal unit (thermochemical) per square foot hour (Code: N51)
        /// </summary>
        /// <remarks>
        /// Unit of the surface heat flux according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerSquareFootHour,

        /// <summary>
        /// British thermal unit (thermochemical) per square foot minute (Code: N52)
        /// </summary>
        /// <remarks>
        /// Unit of the surface heat flux according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerSquareFootMinute,

        /// <summary>
        /// British thermal unit (international table) per square foot second (Code: N53)
        /// </summary>
        /// <remarks>
        /// Unit of the surface heat flux according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_internationalTable_PerSquareFootSecond,

        /// <summary>
        /// British thermal unit (thermochemical) per square foot second (Code: N54)
        /// </summary>
        /// <remarks>
        /// Unit of the surface heat flux according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerSquareFootSecond,

        /// <summary>
        /// British thermal unit (international table) per square inch second (Code: N55)
        /// </summary>
        /// <remarks>
        /// Unit of the surface heat flux according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_internationalTable_PerSquareInchSecond,

        /// <summary>
        /// Calorie (thermochemical) per square centimetre minute (Code: N56)
        /// </summary>
        /// <remarks>
        /// Unit of the surface heat flux according to the Imperial system of units.
        /// </remarks>
        Calorie_thermochemical_PerSquareCentimetreMinute,

        /// <summary>
        /// Calorie (thermochemical) per square centimetre second (Code: N57)
        /// </summary>
        /// <remarks>
        /// Unit of the surface heat flux according to the Imperial system of units.
        /// </remarks>
        Calorie_thermochemical_PerSquareCentimetreSecond,

        /// <summary>
        /// British thermal unit (international table) per cubic foot (Code: N58)
        /// </summary>
        /// <remarks>
        /// Unit of the energy density according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_internationalTable_PerCubicFoot,

        /// <summary>
        /// British thermal unit (thermochemical) per cubic foot (Code: N59)
        /// </summary>
        /// <remarks>
        /// Unit of the energy density according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerCubicFoot,

        /// <summary>
        /// British thermal unit (international table) per degree Fahrenheit (Code: N60)
        /// </summary>
        /// <remarks>
        /// Unit of the heat capacity according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_internationalTable_PerDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (thermochemical) per degree Fahrenheit (Code: N61)
        /// </summary>
        /// <remarks>
        /// Unit of the heat capacity according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (international table) per degree Rankine (Code: N62)
        /// </summary>
        /// <remarks>
        /// Unit of the heat capacity according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_internationalTable_PerDegreeRankine,

        /// <summary>
        /// British thermal unit (thermochemical) per degree Rankine (Code: N63)
        /// </summary>
        /// <remarks>
        /// Unit of the heat capacity according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerDegreeRankine,

        /// <summary>
        /// British thermal unit (thermochemical) per pound degree Rankine (Code: N64)
        /// </summary>
        /// <remarks>
        /// Unit of the heat capacity (British thermal unit according to the international table according to the Rankine degree) according to the Imperial system of units divided by the unit avoirdupois pound according to the avoirdupois system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerPoundDegreeRankine,

        /// <summary>
        /// Kilocalorie (international table) per gram kelvin (Code: N65)
        /// </summary>
        /// <remarks>
        /// Unit of the mass-related heat capacity as quotient 1000-fold of the calorie (international table) divided by the product of the 0,001-fold of the SI base units kilogram and kelvin.
        /// </remarks>
        Kilocalorie_internationalTable_PerGramKelvin,

        /// <summary>
        /// British thermal unit (39 ºF) (Code: N66)
        /// </summary>
        /// <remarks>
        /// Unit of heat energy according to the Imperial system of units in a reference temperature of 39 °F.
        /// </remarks>
        BritishThermalUnit_39ºF,

        /// <summary>
        /// British thermal unit (59 ºF) (Code: N67)
        /// </summary>
        /// <remarks>
        /// Unit of heat energy according to the Imperial system of units in a reference temperature of 59 °F.
        /// </remarks>
        BritishThermalUnit_59ºF,

        /// <summary>
        /// British thermal unit (60 ºF) (Code: N68)
        /// </summary>
        /// <remarks>
        /// Unit of head energy according to the Imperial system of units at a reference temperature of 60 °F.
        /// </remarks>
        BritishThermalUnit_60ºF,

        /// <summary>
        /// Calorie (20 ºC) (Code: N69)
        /// </summary>
        /// <remarks>
        /// Unit for quantity of heat, which is to be required for 1 g air free water at a constant pressure from 101,325 kPa, to warm up the pressure of standard atmosphere at sea level, from 19,5 °C on 20,5 °C.
        /// </remarks>
        Calorie_20ºC,

        /// <summary>
        /// Quad (1015 BtuIT) (Code: N70)
        /// </summary>
        /// <remarks>
        /// Unit of heat energy according to the imperial system of units.
        /// </remarks>
        Quad_1015BtuIT,

        /// <summary>
        /// Therm (EC) (Code: N71)
        /// </summary>
        /// <remarks>
        /// Unit of heat energy in commercial use, within the EU defined: 1 thm (EC) = 100 000 BtuIT.
        /// </remarks>
        Therm_EC,

        /// <summary>
        /// Therm (U.S.) (Code: N72)
        /// </summary>
        /// <remarks>
        /// Unit of heat energy in commercial use.
        /// </remarks>
        Therm_U_S,

        /// <summary>
        /// British thermal unit (thermochemical) per pound (Code: N73)
        /// </summary>
        /// <remarks>
        /// Unit of the heat energy according to the Imperial system of units divided the unit avoirdupois pound according to the avoirdupois system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerPound,

        /// <summary>
        /// British thermal unit (international table) per hour square foot degree Fahrenheit (Code: N74)
        /// </summary>
        /// <remarks>
        /// Unit of the heat transition coefficient according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_internationalTable_PerHourSquareFootDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (thermochemical) per hour square foot degree Fahrenheit (Code: N75)
        /// </summary>
        /// <remarks>
        /// Unit of the heat transition coefficient according to the imperial system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerHourSquareFootDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (international table) per second square foot degree Fahrenheit (Code: N76)
        /// </summary>
        /// <remarks>
        /// Unit of the heat transition coefficient according to the imperial system of units.
        /// </remarks>
        BritishThermalUnit_internationalTable_PerSecondSquareFootDegreeFahrenheit,

        /// <summary>
        /// British thermal unit (thermochemical) per second square foot degree Fahrenheit (Code: N77)
        /// </summary>
        /// <remarks>
        /// Unit of the heat transition coefficient according to the imperial system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerSecondSquareFootDegreeFahrenheit,

        /// <summary>
        /// Kilowatt per square metre kelvin (Code: N78)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the derived SI unit watt divided by the product of the power of the SI base unit metre by exponent 2 and the SI base unit kelvin.
        /// </remarks>
        KilowattPerSquareMetreKelvin,

        /// <summary>
        /// Kelvin per pascal (Code: N79)
        /// </summary>
        /// <remarks>
        /// SI base unit kelvin divided by the derived SI unit pascal.
        /// </remarks>
        KelvinPerPascal,

        /// <summary>
        /// Watt per metre degree Celsius (Code: N80)
        /// </summary>
        /// <remarks>
        /// Derived SI unit watt divided by the product of the SI base unit metre and the unit for temperature degree Celsius.
        /// </remarks>
        WattPerMetreDegreeCelsius,

        /// <summary>
        /// Kilowatt per metre kelvin (Code: N81)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the derived SI unit watt divided by the product of the SI base unit metre and the SI base unit kelvin.
        /// </remarks>
        KilowattPerMetreKelvin,

        /// <summary>
        /// Kilowatt per metre degree Celsius (Code: N82)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the derived SI unit watt divided by the product of the SI base unit metre and the unit for temperature degree Celsius.
        /// </remarks>
        KilowattPerMetreDegreeCelsius,

        /// <summary>
        /// Metre per degree Celcius metre (Code: N83)
        /// </summary>
        /// <remarks>
        /// SI base unit metre divided by the product of the unit degree Celsius and the SI base unit metre.
        /// </remarks>
        MetrePerDegreeCelciusMetre,

        /// <summary>
        /// Degree Fahrenheit hour per British thermal unit (international table) (Code: N84)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the thermal resistance according to the Imperial system of units.
        /// </remarks>
        DegreeFahrenheitHourPerBritishThermalUnit_internationalTable,

        /// <summary>
        /// Degree Fahrenheit hour per British thermal unit (thermochemical) (Code: N85)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the thermal resistance according to the Imperial system of units.
        /// </remarks>
        DegreeFahrenheitHourPerBritishThermalUnit_thermochemical,

        /// <summary>
        /// Degree Fahrenheit second per British thermal unit (international table) (Code: N86)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the thermal resistance according to the Imperial system of units.
        /// </remarks>
        DegreeFahrenheitSecondPerBritishThermalUnit_internationalTable,

        /// <summary>
        /// Degree Fahrenheit second per British thermal unit (thermochemical) (Code: N87)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the thermal resistance according to the Imperial system of units.
        /// </remarks>
        DegreeFahrenheitSecondPerBritishThermalUnit_thermochemical,

        /// <summary>
        /// Degree Fahrenheit hour square foot per British thermal unit (international table) inch (Code: N88)
        /// </summary>
        /// <remarks>
        /// Unit of specific thermal resistance according to the Imperial system of units.
        /// </remarks>
        DegreeFahrenheitHourSquareFootPerBritishThermalUnit_internationalTable_Inch,

        /// <summary>
        /// Degree Fahrenheit hour square foot per British thermal unit (thermochemical) inch (Code: N89)
        /// </summary>
        /// <remarks>
        /// Unit of specific thermal resistance according to the Imperial system of units.
        /// </remarks>
        DegreeFahrenheitHourSquareFootPerBritishThermalUnit_thermochemical_Inch,

        /// <summary>
        /// Kilofarad (Code: N90)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the derived SI unit farad.
        /// </remarks>
        Kilofarad,

        /// <summary>
        /// Reciprocal joule (Code: N91)
        /// </summary>
        /// <remarks>
        /// Reciprocal of the derived SI unit joule.
        /// </remarks>
        ReciprocalJoule,

        /// <summary>
        /// Picosiemens (Code: N92)
        /// </summary>
        /// <remarks>
        /// 0,000 000 000 001-fold of the derived SI unit siemens.
        /// </remarks>
        Picosiemens,

        /// <summary>
        /// Ampere per pascal (Code: N93)
        /// </summary>
        /// <remarks>
        /// SI base unit ampere divided by the derived SI unit pascal.
        /// </remarks>
        AmperePerPascal,

        /// <summary>
        /// Franklin (Code: N94)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit of the electrical charge, where the charge amounts to exactly 1 Fr where the force of 1 dyn on an equal load is performed at a distance of 1 cm.
        /// </remarks>
        Franklin,

        /// <summary>
        /// Ampere minute (Code: N95)
        /// </summary>
        /// <remarks>
        /// A unit of electric charge defining the amount of charge accumulated by a steady flow of one ampere for one minute..
        /// </remarks>
        AmpereMinute,

        /// <summary>
        /// Biot (Code: N96)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit of the electric power which is defined by a force of 2 dyn per cm between two parallel conductors of infinite length with negligible cross-section in the distance of 1 cm.
        /// </remarks>
        Biot,

        /// <summary>
        /// Gilbert (Code: N97)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit of the magnetomotive force, which is defined by the work to increase the magnetic potential of a positive common pol with 1 erg.
        /// </remarks>
        Gilbert,

        /// <summary>
        /// Volt per pascal (Code: N98)
        /// </summary>
        /// <remarks>
        /// Derived SI unit volt divided by the derived SI unit pascal.
        /// </remarks>
        VoltPerPascal,

        /// <summary>
        /// Picovolt (Code: N99)
        /// </summary>
        /// <remarks>
        /// 0,000 000 000 001-fold of the derived SI unit volt.
        /// </remarks>
        Picovolt,

        /// <summary>
        /// Milligram per kilogram (Code: NA)
        /// </summary>
        MilligramPerKilogram,

        /// <summary>
        /// Number of articles (Code: NAR)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of articles (article: item).
        /// </remarks>
        NumberOfArticles,

        /// <summary>
        /// Number of cells (Code: NCL)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of cells (cell: an enclosed or circumscribed space, cavity, or volume).
        /// </remarks>
        NumberOfCells,

        /// <summary>
        /// Newton (Code: NEW)
        /// </summary>
        Newton,

        /// <summary>
        /// Message (Code: NF)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of messages.
        /// </remarks>
        Message,

        /// <summary>
        /// Nil (Code: NIL)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of instances of nothing.
        /// </remarks>
        Nil,

        /// <summary>
        /// Number of international units (Code: NIU)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of international units.
        /// </remarks>
        NumberOfInternationalUnits,

        /// <summary>
        /// Load (Code: NL)
        /// </summary>
        /// <remarks>
        /// A unit of volume defining the number of loads (load: a quantity of items carried or processed at one time).
        /// </remarks>
        Load,

        /// <summary>
        /// Normalised cubic metre (Code: NM3)
        /// </summary>
        /// <remarks>
        /// Normalised cubic metre (temperature 0°C and pressure 101325 millibars )
        /// </remarks>
        NormalisedCubicMetre,

        /// <summary>
        /// Nautical mile (Code: NMI)
        /// </summary>
        NauticalMile,

        /// <summary>
        /// Number of packs (Code: NMP)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of packs (pack: a collection of objects packaged together).
        /// </remarks>
        NumberOfPacks,

        /// <summary>
        /// Number of parts (Code: NPT)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of parts (part: component of a larger entity).
        /// </remarks>
        NumberOfParts,

        /// <summary>
        /// Net ton (Code: NT)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to 2000 pounds, see ton (US). Refer International Convention on tonnage measurement of Ships.
        /// </remarks>
        NetTon,

        /// <summary>
        /// Nephelometric turbidity unit (Code: NTU)
        /// </summary>
        NephelometricTurbidityUnit,

        /// <summary>
        /// Newton metre (Code: NU)
        /// </summary>
        NewtonMetre,

        /// <summary>
        /// Part per thousand (Code: NX)
        /// </summary>
        /// <remarks>
        /// A unit of proportion equal to 10⁻³. Synonym: per mille
        /// </remarks>
        PartPerThousand,

        /// <summary>
        /// Panel (Code: OA)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of panels (panel: a distinct, usually rectangular, section of a surface).
        /// </remarks>
        Panel,

        /// <summary>
        /// Ozone depletion equivalent (Code: ODE)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the ozone depletion potential in kilograms of a product relative to the calculated depletion for the reference substance, Trichlorofluoromethane (CFC-11).
        /// </remarks>
        OzoneDepletionEquivalent,

        /// <summary>
        /// ODS Grams (Code: ODG)
        /// </summary>
        ODSGrams,

        /// <summary>
        /// ODS Kilograms (Code: ODK)
        /// </summary>
        ODSKilograms,

        /// <summary>
        /// ODS Milligrams (Code: ODM)
        /// </summary>
        ODSMilligrams,

        /// <summary>
        /// Ohm (Code: OHM)
        /// </summary>
        Ohm,

        /// <summary>
        /// Ounce per square yard (Code: ON)
        /// </summary>
        OuncePerSquareYard,

        /// <summary>
        /// Ounce (avoirdupois) (Code: ONZ)
        /// </summary>
        Ounce_avoirdupois,

        /// <summary>
        /// Oscillations per minute (Code: OPM)
        /// </summary>
        /// <remarks>
        /// The number of oscillations per minute.
        /// </remarks>
        OscillationsPerMinute,

        /// <summary>
        /// Overtime hour (Code: OT)
        /// </summary>
        /// <remarks>
        /// A unit of time defining the number of overtime hours.
        /// </remarks>
        OvertimeHour,

        /// <summary>
        /// Fluid ounce (US) (Code: OZA)
        /// </summary>
        FluidOunce_US,

        /// <summary>
        /// Fluid ounce (UK) (Code: OZI)
        /// </summary>
        FluidOunce_UK,

        /// <summary>
        /// Percent (Code: P1)
        /// </summary>
        /// <remarks>
        /// A unit of proportion equal to 0.01.
        /// </remarks>
        Percent,

        /// <summary>
        /// Coulomb per metre (Code: P10)
        /// </summary>
        /// <remarks>
        /// Derived SI unit coulomb divided by the SI base unit metre.
        /// </remarks>
        CoulombPerMetre,

        /// <summary>
        /// Kiloweber (Code: P11)
        /// </summary>
        /// <remarks>
        /// 1000 fold of the derived SI unit weber.
        /// </remarks>
        Kiloweber,

        /// <summary>
        /// Gamma (Code: P12)
        /// </summary>
        /// <remarks>
        /// Unit of magnetic flow density.
        /// </remarks>
        Gamma,

        /// <summary>
        /// Kilotesla (Code: P13)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the derived SI unit tesla.
        /// </remarks>
        Kilotesla,

        /// <summary>
        /// Joule per second (Code: P14)
        /// </summary>
        /// <remarks>
        /// Quotient of the derived SI unit joule divided by the SI base unit second.
        /// </remarks>
        JoulePerSecond,

        /// <summary>
        /// Joule per minute (Code: P15)
        /// </summary>
        /// <remarks>
        /// Quotient from the derived SI unit joule divided by the unit minute.
        /// </remarks>
        JoulePerMinute,

        /// <summary>
        /// Joule per hour (Code: P16)
        /// </summary>
        /// <remarks>
        /// Quotient from the derived SI unit joule divided by the unit hour.
        /// </remarks>
        JoulePerHour,

        /// <summary>
        /// Joule per day (Code: P17)
        /// </summary>
        /// <remarks>
        /// Quotient from the derived SI unit joule divided by the unit day.
        /// </remarks>
        JoulePerDay,

        /// <summary>
        /// Kilojoule per second (Code: P18)
        /// </summary>
        /// <remarks>
        /// Quotient from the 1000-fold of the derived SI unit joule divided by the SI base unit second.
        /// </remarks>
        KilojoulePerSecond,

        /// <summary>
        /// Kilojoule per minute (Code: P19)
        /// </summary>
        /// <remarks>
        /// Quotient from the 1000-fold of the derived SI unit joule divided by the unit minute.
        /// </remarks>
        KilojoulePerMinute,

        /// <summary>
        /// Pound per foot (Code: P2)
        /// </summary>
        PoundPerFoot,

        /// <summary>
        /// Kilojoule per hour (Code: P20)
        /// </summary>
        /// <remarks>
        /// Quotient from the 1000-fold of the derived SI unit joule divided by the unit hour.
        /// </remarks>
        KilojoulePerHour,

        /// <summary>
        /// Kilojoule per day (Code: P21)
        /// </summary>
        /// <remarks>
        /// Quotient from the 1000-fold of the derived SI unit joule divided by the unit day.
        /// </remarks>
        KilojoulePerDay,

        /// <summary>
        /// Nanoohm (Code: P22)
        /// </summary>
        /// <remarks>
        /// 0,000 000 001-fold of the derived SI unit ohm.
        /// </remarks>
        Nanoohm,

        /// <summary>
        /// Ohm circular-mil per foot (Code: P23)
        /// </summary>
        /// <remarks>
        /// Unit of resistivity.
        /// </remarks>
        OhmCircularMilPerFoot,

        /// <summary>
        /// Kilohenry (Code: P24)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the derived SI unit henry.
        /// </remarks>
        Kilohenry,

        /// <summary>
        /// Lumen per square foot (Code: P25)
        /// </summary>
        /// <remarks>
        /// Derived SI unit lumen divided by the power of the unit foot according to the Anglo-American and Imperial system of units by exponent 2.
        /// </remarks>
        LumenPerSquareFoot,

        /// <summary>
        /// Phot (Code: P26)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit of luminance, defined as lumen by square centimetre.
        /// </remarks>
        Phot,

        /// <summary>
        /// Footcandle (Code: P27)
        /// </summary>
        /// <remarks>
        /// Non SI conform traditional unit, defined as density of light which impinges on a surface which has a distance of one foot from a light source, which shines with an intensity of an international candle.
        /// </remarks>
        Footcandle,

        /// <summary>
        /// Candela per square inch (Code: P28)
        /// </summary>
        /// <remarks>
        /// SI base unit candela divided by the power of unit inch according to the Anglo-American and Imperial system of units by exponent 2.
        /// </remarks>
        CandelaPerSquareInch,

        /// <summary>
        /// Footlambert (Code: P29)
        /// </summary>
        /// <remarks>
        /// Unit of the luminance according to the Anglo-American system of units, defined as emitted or reflected luminance of a lm/ft².
        /// </remarks>
        Footlambert,

        /// <summary>
        /// Lambert (Code: P30)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit of luminance, defined as the emitted or reflected luminance by one lumen per square centimetre.
        /// </remarks>
        Lambert,

        /// <summary>
        /// Stilb (Code: P31)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit of luminance, defined as emitted or reflected luminance by one lumen per square centimetre.
        /// </remarks>
        Stilb,

        /// <summary>
        /// Candela per square foot (Code: P32)
        /// </summary>
        /// <remarks>
        /// Base unit SI candela divided by the power of the unit foot according to the Anglo-American and Imperial system of units by exponent 2.
        /// </remarks>
        CandelaPerSquareFoot,

        /// <summary>
        /// Kilocandela (Code: P33)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the SI base unit candela.
        /// </remarks>
        Kilocandela,

        /// <summary>
        /// Millicandela (Code: P34)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the SI base unit candela.
        /// </remarks>
        Millicandela,

        /// <summary>
        /// Hefner-Kerze (Code: P35)
        /// </summary>
        /// <remarks>
        /// Obsolete, non-legal unit of the power in Germany relating to DIN 1301-3:1979: 1 HK = 0,903 cd.
        /// </remarks>
        HefnerKerze,

        /// <summary>
        /// International candle (Code: P36)
        /// </summary>
        /// <remarks>
        /// Obsolete, non-legal unit of the power in Germany relating to DIN 1301-3:1979: 1 HK = 1,019 cd.
        /// </remarks>
        InternationalCandle,

        /// <summary>
        /// British thermal unit (international table) per square foot (Code: P37)
        /// </summary>
        /// <remarks>
        /// Unit of the areal-related energy transmission according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_internationalTable_PerSquareFoot,

        /// <summary>
        /// British thermal unit (thermochemical) per square foot (Code: P38)
        /// </summary>
        /// <remarks>
        /// Unit of the areal-related energy transmission according to the Imperial system of units.
        /// </remarks>
        BritishThermalUnit_thermochemical_PerSquareFoot,

        /// <summary>
        /// Calorie (thermochemical) per square centimetre (Code: P39)
        /// </summary>
        /// <remarks>
        /// Unit of the areal-related energy transmission according to the Imperial system of units.
        /// </remarks>
        Calorie_thermochemical_PerSquareCentimetre,

        /// <summary>
        /// Langley (Code: P40)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit of the areal-related energy transmission (as a measure of the incident quantity of heat of solar radiation on the earth's surface).
        /// </remarks>
        Langley,

        /// <summary>
        /// Decade (logarithmic) (Code: P41)
        /// </summary>
        /// <remarks>
        /// 1 Dec := log2 10 ˜ 3,32 according to the logarithm for frequency range between f1 and f2, when f2/f1 = 10.
        /// </remarks>
        Decade_logarithmic,

        /// <summary>
        /// Pascal squared second (Code: P42)
        /// </summary>
        /// <remarks>
        /// Unit of the set as a product of the power of derived SI unit pascal with exponent 2 and the SI base unit second.
        /// </remarks>
        PascalSquaredSecond,

        /// <summary>
        /// Bel per metre (Code: P43)
        /// </summary>
        /// <remarks>
        /// Unit bel divided by the SI base unit metre.
        /// </remarks>
        BelPerMetre,

        /// <summary>
        /// Pound mole (Code: P44)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of quantity of a substance relating that one pound mole of a chemical composition corresponds to the same number of pounds as the molecular weight of one molecule of this composition in atomic mass units.
        /// </remarks>
        PoundMole,

        /// <summary>
        /// Pound mole per second (Code: P45)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the power of the amount of substance non-SI compliant unit of the molar flux relating that a pound mole of a chemical composition the same number of pound corresponds like the molecular weight of a molecule of this composition in atomic mass units.
        /// </remarks>
        PoundMolePerSecond,

        /// <summary>
        /// Pound mole per minute (Code: P46)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the power of the amount of substance non-SI compliant unit of the molar flux relating that a pound mole of a chemical composition the same number of pound corresponds like the molecular weight of a molecule of this composition in atomic mass units.
        /// </remarks>
        PoundMolePerMinute,

        /// <summary>
        /// Kilomole per kilogram (Code: P47)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the SI base unit mol divided by the SI base unit kilogram.
        /// </remarks>
        KilomolePerKilogram,

        /// <summary>
        /// Pound mole per pound (Code: P48)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of the material molar flux divided by the avoirdupois pound for mass according to the avoirdupois unit system.
        /// </remarks>
        PoundMolePerPound,

        /// <summary>
        /// Newton square metre per ampere (Code: P49)
        /// </summary>
        /// <remarks>
        /// Product of the derived SI unit newton and the power of SI base unit metre with exponent 2 divided by the SI base unit ampere.
        /// </remarks>
        NewtonSquareMetrePerAmpere,

        /// <summary>
        /// Five pack (Code: P5)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of five-packs (five-pack: set of five items packaged together).
        /// </remarks>
        FivePack,

        /// <summary>
        /// Weber metre (Code: P50)
        /// </summary>
        /// <remarks>
        /// Product of the derived SI unit weber and SI base unit metre.
        /// </remarks>
        WeberMetre,

        /// <summary>
        /// Mol per kilogram pascal (Code: P51)
        /// </summary>
        /// <remarks>
        /// SI base unit mol divided by the product of the SI base unit kilogram and the derived SI unit pascal.
        /// </remarks>
        MolPerKilogramPascal,

        /// <summary>
        /// Mol per cubic metre pascal (Code: P52)
        /// </summary>
        /// <remarks>
        /// SI base unit mol divided by the product of the power from the SI base unit metre with exponent 3 and the derived SI unit pascal.
        /// </remarks>
        MolPerCubicMetrePascal,

        /// <summary>
        /// Unit pole (Code: P53)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit for magnetic flux of a magnetic pole (according to the interaction of identical poles of 1 dyn at a distance of a cm).
        /// </remarks>
        UnitPole,

        /// <summary>
        /// Milligray per second (Code: P54)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the derived SI unit gray divided by the SI base unit second.
        /// </remarks>
        MilligrayPerSecond,

        /// <summary>
        /// Microgray per second (Code: P55)
        /// </summary>
        /// <remarks>
        /// 0,000 001-fold of the derived SI unit gray divided by the SI base unit second.
        /// </remarks>
        MicrograyPerSecond,

        /// <summary>
        /// Nanogray per second (Code: P56)
        /// </summary>
        /// <remarks>
        /// 0,000 000 001-fold of the derived SI unit gray divided by the SI base unit second.
        /// </remarks>
        NanograyPerSecond,

        /// <summary>
        /// Gray per minute (Code: P57)
        /// </summary>
        /// <remarks>
        /// SI derived unit gray divided by the unit minute.
        /// </remarks>
        GrayPerMinute,

        /// <summary>
        /// Milligray per minute (Code: P58)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the derived SI unit gray divided by the unit minute.
        /// </remarks>
        MilligrayPerMinute,

        /// <summary>
        /// Microgray per minute (Code: P59)
        /// </summary>
        /// <remarks>
        /// 0,000 001-fold of the derived SI unit gray divided by the unit minute.
        /// </remarks>
        MicrograyPerMinute,

        /// <summary>
        /// Nanogray per minute (Code: P60)
        /// </summary>
        /// <remarks>
        /// 0,000 000 001-fold of the derived SI unit gray divided by the unit minute.
        /// </remarks>
        NanograyPerMinute,

        /// <summary>
        /// Gray per hour (Code: P61)
        /// </summary>
        /// <remarks>
        /// SI derived unit gray divided by the unit hour.
        /// </remarks>
        GrayPerHour,

        /// <summary>
        /// Milligray per hour (Code: P62)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the derived SI unit gray divided by the unit hour.
        /// </remarks>
        MilligrayPerHour,

        /// <summary>
        /// Microgray per hour (Code: P63)
        /// </summary>
        /// <remarks>
        /// 0,000 001-fold of the derived SI unit gray divided by the unit hour.
        /// </remarks>
        MicrograyPerHour,

        /// <summary>
        /// Nanogray per hour (Code: P64)
        /// </summary>
        /// <remarks>
        /// 0,000 000 001-fold of the derived SI unit gray divided by the unit hour.
        /// </remarks>
        NanograyPerHour,

        /// <summary>
        /// Sievert per second (Code: P65)
        /// </summary>
        /// <remarks>
        /// Derived SI unit sievert divided by the SI base unit second.
        /// </remarks>
        SievertPerSecond,

        /// <summary>
        /// Millisievert per second (Code: P66)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the derived SI unit sievert divided by the SI base unit second.
        /// </remarks>
        MillisievertPerSecond,

        /// <summary>
        /// Microsievert per second (Code: P67)
        /// </summary>
        /// <remarks>
        /// 0,000 001-fold of the derived SI unit sievert divided by the SI base unit second.
        /// </remarks>
        MicrosievertPerSecond,

        /// <summary>
        /// Nanosievert per second (Code: P68)
        /// </summary>
        /// <remarks>
        /// 0,000 000 001-fold of the derived SI unit sievert divided by the SI base unit second.
        /// </remarks>
        NanosievertPerSecond,

        /// <summary>
        /// Rem per second (Code: P69)
        /// </summary>
        /// <remarks>
        /// Unit for the equivalent tin rate relating to DIN 1301-3:1979: 1 rem/s = 0,01 J/(kg·s) = 1 Sv/s.
        /// </remarks>
        RemPerSecond,

        /// <summary>
        /// Sievert per hour (Code: P70)
        /// </summary>
        /// <remarks>
        /// Derived SI unit sievert divided by the unit hour.
        /// </remarks>
        SievertPerHour,

        /// <summary>
        /// Millisievert per hour (Code: P71)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the derived SI unit sievert divided by the unit hour.
        /// </remarks>
        MillisievertPerHour,

        /// <summary>
        /// Microsievert per hour (Code: P72)
        /// </summary>
        /// <remarks>
        /// 0,000 001-fold of the derived SI unit sievert divided by the unit hour.
        /// </remarks>
        MicrosievertPerHour,

        /// <summary>
        /// Nanosievert per hour (Code: P73)
        /// </summary>
        /// <remarks>
        /// 0,000 000 001-fold of the derived SI unit sievert divided by the unit hour.
        /// </remarks>
        NanosievertPerHour,

        /// <summary>
        /// Sievert per minute (Code: P74)
        /// </summary>
        /// <remarks>
        /// Derived SI unit sievert divided by the unit minute.
        /// </remarks>
        SievertPerMinute,

        /// <summary>
        /// Millisievert per minute (Code: P75)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the derived SI unit sievert divided by the unit minute.
        /// </remarks>
        MillisievertPerMinute,

        /// <summary>
        /// Microsievert per minute (Code: P76)
        /// </summary>
        /// <remarks>
        /// 0,000 001-fold of the derived SI unit sievert divided by the unit minute.
        /// </remarks>
        MicrosievertPerMinute,

        /// <summary>
        /// Nanosievert per minute (Code: P77)
        /// </summary>
        /// <remarks>
        /// 0,000 000 001-fold of the derived SI unit sievert divided by the unit minute.
        /// </remarks>
        NanosievertPerMinute,

        /// <summary>
        /// Reciprocal square inch (Code: P78)
        /// </summary>
        /// <remarks>
        /// Complement of the power of the unit inch according to the Anglo-American and Imperial system of units by exponent 2.
        /// </remarks>
        ReciprocalSquareInch,

        /// <summary>
        /// Pascal square metre per kilogram (Code: P79)
        /// </summary>
        /// <remarks>
        /// Unit of the burst index as derived unit for pressure pascal related to the substance, represented as a quotient from the SI base unit kilogram divided by the power of the SI base unit metre by exponent 2.
        /// </remarks>
        PascalSquareMetrePerKilogram,

        /// <summary>
        /// Millipascal per metre (Code: P80)
        /// </summary>
        /// <remarks>
        /// 0,001-fold of the derived SI unit pascal divided by the SI base unit metre.
        /// </remarks>
        MillipascalPerMetre,

        /// <summary>
        /// Kilopascal per metre (Code: P81)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the derived SI unit pascal divided by the SI base unit metre.
        /// </remarks>
        KilopascalPerMetre,

        /// <summary>
        /// Hectopascal per metre (Code: P82)
        /// </summary>
        /// <remarks>
        /// 100-fold of the derived SI unit pascal divided by the SI base unit metre.
        /// </remarks>
        HectopascalPerMetre,

        /// <summary>
        /// Standard atmosphere per metre (Code: P83)
        /// </summary>
        /// <remarks>
        /// Outdated unit of the pressure divided by the SI base unit metre.
        /// </remarks>
        StandardAtmospherePerMetre,

        /// <summary>
        /// Technical atmosphere per metre (Code: P84)
        /// </summary>
        /// <remarks>
        /// Obsolete and non-legal unit of the pressure which is generated by a 10 metre water column divided by the SI base unit metre.
        /// </remarks>
        TechnicalAtmospherePerMetre,

        /// <summary>
        /// Torr per metre (Code: P85)
        /// </summary>
        /// <remarks>
        /// CGS (Centimetre-Gram-Second system) unit of the pressure divided by the SI base unit metre.
        /// </remarks>
        TorrPerMetre,

        /// <summary>
        /// Psi per inch (Code: P86)
        /// </summary>
        /// <remarks>
        /// Compound unit for pressure (pound-force according to the Anglo-American unit system divided by the power of the unit inch according to the Anglo-American and Imperial system of units with the exponent 2) divided by the unit inch according to the Anglo-American and Imperial system of units .
        /// </remarks>
        PsiPerInch,

        /// <summary>
        /// Cubic metre per second square metre (Code: P87)
        /// </summary>
        /// <remarks>
        /// Unit of volume flow cubic meters by second related to the transmission surface in square metres.
        /// </remarks>
        CubicMetrePerSecondSquareMetre,

        /// <summary>
        /// Rhe (Code: P88)
        /// </summary>
        /// <remarks>
        /// Non SI-conforming unit of fluidity of dynamic viscosity.
        /// </remarks>
        Rhe,

        /// <summary>
        /// Pound-force foot per inch (Code: P89)
        /// </summary>
        /// <remarks>
        /// Unit for length-related rotational moment according to the Anglo-American and Imperial system of units.
        /// </remarks>
        PoundForceFootPerInch,

        /// <summary>
        /// Pound-force inch per inch (Code: P90)
        /// </summary>
        /// <remarks>
        /// Unit for length-related rotational moment according to the Anglo-American and Imperial system of units.
        /// </remarks>
        PoundForceInchPerInch,

        /// <summary>
        /// Perm (0 ºC) (Code: P91)
        /// </summary>
        /// <remarks>
        /// Traditional unit for the ability of a material to allow the transition of the steam, defined at a temperature of 0 °C as steam transmittance, where the mass of one grain steam penetrates an area of one foot squared at a pressure from one inch mercury per hour.
        /// </remarks>
        Perm_0ºC,

        /// <summary>
        /// Perm (23 ºC) (Code: P92)
        /// </summary>
        /// <remarks>
        /// Traditional unit for the ability of a material to allow the transition of the steam, defined at a temperature of 23 °C as steam transmittance at which the mass of one grain of steam penetrates an area of one square foot at a pressure of one inch mercury per hour.
        /// </remarks>
        Perm_23ºC,

        /// <summary>
        /// Byte per second (Code: P93)
        /// </summary>
        /// <remarks>
        /// Unit byte divided by the SI base unit second.
        /// </remarks>
        BytePerSecond,

        /// <summary>
        /// Kilobyte per second (Code: P94)
        /// </summary>
        /// <remarks>
        /// 1000-fold of the unit byte divided by the SI base unit second.
        /// </remarks>
        KilobytePerSecond,

        /// <summary>
        /// Megabyte per second (Code: P95)
        /// </summary>
        /// <remarks>
        /// 1 000 000-fold of the unit byte divided by the SI base unit second.
        /// </remarks>
        MegabytePerSecond,

        /// <summary>
        /// Reciprocal volt (Code: P96)
        /// </summary>
        /// <remarks>
        /// Reciprocal of the derived SI unit volt.
        /// </remarks>
        ReciprocalVolt,

        /// <summary>
        /// Reciprocal radian (Code: P97)
        /// </summary>
        /// <remarks>
        /// Reciprocal of the unit radian.
        /// </remarks>
        ReciprocalRadian,

        /// <summary>
        /// Pascal to the power sum of stoichiometric numbers (Code: P98)
        /// </summary>
        /// <remarks>
        /// Unit of the equilibrium constant on the basis of the pressure(ISO 80000-9:2009, 9-35.a).
        /// </remarks>
        PascalToThePowerSumOfStoichiometricNumbers,

        /// <summary>
        /// Mole per cubiv metre to the power sum of stoichiometric numbers (Code: P99)
        /// </summary>
        /// <remarks>
        /// Unit of the equilibrium constant on the basis of the concentration (ISO 80000-9:2009, 9-36.a).
        /// </remarks>
        MolePerCubivMetreToThePowerSumOfStoichiometricNumbers,

        /// <summary>
        /// Pascal (Code: PAL)
        /// </summary>
        Pascal,

        /// <summary>
        /// Pad (Code: PD)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of pads (pad: block of paper sheets fastened together at one end).
        /// </remarks>
        Pad,

        /// <summary>
        /// Proof litre (Code: PFL)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one litre of proof spirits, or the alcohol equivalent thereof. Used for measuring the strength of distilled alcoholic liquors, expressed as a percentage of the alcohol content of a standard mixture at a specific temperature.
        /// </remarks>
        ProofLitre,

        /// <summary>
        /// Proof gallon (Code: PGL)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one gallon of proof spirits, or the alcohol equivalent thereof. Used for measuring the strength of distilled alcoholic liquors, expressed as a percentage of the alcohol content of a standard mixture at a specific temperature.
        /// </remarks>
        ProofGallon,

        /// <summary>
        /// Pitch (Code: PI)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of characters that fit in a horizontal inch.
        /// </remarks>
        Pitch,

        /// <summary>
        /// Degree Plato (Code: PLA)
        /// </summary>
        /// <remarks>
        /// A unit of proportion defining the sugar content of a product, especially in relation to beer.
        /// </remarks>
        DegreePlato,

        /// <summary>
        /// Pound per inch of length (Code: PO)
        /// </summary>
        PoundPerInchOfLength,

        /// <summary>
        /// Page per inch (Code: PQ)
        /// </summary>
        /// <remarks>
        /// A unit of quantity defining the degree of thickness of a bound publication, expressed as the number of pages per inch of thickness.
        /// </remarks>
        PagePerInch,

        /// <summary>
        /// Pair (Code: PR)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of pairs (pair: item described by two's).
        /// </remarks>
        Pair,

        /// <summary>
        /// Pound-force per square inch (Code: PS)
        /// </summary>
        PoundForcePerSquareInch,

        /// <summary>
        /// Dry pint (US) (Code: PTD)
        /// </summary>
        DryPint_US,

        /// <summary>
        /// Pint (UK) (Code: PTI)
        /// </summary>
        Pint_UK,

        /// <summary>
        /// Liquid pint (US) (Code: PTL)
        /// </summary>
        LiquidPint_US,

        /// <summary>
        /// Portion (Code: PTN)
        /// </summary>
        /// <remarks>
        /// A quantity of allowance of food allotted to, or enough for, one person.
        /// </remarks>
        Portion,

        /// <summary>
        /// Joule per tesla (Code: Q10)
        /// </summary>
        /// <remarks>
        /// Unit of the magnetic dipole moment of the molecule as derived SI unit joule divided by the derived SI unit tesla.
        /// </remarks>
        JoulePerTesla,

        /// <summary>
        /// Erlang (Code: Q11)
        /// </summary>
        /// <remarks>
        /// Unit of the market value according to the feature of a single feature as a statistical measurement of the existing utilization.
        /// </remarks>
        Erlang,

        /// <summary>
        /// Octet (Code: Q12)
        /// </summary>
        /// <remarks>
        /// Synonym for byte: 1 octet = 8 bit = 1 byte.
        /// </remarks>
        Octet,

        /// <summary>
        /// Octet per second (Code: Q13)
        /// </summary>
        /// <remarks>
        /// Unit octet divided by the SI base unit second.
        /// </remarks>
        OctetPerSecond,

        /// <summary>
        /// Shannon (Code: Q14)
        /// </summary>
        /// <remarks>
        /// Logarithmic unit for information equal to the content of decision of a sentence of two mutually exclusive events, expressed as a logarithm to base 2.
        /// </remarks>
        Shannon,

        /// <summary>
        /// Hartley (Code: Q15)
        /// </summary>
        /// <remarks>
        /// Logarithmic unit for information equal to the content of decision of a sentence of ten mutually exclusive events, expressed as a logarithm to base 10.
        /// </remarks>
        Hartley,

        /// <summary>
        /// Natural unit of information (Code: Q16)
        /// </summary>
        /// <remarks>
        /// Logarithmic unit for information equal to the content of decision of a sentence of ,718 281 828 459 mutually exclusive events, expressed as a logarithm to base Euler value e.
        /// </remarks>
        NaturalUnitOfInformation,

        /// <summary>
        /// Shannon per second (Code: Q17)
        /// </summary>
        /// <remarks>
        /// Time related logarithmic unit for information equal to the content of decision of a sentence of two mutually exclusive events, expressed as a logarithm to base 2.
        /// </remarks>
        ShannonPerSecond,

        /// <summary>
        /// Hartley per second (Code: Q18)
        /// </summary>
        /// <remarks>
        /// Time related logarithmic unit for information equal to the content of decision of a sentence of ten mutually exclusive events, expressed as a logarithm to base 10.
        /// </remarks>
        HartleyPerSecond,

        /// <summary>
        /// Natural unit of information per second (Code: Q19)
        /// </summary>
        /// <remarks>
        /// Time related logarithmic unit for information equal to the content of decision of a sentence of 2,718 281 828 459 mutually exclusive events, expressed as a logarithm to base of the Euler value e.
        /// </remarks>
        NaturalUnitOfInformationPerSecond,

        /// <summary>
        /// Second per kilogramm (Code: Q20)
        /// </summary>
        /// <remarks>
        /// Unit of the Einstein transition probability for spontaneous or inducing emissions and absorption according to ISO 80000-7:2008, expressed as SI base unit second divided by the SI base unit kilogram.
        /// </remarks>
        SecondPerKilogramm,

        /// <summary>
        /// Watt square metre (Code: Q21)
        /// </summary>
        /// <remarks>
        /// Unit of the first radiation constants c1 = 2·p·h·c0², the value of which is 3,741 771 18·10?¹6-fold that of the comparative value of the product of the derived SI unit watt multiplied with the power of the SI base unit metre with the exponent 2.
        /// </remarks>
        WattSquareMetre,

        /// <summary>
        /// Second per radian cubic metre (Code: Q22)
        /// </summary>
        /// <remarks>
        /// Unit of the density of states as an expression of angular frequency as complement of the product of hertz and radiant and the power of SI base unit metre by exponent 3 .
        /// </remarks>
        SecondPerRadianCubicMetre,

        /// <summary>
        /// Weber to the power minus one (Code: Q23)
        /// </summary>
        /// <remarks>
        /// Complement of the derived SI unit weber as unit of the Josephson constant, which value is equal to the 384 597,891-fold of the reference value gigahertz divided by volt.
        /// </remarks>
        WeberToThePowerMinusOne,

        /// <summary>
        /// Reciprocal inch (Code: Q24)
        /// </summary>
        /// <remarks>
        /// Complement of the unit inch according to the Anglo-American and Imperial system of units.
        /// </remarks>
        ReciprocalInch,

        /// <summary>
        /// Dioptre (Code: Q25)
        /// </summary>
        /// <remarks>
        /// Unit used at the statement of relative refractive indexes of optical systems as complement of the focal length with correspondence to: 1 dpt = 1/m.
        /// </remarks>
        Dioptre,

        /// <summary>
        /// One per one (Code: Q26)
        /// </summary>
        /// <remarks>
        /// Value of the quotient from two physical units of the same kind as a numerator and denominator whereas the units are shortened mutually.
        /// </remarks>
        OnePerOne,

        /// <summary>
        /// Newton metre per metre (Code: Q27)
        /// </summary>
        /// <remarks>
        /// Unit for length-related rotational moment as product of the derived SI unit newton and the SI base unit metre divided by the SI base unit metre.
        /// </remarks>
        NewtonMetrePerMetre,

        /// <summary>
        /// Kilogram per square metre pascal second (Code: Q28)
        /// </summary>
        /// <remarks>
        /// Unit for the ability of a material to allow the transition of steam.
        /// </remarks>
        KilogramPerSquareMetrePascalSecond,

        /// <summary>
        /// Microgram per hectogram (Code: Q29)
        /// </summary>
        /// <remarks>
        /// Microgram per hectogram.
        /// </remarks>
        MicrogramPerHectogram,

        /// <summary>
        /// PH (potential of Hydrogen) (Code: Q30)
        /// </summary>
        /// <remarks>
        /// The activity of the (solvated) hydrogen ion (a logarithmic measure used to state the acidity or alkalinity of a chemical solution).
        /// </remarks>
        PH_potentialOfHydrogen,

        /// <summary>
        /// Kilojoule per gram (Code: Q31)
        /// </summary>
        KilojoulePerGram,

        /// <summary>
        /// Femtolitre (Code: Q32)
        /// </summary>
        Femtolitre,

        /// <summary>
        /// Picolitre (Code: Q33)
        /// </summary>
        Picolitre,

        /// <summary>
        /// Nanolitre (Code: Q34)
        /// </summary>
        Nanolitre,

        /// <summary>
        /// Megawatts per minute (Code: Q35)
        /// </summary>
        /// <remarks>
        /// A unit of power defining the total amount of bulk energy transferred or consumer per minute.
        /// </remarks>
        MegawattsPerMinute,

        /// <summary>
        /// Square metre per cubic metre (Code: Q36)
        /// </summary>
        /// <remarks>
        /// A unit of the amount of surface area per unit volume of an object or collection of objects.
        /// </remarks>
        SquareMetrePerCubicMetre,

        /// <summary>
        /// Standard cubic metre per day (Code: Q37)
        /// </summary>
        /// <remarks>
        /// Standard cubic metre (temperature 15°C and pressure 101325 millibars ) per day
        /// </remarks>
        StandardCubicMetrePerDay,

        /// <summary>
        /// Standard cubic metre per hour (Code: Q38)
        /// </summary>
        /// <remarks>
        /// Standard cubic metre (temperature 15°C and pressure 101325 millibars ) per hour
        /// </remarks>
        StandardCubicMetrePerHour,

        /// <summary>
        /// Normalized cubic metre per day (Code: Q39)
        /// </summary>
        /// <remarks>
        /// Normalized cubic metre (temperature 0°C and pressure 101325 millibars ) per day
        /// </remarks>
        NormalizedCubicMetrePerDay,

        /// <summary>
        /// Normalized cubic metre per hour (Code: Q40)
        /// </summary>
        /// <remarks>
        /// Normalized cubic metre (temperature 0°C and pressure 101325 millibars ) per hour
        /// </remarks>
        NormalizedCubicMetrePerHour,

        /// <summary>
        /// Joule per normalised cubic metre (Code: Q41)
        /// </summary>
        JoulePerNormalisedCubicMetre,

        /// <summary>
        /// Joule per standard cubic metre (Code: Q42)
        /// </summary>
        JoulePerStandardCubicMetre,

        /// <summary>
        /// Meal (Code: Q3)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of meals (meal: an amount of food to be eaten on a single occasion).
        /// </remarks>
        Meal,

        /// <summary>
        /// Page - facsimile (Code: QA)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of facsimile pages.
        /// </remarks>
        PageFacsimile,

        /// <summary>
        /// Quarter (of a year) (Code: QAN)
        /// </summary>
        /// <remarks>
        /// A unit of time defining the number of quarters (3 months).
        /// </remarks>
        Quarter_ofAYear,

        /// <summary>
        /// Page - hardcopy (Code: QB)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of hardcopy pages (hardcopy page: a page rendered as printed or written output on paper, film, or other permanent medium).
        /// </remarks>
        PageHardcopy,

        /// <summary>
        /// Quire (Code: QR)
        /// </summary>
        /// <remarks>
        /// A unit of count for paper, expressed as the number of quires (quire: a number of paper sheets, typically 25).
        /// </remarks>
        Quire,

        /// <summary>
        /// Dry quart (US) (Code: QTD)
        /// </summary>
        DryQuart_US,

        /// <summary>
        /// Quart (UK) (Code: QTI)
        /// </summary>
        Quart_UK,

        /// <summary>
        /// Liquid quart (US) (Code: QTL)
        /// </summary>
        LiquidQuart_US,

        /// <summary>
        /// Quarter (UK) (Code: QTR)
        /// </summary>
        /// <remarks>
        /// A traditional unit of weight equal to 1/4 hundredweight. In the United Kingdom, one quarter equals 28 pounds.
        /// </remarks>
        Quarter_UK,

        /// <summary>
        /// Pica (Code: R1)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of picas. (pica: typographical length equal to 12 points or 4.22 mm (approx.)).
        /// </remarks>
        Pica,

        /// <summary>
        /// Thousand cubic metre (Code: R9)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one thousand cubic metres.
        /// </remarks>
        ThousandCubicMetre,

        /// <summary>
        /// Running or operating hour (Code: RH)
        /// </summary>
        /// <remarks>
        /// A unit of time defining the number of hours of operation.
        /// </remarks>
        RunningOrOperatingHour,

        /// <summary>
        /// Ream (Code: RM)
        /// </summary>
        /// <remarks>
        /// A unit of count for paper, expressed as the number of reams (ream: a large quantity of paper sheets, typically 500).
        /// </remarks>
        Ream,

        /// <summary>
        /// Room (Code: ROM)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of rooms.
        /// </remarks>
        Room,

        /// <summary>
        /// Pound per ream (Code: RP)
        /// </summary>
        /// <remarks>
        /// A unit of mass for paper, expressed as pounds per ream. (ream: a large quantity of paper, typically 500 sheets).
        /// </remarks>
        PoundPerReam,

        /// <summary>
        /// Revolutions per minute (Code: RPM)
        /// </summary>
        /// <remarks>
        /// Refer ISO/TC12 SI Guide
        /// </remarks>
        RevolutionsPerMinute,

        /// <summary>
        /// Revolutions per second (Code: RPS)
        /// </summary>
        /// <remarks>
        /// Refer ISO/TC12 SI Guide
        /// </remarks>
        RevolutionsPerSecond,

        /// <summary>
        /// Revenue ton mile (Code: RT)
        /// </summary>
        /// <remarks>
        /// A unit of information typically used for billing purposes, expressed as the number of revenue tons (revenue ton: either a metric ton or a cubic metres, whichever is the larger), moved over a distance of one mile.
        /// </remarks>
        RevenueTonMile,

        /// <summary>
        /// Square foot per second (Code: S3)
        /// </summary>
        /// <remarks>
        /// Synonym: foot squared per second
        /// </remarks>
        SquareFootPerSecond,

        /// <summary>
        /// Square metre per second (Code: S4)
        /// </summary>
        /// <remarks>
        /// Synonym: metre squared per second (square metres/second US)
        /// </remarks>
        SquareMetrePerSecond,

        /// <summary>
        /// Half year (6 months) (Code: SAN)
        /// </summary>
        /// <remarks>
        /// A unit of time defining the number of half years (6 months).
        /// </remarks>
        HalfYear_6Months,

        /// <summary>
        /// Score (Code: SCO)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of units in multiples of 20.
        /// </remarks>
        Score,

        /// <summary>
        /// Scruple (Code: SCR)
        /// </summary>
        Scruple,

        /// <summary>
        /// Second [unit of time] (Code: SEC)
        /// </summary>
        Second_UnitOfTime,

        /// <summary>
        /// Set (Code: SET)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of sets (set: a number of objects grouped together).
        /// </remarks>
        Set_UnitOfCount,

        /// <summary>
        /// Segment (Code: SG)
        /// </summary>
        /// <remarks>
        /// A unit of information equal to 64000 bytes.
        /// </remarks>
        Segment,

        /// <summary>
        /// Siemens (Code: SIE)
        /// </summary>
        Siemens,

        /// <summary>
        /// Standard cubic metre (Code: SM3)
        /// </summary>
        /// <remarks>
        /// Standard cubic metre (temperature 15°C and pressure 101325 millibars )
        /// </remarks>
        StandardCubicMetre,

        /// <summary>
        /// Mile (statute mile) (Code: SMI)
        /// </summary>
        Mile_statuteMile,

        /// <summary>
        /// Square (Code: SQ)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of squares (square: rectangular shape).
        /// </remarks>
        Square,

        /// <summary>
        /// Square, roofing (Code: SQR)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of squares of roofing materials, measured in multiples of 100 square feet.
        /// </remarks>
        Square_Roofing,

        /// <summary>
        /// Strip (Code: SR)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of strips (strip: long narrow piece of an object).
        /// </remarks>
        Strip,

        /// <summary>
        /// Stick (Code: STC)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of sticks (stick: slender and often cylindrical piece of a substance).
        /// </remarks>
        Stick,

        /// <summary>
        /// Stone (UK) (Code: STI)
        /// </summary>
        Stone_UK,

        /// <summary>
        /// Stick, cigarette (Code: STK)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of cigarettes in the smallest unit for stock-taking and/or duty computation.
        /// </remarks>
        Stick_Cigarette,

        /// <summary>
        /// Standard litre (Code: STL)
        /// </summary>
        /// <remarks>
        /// A unit of volume defining the number of litres of a product at a temperature of 15 degrees Celsius, especially in relation to hydrocarbon oils.
        /// </remarks>
        StandardLitre,

        /// <summary>
        /// Ton (US) or short ton (UK/US) (Code: STN)
        /// </summary>
        /// <remarks>
        /// Synonym: net ton (2000 lb)
        /// </remarks>
        Ton_US_OrShortTon_UKPerUS,

        /// <summary>
        /// Straw (Code: STW)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of straws (straw: a slender tube used for sucking up liquids).
        /// </remarks>
        Straw,

        /// <summary>
        /// Skein (Code: SW)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of skeins (skein: a loosely-coiled bundle of yarn or thread).
        /// </remarks>
        Skein,

        /// <summary>
        /// Shipment (Code: SX)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of shipments (shipment: an amount of goods shipped or transported).
        /// </remarks>
        Shipment,

        /// <summary>
        /// Syringe (Code: SYR)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of syringes (syringe: a small device for pumping, spraying and/or injecting liquids through a small aperture).
        /// </remarks>
        Syringe,

        /// <summary>
        /// Telecommunication line in service (Code: T0)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of lines in service.
        /// </remarks>
        TelecommunicationLineInService,

        /// <summary>
        /// Thousand piece (Code: T3)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of pieces in multiples of 1000 (piece: a single item, article or exemplar).
        /// </remarks>
        ThousandPiece,

        /// <summary>
        /// Kiloampere hour (thousand ampere hour) (Code: TAH)
        /// </summary>
        KiloampereHour_thousandAmpereHour,

        /// <summary>
        /// Total acid number (Code: TAN)
        /// </summary>
        /// <remarks>
        /// A unit of chemistry defining the amount of potassium hydroxide (KOH) in milligrams that is needed to neutralize the acids in one gram of oil. It is an important quality measurement of crude oil.
        /// </remarks>
        TotalAcidNumber,

        /// <summary>
        /// Thousand square inch (Code: TI)
        /// </summary>
        ThousandSquareInch,

        /// <summary>
        /// Metric ton, including container (Code: TIC)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of metric tons of a product, including its container.
        /// </remarks>
        MetricTon_IncludingContainer,

        /// <summary>
        /// Metric ton, including inner packaging (Code: TIP)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of metric tons of a product, including its inner packaging materials.
        /// </remarks>
        MetricTon_IncludingInnerPackaging,

        /// <summary>
        /// Tonne kilometre (Code: TKM)
        /// </summary>
        /// <remarks>
        /// A unit of information typically used for billing purposes, expressed as the number of tonnes (metric tons) moved over a distance of one kilometre.
        /// </remarks>
        TonneKilometre,

        /// <summary>
        /// Kilogram of imported meat, less offal (Code: TMS)
        /// </summary>
        /// <remarks>
        /// A unit of mass equal to one thousand grams of imported meat, disregarding less valuable by-products such as the entrails.
        /// </remarks>
        KilogramOfImportedMeat_LessOffal,

        /// <summary>
        /// Tonne (metric ton) (Code: TNE)
        /// </summary>
        /// <remarks>
        /// Synonym: metric ton
        /// </remarks>
        Tonne_metricTon,

        /// <summary>
        /// Ten pack (Code: TP)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of items in multiples of 10.
        /// </remarks>
        TenPack,

        /// <summary>
        /// Teeth per inch (Code: TPI)
        /// </summary>
        /// <remarks>
        /// The number of teeth per inch.
        /// </remarks>
        TeethPerInch,

        /// <summary>
        /// Ten pair (Code: TPR)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of pairs in multiples of 10 (pair: item described by two's).
        /// </remarks>
        TenPair,

        /// <summary>
        /// Thousand cubic metre per day (Code: TQD)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to one thousand cubic metres per day.
        /// </remarks>
        ThousandCubicMetrePerDay,

        /// <summary>
        /// Trillion (EUR) (Code: TRL)
        /// </summary>
        Trillion_EUR,

        /// <summary>
        /// Ten set (Code: TST)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of sets in multiples of 10 (set: a number of objects grouped together).
        /// </remarks>
        TenSet,

        /// <summary>
        /// Ten thousand sticks (Code: TTS)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of sticks in multiples of 10000 (stick: slender and often cylindrical piece of a substance).
        /// </remarks>
        TenThousandSticks,

        /// <summary>
        /// Treatment (Code: U1)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of treatments (treatment: subjection to the action of a chemical, physical or biological agent).
        /// </remarks>
        Treatment,

        /// <summary>
        /// Tablet (Code: U2)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of tablets (tablet: a small flat or compressed solid object).
        /// </remarks>
        Tablet_UnitOfCount,

        /// <summary>
        /// Telecommunication line in service average (Code: UB)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the average number of lines in service.
        /// </remarks>
        TelecommunicationLineInServiceAverage,

        /// <summary>
        /// Telecommunication port (Code: UC)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of network access ports.
        /// </remarks>
        TelecommunicationPort,

        /// <summary>
        /// Volt - ampere per kilogram (Code: VA)
        /// </summary>
        VoltAmperePerKilogram,

        /// <summary>
        /// Volt (Code: VLT)
        /// </summary>
        Volt,

        /// <summary>
        /// Percent volume (Code: VP)
        /// </summary>
        /// <remarks>
        /// A measure of concentration, typically expressed as the percentage volume of a solute in a solution.
        /// </remarks>
        PercentVolume,

        /// <summary>
        /// Wet kilo (Code: W2)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of kilograms of a product, including the water content of the product.
        /// </remarks>
        WetKilo,

        /// <summary>
        /// Watt per kilogram (Code: WA)
        /// </summary>
        WattPerKilogram,

        /// <summary>
        /// Wet pound (Code: WB)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of pounds of a material, including the water content of the material.
        /// </remarks>
        WetPound,

        /// <summary>
        /// Cord (Code: WCD)
        /// </summary>
        /// <remarks>
        /// A unit of volume used for measuring lumber. One board foot equals 1/12 of a cubic foot.
        /// </remarks>
        Cord,

        /// <summary>
        /// Wet ton (Code: WE)
        /// </summary>
        /// <remarks>
        /// A unit of mass defining the number of tons of a material, including the water content of the material.
        /// </remarks>
        WetTon,

        /// <summary>
        /// Weber (Code: WEB)
        /// </summary>
        Weber,

        /// <summary>
        /// Week (Code: WEE)
        /// </summary>
        Week,

        /// <summary>
        /// Wine gallon (Code: WG)
        /// </summary>
        /// <remarks>
        /// A unit of volume equal to 231 cubic inches.
        /// </remarks>
        WineGallon,

        /// <summary>
        /// Watt hour (Code: WHR)
        /// </summary>
        WattHour,

        /// <summary>
        /// Working month (Code: WM)
        /// </summary>
        /// <remarks>
        /// A unit of time defining the number of working months.
        /// </remarks>
        WorkingMonth,

        /// <summary>
        /// Standard (Code: WSD)
        /// </summary>
        /// <remarks>
        /// A unit of volume of finished lumber equal to 165 cubic feet. Synonym: standard cubic foot
        /// </remarks>
        Standard,

        /// <summary>
        /// Watt (Code: WTT)
        /// </summary>
        Watt,

        /// <summary>
        /// Gunter's chain (Code: X1)
        /// </summary>
        /// <remarks>
        /// A unit of distance used or formerly used by British surveyors.
        /// </remarks>
        GuntersChain,

        /// <summary>
        /// Square yard (Code: YDK)
        /// </summary>
        SquareYard,

        /// <summary>
        /// Cubic yard (Code: YDQ)
        /// </summary>
        CubicYard,

        /// <summary>
        /// Yard (Code: YRD)
        /// </summary>
        Yard,

        /// <summary>
        /// Hanging container (Code: Z11)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of hanging containers.
        /// </remarks>
        HangingContainer,

        /// <summary>
        /// Nanomole (Code: Z9)
        /// </summary>
        Nanomole,

        /// <summary>
        /// Page (Code: ZP)
        /// </summary>
        /// <remarks>
        /// A unit of count defining the number of pages.
        /// </remarks>
        Page,

        /// <summary>
        /// Mutually defined (Code: ZZ)
        /// </summary>
        /// <remarks>
        /// A unit of measure as agreed in common between two or more parties.
        /// </remarks>
        MutuallyDefined,

        /// <summary>
        /// Drum, steel (Code: X1A)
        /// </summary>
        Drum_Steel,

        /// <summary>
        /// Drum, aluminium (Code: X1B)
        /// </summary>
        Drum_Aluminium,

        /// <summary>
        /// Drum, plywood (Code: X1D)
        /// </summary>
        Drum_Plywood,

        /// <summary>
        /// Container, flexible (Code: X1F)
        /// </summary>
        /// <remarks>
        /// A packaging container of flexible construction.
        /// </remarks>
        Container_Flexible,

        /// <summary>
        /// Drum, fibre (Code: X1G)
        /// </summary>
        Drum_Fibre,

        /// <summary>
        /// Drum, wooden (Code: X1W)
        /// </summary>
        Drum_Wooden,

        /// <summary>
        /// Barrel, wooden (Code: X2C)
        /// </summary>
        Barrel_Wooden,

        /// <summary>
        /// Jerrican, steel (Code: X3A)
        /// </summary>
        Jerrican_Steel,

        /// <summary>
        /// Jerrican, plastic (Code: X3H)
        /// </summary>
        Jerrican_Plastic,

        /// <summary>
        /// Bag, super bulk (Code: X43)
        /// </summary>
        /// <remarks>
        /// A cloth plastic or paper based bag having the dimensions of the pallet on which it is constructed.
        /// </remarks>
        Bag_SuperBulk,

        /// <summary>
        /// Bag, polybag (Code: X44)
        /// </summary>
        /// <remarks>
        /// A type of plastic bag, typically used to wrap promotional pieces, publications, product samples, and/or catalogues.
        /// </remarks>
        Bag_Polybag,

        /// <summary>
        /// Box, steel (Code: X4A)
        /// </summary>
        Box_Steel,

        /// <summary>
        /// Box, aluminium (Code: X4B)
        /// </summary>
        Box_Aluminium,

        /// <summary>
        /// Box, natural wood (Code: X4C)
        /// </summary>
        Box_NaturalWood,

        /// <summary>
        /// Box, plywood (Code: X4D)
        /// </summary>
        Box_Plywood,

        /// <summary>
        /// Box, reconstituted wood (Code: X4F)
        /// </summary>
        Box_ReconstitutedWood,

        /// <summary>
        /// Box, fibreboard (Code: X4G)
        /// </summary>
        Box_Fibreboard,

        /// <summary>
        /// Box, plastic (Code: X4H)
        /// </summary>
        Box_Plastic,

        /// <summary>
        /// Bag, woven plastic (Code: X5H)
        /// </summary>
        Bag_WovenPlastic,

        /// <summary>
        /// Bag, textile (Code: X5L)
        /// </summary>
        Bag_Textile,

        /// <summary>
        /// Bag, paper (Code: X5M)
        /// </summary>
        Bag_Paper,

        /// <summary>
        /// Composite packaging, plastic receptacle (Code: X6H)
        /// </summary>
        CompositePackaging_PlasticReceptacle,

        /// <summary>
        /// Composite packaging, glass receptacle (Code: X6P)
        /// </summary>
        CompositePackaging_GlassReceptacle,

        /// <summary>
        /// Case, car (Code: X7A)
        /// </summary>
        /// <remarks>
        /// A type of portable container designed to store equipment for carriage in an automobile.
        /// </remarks>
        Case_Car,

        /// <summary>
        /// Case, wooden (Code: X7B)
        /// </summary>
        /// <remarks>
        /// A case made of wood for retaining substances or articles.
        /// </remarks>
        Case_Wooden,

        /// <summary>
        /// Pallet, wooden (Code: X8A)
        /// </summary>
        /// <remarks>
        /// A platform or open-ended box, made of wood, on which goods are retained for ease of mechanical handling during transport and storage.
        /// </remarks>
        Pallet_Wooden,

        /// <summary>
        /// Crate, wooden (Code: X8B)
        /// </summary>
        /// <remarks>
        /// A receptacle, made of wood, on which goods are retained for ease of mechanical handling during transport and storage.
        /// </remarks>
        Crate_Wooden,

        /// <summary>
        /// Bundle, wooden (Code: X8C)
        /// </summary>
        /// <remarks>
        /// Loose or unpacked pieces of wood tied or wrapped together.
        /// </remarks>
        Bundle_Wooden,

        /// <summary>
        /// Intermediate bulk container, rigid plastic (Code: XAA)
        /// </summary>
        IntermediateBulkContainer_RigidPlastic,

        /// <summary>
        /// Receptacle, fibre (Code: XAB)
        /// </summary>
        /// <remarks>
        /// Containment vessel made of fibre used for retaining substances or articles.
        /// </remarks>
        Receptacle_Fibre,

        /// <summary>
        /// Receptacle, paper (Code: XAC)
        /// </summary>
        /// <remarks>
        /// Containment vessel made of paper for retaining substances or articles.
        /// </remarks>
        Receptacle_Paper,

        /// <summary>
        /// Receptacle, wooden (Code: XAD)
        /// </summary>
        /// <remarks>
        /// Containment vessel made of wood for retaining substances or articles.
        /// </remarks>
        Receptacle_Wooden,

        /// <summary>
        /// Aerosol (Code: XAE)
        /// </summary>
        Aerosol,

        /// <summary>
        /// Pallet, modular, collars 80cms * 60cms (Code: XAF)
        /// </summary>
        /// <remarks>
        /// Standard sized pallet of dimensions 80 centimeters by 60 centimeters (cms).
        /// </remarks>
        Pallet_Modular_Collars80cmsTimes60cms,

        /// <summary>
        /// Pallet, shrinkwrapped (Code: XAG)
        /// </summary>
        /// <remarks>
        /// Pallet load secured with transparent plastic film that has been wrapped around and then shrunk tightly.
        /// </remarks>
        Pallet_Shrinkwrapped,

        /// <summary>
        /// Pallet, 100cms * 110cms (Code: XAH)
        /// </summary>
        /// <remarks>
        /// Standard sized pallet of dimensions 100centimeters by 110 centimeters (cms).
        /// </remarks>
        Pallet_100cmsTimes110cms,

        /// <summary>
        /// Clamshell (Code: XAI)
        /// </summary>
        Clamshell,

        /// <summary>
        /// Cone (Code: XAJ)
        /// </summary>
        /// <remarks>
        /// Container used in the transport of linear material such as yarn.
        /// </remarks>
        Cone,

        /// <summary>
        /// Ball (Code: XAL)
        /// </summary>
        /// <remarks>
        /// A spherical containment vessel for retaining substances or articles.
        /// </remarks>
        Ball_SphericalContainmentVessel,

        /// <summary>
        /// Ampoule, non-protected (Code: XAM)
        /// </summary>
        Ampoule_NonProtected,

        /// <summary>
        /// Ampoule, protected (Code: XAP)
        /// </summary>
        Ampoule_Protected,

        /// <summary>
        /// Atomizer (Code: XAT)
        /// </summary>
        Atomizer,

        /// <summary>
        /// Capsule (Code: XAV)
        /// </summary>
        Capsule,

        /// <summary>
        /// Belt (Code: XB4)
        /// </summary>
        /// <remarks>
        /// A band use to retain multiple articles together.
        /// </remarks>
        Belt,

        /// <summary>
        /// Barrel (Code: XBA)
        /// </summary>
        Barrel,

        /// <summary>
        /// Bobbin (Code: XBB)
        /// </summary>
        Bobbin,

        /// <summary>
        /// Bottlecrate / bottlerack (Code: XBC)
        /// </summary>
        BottlecratePerBottlerack,

        /// <summary>
        /// Board (Code: XBD)
        /// </summary>
        Board,

        /// <summary>
        /// Bundle (Code: XBE)
        /// </summary>
        Bundle,

        /// <summary>
        /// Balloon, non-protected (Code: XBF)
        /// </summary>
        Balloon_NonProtected,

        /// <summary>
        /// Bag (Code: XBG)
        /// </summary>
        /// <remarks>
        /// A receptacle made of flexible material with an open or closed top.
        /// </remarks>
        Bag,

        /// <summary>
        /// Bunch (Code: XBH)
        /// </summary>
        Bunch,

        /// <summary>
        /// Bin (Code: XBI)
        /// </summary>
        Bin,

        /// <summary>
        /// Bucket (Code: XBJ)
        /// </summary>
        Bucket,

        /// <summary>
        /// Basket (Code: XBK)
        /// </summary>
        Basket,

        /// <summary>
        /// Bale, compressed (Code: XBL)
        /// </summary>
        Bale_Compressed,

        /// <summary>
        /// Basin (Code: XBM)
        /// </summary>
        Basin,

        /// <summary>
        /// Bale, non-compressed (Code: XBN)
        /// </summary>
        Bale_NonCompressed,

        /// <summary>
        /// Bottle, non-protected, cylindrical (Code: XBO)
        /// </summary>
        /// <remarks>
        /// A narrow-necked cylindrical shaped vessel without external protective packing material.
        /// </remarks>
        Bottle_NonProtected_Cylindrical,

        /// <summary>
        /// Balloon, protected (Code: XBP)
        /// </summary>
        Balloon_Protected,

        /// <summary>
        /// Bottle, protected cylindrical (Code: XBQ)
        /// </summary>
        /// <remarks>
        /// A narrow-necked cylindrical shaped vessel with external protective packing material.
        /// </remarks>
        Bottle_ProtectedCylindrical,

        /// <summary>
        /// Bar (Code: XBR)
        /// </summary>
        Bar,

        /// <summary>
        /// Bottle, non-protected, bulbous (Code: XBS)
        /// </summary>
        /// <remarks>
        /// A narrow-necked bulb shaped vessel without external protective packing material.
        /// </remarks>
        Bottle_NonProtected_Bulbous,

        /// <summary>
        /// Bolt (Code: XBT)
        /// </summary>
        Bolt,

        /// <summary>
        /// Butt (Code: XBU)
        /// </summary>
        Butt,

        /// <summary>
        /// Bottle, protected bulbous (Code: XBV)
        /// </summary>
        /// <remarks>
        /// A narrow-necked bulb shaped vessel with external protective packing material.
        /// </remarks>
        Bottle_ProtectedBulbous,

        /// <summary>
        /// Box, for liquids (Code: XBW)
        /// </summary>
        Box_ForLiquids,

        /// <summary>
        /// Box (Code: XBX)
        /// </summary>
        Box,

        /// <summary>
        /// Board, in bundle/bunch/truss (Code: XBY)
        /// </summary>
        Board_InBundlePerBunchPerTruss,

        /// <summary>
        /// Bars, in bundle/bunch/truss (Code: XBZ)
        /// </summary>
        Bars_InBundlePerBunchPerTruss,

        /// <summary>
        /// Can, rectangular (Code: XCA)
        /// </summary>
        Can_Rectangular,

        /// <summary>
        /// Crate, beer (Code: XCB)
        /// </summary>
        Crate_Beer,

        /// <summary>
        /// Churn (Code: XCC)
        /// </summary>
        Churn,

        /// <summary>
        /// Can, with handle and spout (Code: XCD)
        /// </summary>
        Can_WithHandleAndSpout,

        /// <summary>
        /// Creel (Code: XCE)
        /// </summary>
        Creel,

        /// <summary>
        /// Coffer (Code: XCF)
        /// </summary>
        Coffer,

        /// <summary>
        /// Cage (Code: XCG)
        /// </summary>
        Cage,

        /// <summary>
        /// Chest (Code: XCH)
        /// </summary>
        Chest,

        /// <summary>
        /// Canister (Code: XCI)
        /// </summary>
        Canister,

        /// <summary>
        /// Coffin (Code: XCJ)
        /// </summary>
        Coffin,

        /// <summary>
        /// Cask (Code: XCK)
        /// </summary>
        Cask,

        /// <summary>
        /// Coil (Code: XCL)
        /// </summary>
        Coil,

        /// <summary>
        /// Card (Code: XCM)
        /// </summary>
        /// <remarks>
        /// A flat package usually made of fibreboard from/to which product is often hung or attached.
        /// </remarks>
        Card_FlatPackage,

        /// <summary>
        /// Container, not otherwise specified as transport equipment (Code: XCN)
        /// </summary>
        Container_NotOtherwiseSpecifiedAsTransportEquipment,

        /// <summary>
        /// Carboy, non-protected (Code: XCO)
        /// </summary>
        Carboy_NonProtected,

        /// <summary>
        /// Carboy, protected (Code: XCP)
        /// </summary>
        Carboy_Protected,

        /// <summary>
        /// Cartridge (Code: XCQ)
        /// </summary>
        /// <remarks>
        /// Package containing a charge such as propelling explosive for firearms or ink toner for a printer.
        /// </remarks>
        Cartridge,

        /// <summary>
        /// Crate (Code: XCR)
        /// </summary>
        Crate,

        /// <summary>
        /// Case (Code: XCS)
        /// </summary>
        Case,

        /// <summary>
        /// Carton (Code: XCT)
        /// </summary>
        Carton,

        /// <summary>
        /// Cup (Code: XCU)
        /// </summary>
        Cup,

        /// <summary>
        /// Cover (Code: XCV)
        /// </summary>
        Cover,

        /// <summary>
        /// Cage, roll (Code: XCW)
        /// </summary>
        Cage_Roll,

        /// <summary>
        /// Can, cylindrical (Code: XCX)
        /// </summary>
        Can_Cylindrical,

        /// <summary>
        /// Cylinder (Code: XCY)
        /// </summary>
        Cylinder,

        /// <summary>
        /// Canvas (Code: XCZ)
        /// </summary>
        Canvas,

        /// <summary>
        /// Crate, multiple layer, plastic (Code: XDA)
        /// </summary>
        Crate_MultipleLayer_Plastic,

        /// <summary>
        /// Crate, multiple layer, wooden (Code: XDB)
        /// </summary>
        Crate_MultipleLayer_Wooden,

        /// <summary>
        /// Crate, multiple layer, cardboard (Code: XDC)
        /// </summary>
        Crate_MultipleLayer_Cardboard,

        /// <summary>
        /// Cage, Commonwealth Handling Equipment Pool (CHEP) (Code: XDG)
        /// </summary>
        Cage_CommonwealthHandlingEquipmentPool_CHEP,

        /// <summary>
        /// Box, Commonwealth Handling Equipment Pool (CHEP), Eurobox (Code: XDH)
        /// </summary>
        /// <remarks>
        /// A box mounted on a pallet base under the control of CHEP.
        /// </remarks>
        Box_CommonwealthHandlingEquipmentPool_CHEP_Eurobox,

        /// <summary>
        /// Drum, iron (Code: XDI)
        /// </summary>
        Drum_Iron,

        /// <summary>
        /// Demijohn, non-protected (Code: XDJ)
        /// </summary>
        Demijohn_NonProtected,

        /// <summary>
        /// Crate, bulk, cardboard (Code: XDK)
        /// </summary>
        Crate_Bulk_Cardboard,

        /// <summary>
        /// Crate, bulk, plastic (Code: XDL)
        /// </summary>
        Crate_Bulk_Plastic,

        /// <summary>
        /// Crate, bulk, wooden (Code: XDM)
        /// </summary>
        Crate_Bulk_Wooden,

        /// <summary>
        /// Dispenser (Code: XDN)
        /// </summary>
        Dispenser,

        /// <summary>
        /// Demijohn, protected (Code: XDP)
        /// </summary>
        Demijohn_Protected,

        /// <summary>
        /// Drum (Code: XDR)
        /// </summary>
        Drum,

        /// <summary>
        /// Tray, one layer no cover, plastic (Code: XDS)
        /// </summary>
        Tray_OneLayerNoCover_Plastic,

        /// <summary>
        /// Tray, one layer no cover, wooden (Code: XDT)
        /// </summary>
        Tray_OneLayerNoCover_Wooden,

        /// <summary>
        /// Tray, one layer no cover, polystyrene (Code: XDU)
        /// </summary>
        Tray_OneLayerNoCover_Polystyrene,

        /// <summary>
        /// Tray, one layer no cover, cardboard (Code: XDV)
        /// </summary>
        Tray_OneLayerNoCover_Cardboard,

        /// <summary>
        /// Tray, two layers no cover, plastic tray (Code: XDW)
        /// </summary>
        Tray_TwoLayersNoCover_PlasticTray,

        /// <summary>
        /// Tray, two layers no cover, wooden (Code: XDX)
        /// </summary>
        Tray_TwoLayersNoCover_Wooden,

        /// <summary>
        /// Tray, two layers no cover, cardboard (Code: XDY)
        /// </summary>
        Tray_TwoLayersNoCover_Cardboard,

        /// <summary>
        /// Bag, plastic (Code: XEC)
        /// </summary>
        Bag_Plastic,

        /// <summary>
        /// Case, with pallet base (Code: XED)
        /// </summary>
        Case_WithPalletBase,

        /// <summary>
        /// Case, with pallet base, wooden (Code: XEE)
        /// </summary>
        Case_WithPalletBase_Wooden,

        /// <summary>
        /// Case, with pallet base, cardboard (Code: XEF)
        /// </summary>
        Case_WithPalletBase_Cardboard,

        /// <summary>
        /// Case, with pallet base, plastic (Code: XEG)
        /// </summary>
        Case_WithPalletBase_Plastic,

        /// <summary>
        /// Case, with pallet base, metal (Code: XEH)
        /// </summary>
        Case_WithPalletBase_Metal,

        /// <summary>
        /// Case, isothermic (Code: XEI)
        /// </summary>
        Case_Isothermic,

        /// <summary>
        /// Envelope (Code: XEN)
        /// </summary>
        Envelope,

        /// <summary>
        /// Flexibag (Code: XFB)
        /// </summary>
        /// <remarks>
        /// A flexible containment bag made of plastic, typically for the transportation bulk non-hazardous cargoes using standard size shipping containers.
        /// </remarks>
        Flexibag,

        /// <summary>
        /// Crate, fruit (Code: XFC)
        /// </summary>
        Crate_Fruit,

        /// <summary>
        /// Crate, framed (Code: XFD)
        /// </summary>
        Crate_Framed,

        /// <summary>
        /// Flexitank (Code: XFE)
        /// </summary>
        /// <remarks>
        /// A flexible containment tank made of plastic, typically for the transportation bulk non-hazardous cargoes using standard size shipping containers.
        /// </remarks>
        Flexitank,

        /// <summary>
        /// Firkin (Code: XFI)
        /// </summary>
        Firkin,

        /// <summary>
        /// Flask (Code: XFL)
        /// </summary>
        Flask,

        /// <summary>
        /// Footlocker (Code: XFO)
        /// </summary>
        Footlocker,

        /// <summary>
        /// Filmpack (Code: XFP)
        /// </summary>
        Filmpack,

        /// <summary>
        /// Frame (Code: XFR)
        /// </summary>
        Frame,

        /// <summary>
        /// Foodtainer (Code: XFT)
        /// </summary>
        Foodtainer,

        /// <summary>
        /// Cart, flatbed (Code: XFW)
        /// </summary>
        /// <remarks>
        /// Wheeled flat bedded device on which trays or other regular shaped items are packed for transportation purposes.
        /// </remarks>
        Cart_Flatbed,

        /// <summary>
        /// Bag, flexible container (Code: XFX)
        /// </summary>
        Bag_FlexibleContainer,

        /// <summary>
        /// Bottle, gas (Code: XGB)
        /// </summary>
        /// <remarks>
        /// A narrow-necked metal cylinder for retention of liquefied or compressed gas.
        /// </remarks>
        Bottle_Gas,

        /// <summary>
        /// Girder (Code: XGI)
        /// </summary>
        Girder,

        /// <summary>
        /// Container, gallon (Code: XGL)
        /// </summary>
        /// <remarks>
        /// A container with a capacity of one gallon.
        /// </remarks>
        Container_Gallon,

        /// <summary>
        /// Receptacle, glass (Code: XGR)
        /// </summary>
        /// <remarks>
        /// Containment vessel made of glass for retaining substances or articles.
        /// </remarks>
        Receptacle_Glass,

        /// <summary>
        /// Tray, containing horizontally stacked flat items (Code: XGU)
        /// </summary>
        /// <remarks>
        /// Tray containing flat items stacked on top of one another.
        /// </remarks>
        Tray_ContainingHorizontallyStackedFlatItems,

        /// <summary>
        /// Bag, gunny (Code: XGY)
        /// </summary>
        /// <remarks>
        /// A sack made of gunny or burlap, used for transporting coarse commodities, such as grains, potatoes, and other agricultural products.
        /// </remarks>
        Bag_Gunny,

        /// <summary>
        /// Girders, in bundle/bunch/truss (Code: XGZ)
        /// </summary>
        Girders_InBundlePerBunchPerTruss,

        /// <summary>
        /// Basket, with handle, plastic (Code: XHA)
        /// </summary>
        Basket_WithHandle_Plastic,

        /// <summary>
        /// Basket, with handle, wooden (Code: XHB)
        /// </summary>
        Basket_WithHandle_Wooden,

        /// <summary>
        /// Basket, with handle, cardboard (Code: XHC)
        /// </summary>
        Basket_WithHandle_Cardboard,

        /// <summary>
        /// Hogshead (Code: XHG)
        /// </summary>
        Hogshead,

        /// <summary>
        /// Hanger (Code: XHN)
        /// </summary>
        /// <remarks>
        /// A purpose shaped device with a hook at the top for hanging items from a rail.
        /// </remarks>
        Hanger,

        /// <summary>
        /// Hamper (Code: XHR)
        /// </summary>
        Hamper,

        /// <summary>
        /// Package, display, wooden (Code: XIA)
        /// </summary>
        Package_Display_Wooden,

        /// <summary>
        /// Package, display, cardboard (Code: XIB)
        /// </summary>
        Package_Display_Cardboard,

        /// <summary>
        /// Package, display, plastic (Code: XIC)
        /// </summary>
        Package_Display_Plastic,

        /// <summary>
        /// Package, display, metal (Code: XID)
        /// </summary>
        Package_Display_Metal,

        /// <summary>
        /// Package, show (Code: XIE)
        /// </summary>
        Package_Show,

        /// <summary>
        /// Package, flow (Code: XIF)
        /// </summary>
        /// <remarks>
        /// A flexible tubular package or skin, possibly transparent, often used for containment of foodstuffs (e.g. salami sausage).
        /// </remarks>
        Package_Flow,

        /// <summary>
        /// Package, paper wrapped (Code: XIG)
        /// </summary>
        Package_PaperWrapped,

        /// <summary>
        /// Drum, plastic (Code: XIH)
        /// </summary>
        Drum_Plastic,

        /// <summary>
        /// Package, cardboard, with bottle grip-holes (Code: XIK)
        /// </summary>
        /// <remarks>
        /// Packaging material made out of cardboard that facilitates the separation of individual glass or plastic bottles.
        /// </remarks>
        Package_Cardboard_WithBottleGripHoles,

        /// <summary>
        /// Tray, rigid, lidded stackable (CEN TS 14482:2002) (Code: XIL)
        /// </summary>
        /// <remarks>
        /// Lidded stackable rigid tray compliant with CEN TS 14482:2002.
        /// </remarks>
        Tray_Rigid_LiddedStackable_CENTS14482_2002,

        /// <summary>
        /// Ingot (Code: XIN)
        /// </summary>
        Ingot,

        /// <summary>
        /// Ingots, in bundle/bunch/truss (Code: XIZ)
        /// </summary>
        Ingots_InBundlePerBunchPerTruss,

        /// <summary>
        /// Bag, jumbo (Code: XJB)
        /// </summary>
        /// <remarks>
        /// A flexible containment bag, widely used for storage, transportation and handling of powder, flake or granular materials. Typically constructed from woven polypropylene (PP) fabric in the form of cubic bags.
        /// </remarks>
        Bag_Jumbo,

        /// <summary>
        /// Jerrican, rectangular (Code: XJC)
        /// </summary>
        Jerrican_Rectangular,

        /// <summary>
        /// Jug (Code: XJG)
        /// </summary>
        Jug,

        /// <summary>
        /// Jar (Code: XJR)
        /// </summary>
        Jar,

        /// <summary>
        /// Jutebag (Code: XJT)
        /// </summary>
        Jutebag,

        /// <summary>
        /// Jerrican, cylindrical (Code: XJY)
        /// </summary>
        Jerrican_Cylindrical,

        /// <summary>
        /// Keg (Code: XKG)
        /// </summary>
        Keg,

        /// <summary>
        /// Kit (Code: XKI)
        /// </summary>
        /// <remarks>
        /// A set of articles or implements used for a specific purpose.
        /// </remarks>
        Kit_SetOfAtriclesOrImplements,

        /// <summary>
        /// Luggage (Code: XLE)
        /// </summary>
        /// <remarks>
        /// A collection of bags, cases and/or containers which hold personal belongings for a journey.
        /// </remarks>
        Luggage,

        /// <summary>
        /// Log (Code: XLG)
        /// </summary>
        Log,

        /// <summary>
        /// Lot (Code: XLT)
        /// </summary>
        Lot,

        /// <summary>
        /// Lug (Code: XLU)
        /// </summary>
        /// <remarks>
        /// A wooden box for the transportation and storage of fruit or vegetables.
        /// </remarks>
        Lug,

        /// <summary>
        /// Liftvan (Code: XLV)
        /// </summary>
        /// <remarks>
        /// A wooden or metal container used for packing household goods and personal effects.
        /// </remarks>
        Liftvan,

        /// <summary>
        /// Logs, in bundle/bunch/truss (Code: XLZ)
        /// </summary>
        Logs_InBundlePerBunchPerTruss,

        /// <summary>
        /// Crate, metal (Code: XMA)
        /// </summary>
        /// <remarks>
        /// Containment box made of metal for retaining substances or articles.
        /// </remarks>
        Crate_Metal,

        /// <summary>
        /// Bag, multiply (Code: XMB)
        /// </summary>
        Bag_Multiply,

        /// <summary>
        /// Crate, milk (Code: XMC)
        /// </summary>
        Crate_Milk,

        /// <summary>
        /// Container, metal (Code: XME)
        /// </summary>
        /// <remarks>
        /// A type of containment box made of metal for retaining substances or articles, not otherwise specified as transport equipment.
        /// </remarks>
        Container_Metal,

        /// <summary>
        /// Receptacle, metal (Code: XMR)
        /// </summary>
        /// <remarks>
        /// Containment vessel made of metal for retaining substances or articles.
        /// </remarks>
        Receptacle_Metal,

        /// <summary>
        /// Sack, multi-wall (Code: XMS)
        /// </summary>
        Sack_MultiWall,

        /// <summary>
        /// Mat (Code: XMT)
        /// </summary>
        Mat,

        /// <summary>
        /// Receptacle, plastic wrapped (Code: XMW)
        /// </summary>
        /// <remarks>
        /// Containment vessel wrapped with plastic for retaining substances or articles.
        /// </remarks>
        Receptacle_PlasticWrapped,

        /// <summary>
        /// Matchbox (Code: XMX)
        /// </summary>
        Matchbox,

        /// <summary>
        /// Not available (Code: XNA)
        /// </summary>
        NotAvailable,

        /// <summary>
        /// Unpacked or unpackaged (Code: XNE)
        /// </summary>
        UnpackedOrUnpackaged,

        /// <summary>
        /// Unpacked or unpackaged, single unit (Code: XNF)
        /// </summary>
        UnpackedOrUnpackaged_SingleUnit,

        /// <summary>
        /// Unpacked or unpackaged, multiple units (Code: XNG)
        /// </summary>
        UnpackedOrUnpackaged_MultipleUnits,

        /// <summary>
        /// Nest (Code: XNS)
        /// </summary>
        Nest,

        /// <summary>
        /// Net (Code: XNT)
        /// </summary>
        Net,

        /// <summary>
        /// Net, tube, plastic (Code: XNU)
        /// </summary>
        Net_Tube_Plastic,

        /// <summary>
        /// Net, tube, textile (Code: XNV)
        /// </summary>
        Net_Tube_Textile,

        /// <summary>
        /// Two sided cage on wheels with fixing strap (Code: XO1)
        /// </summary>
        TwoSidedCageOnWheelsWithFixingStrap,

        /// <summary>
        /// Trolley (Code: XO2)
        /// </summary>
        Trolley,

        /// <summary>
        /// Oneway pallet ISO 0 - 1/2 EURO Pallet (Code: XO3)
        /// </summary>
        OnewayPalletISO01Per2EUROPallet,

        /// <summary>
        /// Oneway pallet ISO 1 - 1/1 EURO Pallet (Code: XO4)
        /// </summary>
        OnewayPalletISO11Per1EUROPallet,

        /// <summary>
        /// Oneway pallet ISO 2 - 2/1 EURO Pallet (Code: XO5)
        /// </summary>
        OnewayPalletISO22Per1EUROPallet,

        /// <summary>
        /// Pallet with exceptional dimensions (Code: XO6)
        /// </summary>
        PalletWithExceptionalDimensions,

        /// <summary>
        /// Wooden pallet 40 cm x 80 cm (Code: XO7)
        /// </summary>
        WoodenPallet40CmX80Cm,

        /// <summary>
        /// Plastic pallet SRS 60 cm x 80 cm (Code: XO8)
        /// </summary>
        PlasticPalletSRS60CmX80Cm,

        /// <summary>
        /// Plastic pallet SRS 80 cm x 120 cm (Code: XO9)
        /// </summary>
        PlasticPalletSRS80CmX120Cm,

        /// <summary>
        /// Pallet, CHEP 40 cm x 60 cm (Code: XOA)
        /// </summary>
        /// <remarks>
        /// Commonwealth Handling Equipment Pool (CHEP) standard pallet of dimensions 40 centimeters x 60 centimeters.
        /// </remarks>
        Pallet_CHEP40CmX60Cm,

        /// <summary>
        /// Pallet, CHEP 80 cm x 120 cm (Code: XOB)
        /// </summary>
        /// <remarks>
        /// Commonwealth Handling Equipment Pool (CHEP) standard pallet of dimensions 80 centimeters x 120 centimeters.
        /// </remarks>
        Pallet_CHEP80CmX120Cm,

        /// <summary>
        /// Pallet, CHEP 100 cm x 120 cm (Code: XOC)
        /// </summary>
        /// <remarks>
        /// Commonwealth Handling Equipment Pool (CHEP) standard pallet of dimensions 100 centimeters x 120 centimeters.
        /// </remarks>
        Pallet_CHEP100CmX120Cm,

        /// <summary>
        /// Pallet, AS 4068-1993 (Code: XOD)
        /// </summary>
        /// <remarks>
        /// Australian standard pallet of dimensions 115.5 centimeters x 116.5 centimeters.
        /// </remarks>
        Pallet_AS40681993,

        /// <summary>
        /// Pallet, ISO T11 (Code: XOE)
        /// </summary>
        /// <remarks>
        /// ISO standard pallet of dimensions 110 centimeters x 110 centimeters, prevalent in Asia - Pacific region.
        /// </remarks>
        Pallet_ISOT11,

        /// <summary>
        /// Platform, unspecified weight or dimension (Code: XOF)
        /// </summary>
        /// <remarks>
        /// A pallet equivalent shipping platform of unknown dimensions or unknown weight.
        /// </remarks>
        Platform_UnspecifiedWeightOrDimension,

        /// <summary>
        /// Pallet ISO 0 - 1/2 EURO Pallet (Code: XOG)
        /// </summary>
        PalletISO01Per2EUROPallet,

        /// <summary>
        /// Pallet ISO 1 - 1/1 EURO Pallet (Code: XOH)
        /// </summary>
        PalletISO11Per1EUROPallet,

        /// <summary>
        /// Pallet ISO 2 – 2/1 EURO Pallet (Code: XOI)
        /// </summary>
        PalletISO22Per1EUROPallet,

        /// <summary>
        /// Block (Code: XOK)
        /// </summary>
        /// <remarks>
        /// A solid piece of a hard substance, such as granite, having one or more flat sides.
        /// </remarks>
        Block,

        /// <summary>
        /// 1/4 EURO Pallet (Code: XOJ)
        /// </summary>
        OnePerFourEUROPallet,

        /// <summary>
        /// 1/8 EURO Pallet (Code: XOL)
        /// </summary>
        OnePerEightEUROPallet,

        /// <summary>
        /// Synthetic pallet ISO 1 (Code: XOM)
        /// </summary>
        SyntheticPalletISO1,

        /// <summary>
        /// Synthetic pallet ISO 2 (Code: XON)
        /// </summary>
        SyntheticPalletISO2,

        /// <summary>
        /// Wholesaler pallet (Code: XOP)
        /// </summary>
        WholesalerPallet,

        /// <summary>
        /// Pallet 80 X 100 cm (Code: XOQ)
        /// </summary>
        Pallet80X100Cm,

        /// <summary>
        /// Pallet 60 X 100 cm (Code: XOR)
        /// </summary>
        Pallet60X100Cm,

        /// <summary>
        /// Oneway pallet (Code: XOS)
        /// </summary>
        OnewayPallet,

        /// <summary>
        /// Returnable pallet (Code: XOV)
        /// </summary>
        ReturnablePallet,

        /// <summary>
        /// Large bag, pallet sized (Code: XOW)
        /// </summary>
        LargeBag_PalletSized,

        /// <summary>
        /// Octabin (Code: XOT)
        /// </summary>
        /// <remarks>
        /// A standard cardboard container of large dimensions for storing for example vegetables, granules of plastics or other dry products.
        /// </remarks>
        Octabin,

        /// <summary>
        /// Container, outer (Code: XOU)
        /// </summary>
        /// <remarks>
        /// A type of containment box that serves as the outer shipping container, not otherwise specified as transport equipment.
        /// </remarks>
        Container_Outer,

        /// <summary>
        /// A wheeled pallet with raised rim (81 x 67 x 135) (Code: XOX)
        /// </summary>
        AWheeledPalletWithRaisedRim_81X67X135,

        /// <summary>
        /// A Wheeled pallet with raised rim (81 x 72 x 135) (Code: XOY)
        /// </summary>
        AWheeledPalletWithRaisedRim_81X72X135,

        /// <summary>
        /// Wheeled pallet with raised rim ( 81 x 60 x 16) (Code: XOZ)
        /// </summary>
        WheeledPalletWithRaisedRim_81X60X16,

        /// <summary>
        /// CHEP pallet 60 cm x 80 cm  (Code: XP1)
        /// </summary>
        CHEPPallet60CmX80Cm,

        /// <summary>
        /// Pan (Code: XP2)
        /// </summary>
        /// <remarks>
        /// A shallow, wide, open container, usually of metal.
        /// </remarks>
        Pan,

        /// <summary>
        /// LPR pallet 60 cm x 80 cm (Code: XP3)
        /// </summary>
        LPRPallet60CmX80Cm,

        /// <summary>
        /// LPR pallet 80 cm x 120 cm (Code: XP4)
        /// </summary>
        LPRPallet80CmX120Cm,

        /// <summary>
        /// Packet (Code: XPA)
        /// </summary>
        /// <remarks>
        /// Small package.
        /// </remarks>
        Packet,

        /// <summary>
        /// Pallet, box Combined open-ended box and pallet (Code: XPB)
        /// </summary>
        Pallet_BoxCombinedOpenEndedBoxAndPallet,

        /// <summary>
        /// Parcel (Code: XPC)
        /// </summary>
        Parcel,

        /// <summary>
        /// Pallet, modular, collars 80cms * 100cms (Code: XPD)
        /// </summary>
        /// <remarks>
        /// Standard sized pallet of dimensions 80 centimeters by 100 centimeters (cms).
        /// </remarks>
        Pallet_Modular_Collars80cmsTimes100cms,

        /// <summary>
        /// Pallet, modular, collars 80cms * 120cms (Code: XPE)
        /// </summary>
        /// <remarks>
        /// Standard sized pallet of dimensions 80 centimeters by 120 centimeters (cms).
        /// </remarks>
        Pallet_Modular_Collars80cmsTimes120cms,

        /// <summary>
        /// Pen (Code: XPF)
        /// </summary>
        /// <remarks>
        /// A small open top enclosure for retaining animals.
        /// </remarks>
        Pen,

        /// <summary>
        /// Plate (Code: XPG)
        /// </summary>
        Plate,

        /// <summary>
        /// Pitcher (Code: XPH)
        /// </summary>
        Pitcher,

        /// <summary>
        /// Pipe (Code: XPI)
        /// </summary>
        Pipe,

        /// <summary>
        /// Punnet (Code: XPJ)
        /// </summary>
        Punnet,

        /// <summary>
        /// Package (Code: XPK)
        /// </summary>
        /// <remarks>
        /// Standard packaging unit.
        /// </remarks>
        Package,

        /// <summary>
        /// Pail (Code: XPL)
        /// </summary>
        Pail,

        /// <summary>
        /// Plank (Code: XPN)
        /// </summary>
        Plank,

        /// <summary>
        /// Pouch (Code: XPO)
        /// </summary>
        Pouch,

        /// <summary>
        /// Piece (Code: XPP)
        /// </summary>
        /// <remarks>
        /// A loose or unpacked article.
        /// </remarks>
        Piece_LoosOrUnpackedArticle,

        /// <summary>
        /// Receptacle, plastic (Code: XPR)
        /// </summary>
        /// <remarks>
        /// Containment vessel made of plastic for retaining substances or articles.
        /// </remarks>
        Receptacle_Plastic,

        /// <summary>
        /// Pot (Code: XPT)
        /// </summary>
        Pot,

        /// <summary>
        /// Tray (Code: XPU)
        /// </summary>
        Tray,

        /// <summary>
        /// Pipes, in bundle/bunch/truss (Code: XPV)
        /// </summary>
        Pipes_InBundlePerBunchPerTruss,

        /// <summary>
        /// Pallet (Code: XPX)
        /// </summary>
        /// <remarks>
        /// Platform or open-ended box, usually made of wood, on which goods are retained for ease of mechanical handling during transport and storage.
        /// </remarks>
        Pallet,

        /// <summary>
        /// Plates, in bundle/bunch/truss (Code: XPY)
        /// </summary>
        Plates_InBundlePerBunchPerTruss,

        /// <summary>
        /// Planks, in bundle/bunch/truss (Code: XPZ)
        /// </summary>
        Planks_InBundlePerBunchPerTruss,

        /// <summary>
        /// Drum, steel, non-removable head (Code: XQA)
        /// </summary>
        Drum_Steel_NonRemovableHead,

        /// <summary>
        /// Drum, steel, removable head (Code: XQB)
        /// </summary>
        Drum_Steel_RemovableHead,

        /// <summary>
        /// Drum, aluminium, non-removable head (Code: XQC)
        /// </summary>
        Drum_Aluminium_NonRemovableHead,

        /// <summary>
        /// Drum, aluminium, removable head (Code: XQD)
        /// </summary>
        Drum_Aluminium_RemovableHead,

        /// <summary>
        /// Drum, plastic, non-removable head (Code: XQF)
        /// </summary>
        Drum_Plastic_NonRemovableHead,

        /// <summary>
        /// Drum, plastic, removable head (Code: XQG)
        /// </summary>
        Drum_Plastic_RemovableHead,

        /// <summary>
        /// Barrel, wooden, bung type (Code: XQH)
        /// </summary>
        Barrel_Wooden_BungType,

        /// <summary>
        /// Barrel, wooden, removable head (Code: XQJ)
        /// </summary>
        Barrel_Wooden_RemovableHead,

        /// <summary>
        /// Jerrican, steel, non-removable head (Code: XQK)
        /// </summary>
        Jerrican_Steel_NonRemovableHead,

        /// <summary>
        /// Jerrican, steel, removable head (Code: XQL)
        /// </summary>
        Jerrican_Steel_RemovableHead,

        /// <summary>
        /// Jerrican, plastic, non-removable head (Code: XQM)
        /// </summary>
        Jerrican_Plastic_NonRemovableHead,

        /// <summary>
        /// Jerrican, plastic, removable head (Code: XQN)
        /// </summary>
        Jerrican_Plastic_RemovableHead,

        /// <summary>
        /// Box, wooden, natural wood, ordinary (Code: XQP)
        /// </summary>
        Box_Wooden_NaturalWood_Ordinary,

        /// <summary>
        /// Box, wooden, natural wood, with sift proof walls (Code: XQQ)
        /// </summary>
        Box_Wooden_NaturalWood_WithSiftProofWalls,

        /// <summary>
        /// Box, plastic, expanded (Code: XQR)
        /// </summary>
        Box_Plastic_Expanded,

        /// <summary>
        /// Box, plastic, solid (Code: XQS)
        /// </summary>
        Box_Plastic_Solid,

        /// <summary>
        /// Rod (Code: XRD)
        /// </summary>
        Rod,

        /// <summary>
        /// Ring (Code: XRG)
        /// </summary>
        Ring,

        /// <summary>
        /// Rack, clothing hanger (Code: XRJ)
        /// </summary>
        Rack_ClothingHanger,

        /// <summary>
        /// Rack (Code: XRK)
        /// </summary>
        Rack,

        /// <summary>
        /// Reel (Code: XRL)
        /// </summary>
        /// <remarks>
        /// Cylindrical rotatory device with a rim at each end on which materials are wound.
        /// </remarks>
        Reel,

        /// <summary>
        /// Roll (Code: XRO)
        /// </summary>
        Roll,

        /// <summary>
        /// Rednet (Code: XRT)
        /// </summary>
        /// <remarks>
        /// Containment material made of red mesh netting for retaining articles (e.g. trees).
        /// </remarks>
        Rednet,

        /// <summary>
        /// Rods, in bundle/bunch/truss (Code: XRZ)
        /// </summary>
        Rods_InBundlePerBunchPerTruss,

        /// <summary>
        /// Sack (Code: XSA)
        /// </summary>
        Sack,

        /// <summary>
        /// Slab (Code: XSB)
        /// </summary>
        Slab,

        /// <summary>
        /// Crate, shallow (Code: XSC)
        /// </summary>
        Crate_Shallow,

        /// <summary>
        /// Spindle (Code: XSD)
        /// </summary>
        Spindle,

        /// <summary>
        /// Sea-chest (Code: XSE)
        /// </summary>
        SeaChest,

        /// <summary>
        /// Sachet (Code: XSH)
        /// </summary>
        Sachet,

        /// <summary>
        /// Skid (Code: XSI)
        /// </summary>
        /// <remarks>
        /// A low movable platform or pallet to facilitate the handling and transport of goods.
        /// </remarks>
        Skid,

        /// <summary>
        /// Case, skeleton (Code: XSK)
        /// </summary>
        Case_Skeleton,

        /// <summary>
        /// Slipsheet (Code: XSL)
        /// </summary>
        /// <remarks>
        /// Hard plastic sheeting primarily used as the base on which to stack goods to optimise the space within a container. May be used as an alternative to a palletized packaging.
        /// </remarks>
        Slipsheet,

        /// <summary>
        /// Sheetmetal (Code: XSM)
        /// </summary>
        Sheetmetal,

        /// <summary>
        /// Spool (Code: XSO)
        /// </summary>
        /// <remarks>
        /// A packaging container used in the transport of such items as wire, cable, tape and yarn.
        /// </remarks>
        Spool,

        /// <summary>
        /// Sheet, plastic wrapping (Code: XSP)
        /// </summary>
        Sheet_PlasticWrapping,

        /// <summary>
        /// Case, steel (Code: XSS)
        /// </summary>
        Case_Steel,

        /// <summary>
        /// Sheet (Code: XST)
        /// </summary>
        Sheet,

        /// <summary>
        /// Suitcase (Code: XSU)
        /// </summary>
        Suitcase,

        /// <summary>
        /// Envelope, steel (Code: XSV)
        /// </summary>
        Envelope_Steel,

        /// <summary>
        /// Shrinkwrapped (Code: XSW)
        /// </summary>
        /// <remarks>
        /// Goods retained in a transparent plastic film that has been wrapped around and then shrunk tightly on to the goods.
        /// </remarks>
        Shrinkwrapped,

        /// <summary>
        /// Set (Code: XSX)
        /// </summary>
        Set,

        /// <summary>
        /// Sleeve (Code: XSY)
        /// </summary>
        Sleeve,

        /// <summary>
        /// Sheets, in bundle/bunch/truss (Code: XSZ)
        /// </summary>
        Sheets_InBundlePerBunchPerTruss,

        /// <summary>
        /// Tablet (Code: XT1)
        /// </summary>
        /// <remarks>
        /// A loose or unpacked article in the form of a bar, block or piece.
        /// </remarks>
        Tablet_LooseOrUnpackedArticle,

        /// <summary>
        /// Tub (Code: XTB)
        /// </summary>
        Tub,

        /// <summary>
        /// Tea-chest (Code: XTC)
        /// </summary>
        TeaChest,

        /// <summary>
        /// Tube, collapsible (Code: XTD)
        /// </summary>
        Tube_Collapsible,

        /// <summary>
        /// Tyre (Code: XTE)
        /// </summary>
        /// <remarks>
        /// A ring made of rubber and/or metal surrounding a wheel.
        /// </remarks>
        Tyre,

        /// <summary>
        /// Tank container, generic (Code: XTG)
        /// </summary>
        /// <remarks>
        /// A specially constructed container for transporting liquids and gases in bulk.
        /// </remarks>
        TankContainer_Generic,

        /// <summary>
        /// Tierce (Code: XTI)
        /// </summary>
        Tierce,

        /// <summary>
        /// Tank, rectangular (Code: XTK)
        /// </summary>
        Tank_Rectangular,

        /// <summary>
        /// Tub, with lid (Code: XTL)
        /// </summary>
        Tub_WithLid,

        /// <summary>
        /// Tin (Code: XTN)
        /// </summary>
        Tin,

        /// <summary>
        /// Tun (Code: XTO)
        /// </summary>
        Tun,

        /// <summary>
        /// Trunk (Code: XTR)
        /// </summary>
        Trunk,

        /// <summary>
        /// Truss (Code: XTS)
        /// </summary>
        Truss,

        /// <summary>
        /// Bag, tote (Code: XTT)
        /// </summary>
        /// <remarks>
        /// A capacious bag or basket.
        /// </remarks>
        Bag_Tote,

        /// <summary>
        /// Tube (Code: XTU)
        /// </summary>
        Tube,

        /// <summary>
        /// Tube, with nozzle (Code: XTV)
        /// </summary>
        /// <remarks>
        /// A tube made of plastic, metal or cardboard fitted with a nozzle, containing a liquid or semi-liquid product, e.g. silicon.
        /// </remarks>
        Tube_WithNozzle,

        /// <summary>
        /// Pallet, triwall (Code: XTW)
        /// </summary>
        /// <remarks>
        /// A lightweight pallet made from heavy duty corrugated board.
        /// </remarks>
        Pallet_Triwall,

        /// <summary>
        /// Tank, cylindrical (Code: XTY)
        /// </summary>
        Tank_Cylindrical,

        /// <summary>
        /// Tubes, in bundle/bunch/truss (Code: XTZ)
        /// </summary>
        Tubes_InBundlePerBunchPerTruss,

        /// <summary>
        /// Uncaged (Code: XUC)
        /// </summary>
        Uncaged,

        /// <summary>
        /// Unit (Code: XUN)
        /// </summary>
        /// <remarks>
        /// A type of package composed of a single item or object, not otherwise specified as a unit of transport equipment.
        /// </remarks>
        Unit,

        /// <summary>
        /// Vat (Code: XVA)
        /// </summary>
        Vat,

        /// <summary>
        /// Bulk, gas (at 1031 mbar and 15°C) (Code: XVG)
        /// </summary>
        Bulk_Gas_at1031MbarAnd15Celsius,

        /// <summary>
        /// Vial (Code: XVI)
        /// </summary>
        Vial,

        /// <summary>
        /// Vanpack (Code: XVK)
        /// </summary>
        /// <remarks>
        /// A type of wooden crate.
        /// </remarks>
        Vanpack,

        /// <summary>
        /// Bulk, liquid (Code: XVL)
        /// </summary>
        Bulk_Liquid,

        /// <summary>
        /// Bulk, solid, large particles (“nodules”) (Code: XVO)
        /// </summary>
        Bulk_Solid_LargeParticles_Nodules,

        /// <summary>
        /// Vacuum-packed (Code: XVP)
        /// </summary>
        VacuumPacked,

        /// <summary>
        /// Bulk, liquefied gas (at abnormal temperature/pressure) (Code: XVQ)
        /// </summary>
        Bulk_LiquefiedGas_atAbnormalTemperaturePerPressure,

        /// <summary>
        /// Vehicle (Code: XVN)
        /// </summary>
        /// <remarks>
        /// A self-propelled means of conveyance.
        /// </remarks>
        Vehicle,

        /// <summary>
        /// Bulk, solid, granular particles (“grains”) (Code: XVR)
        /// </summary>
        Bulk_Solid_GranularParticles_Grains,

        /// <summary>
        /// Bulk, scrap metal (Code: XVS)
        /// </summary>
        /// <remarks>
        /// Loose or unpacked scrap metal transported in bulk form.
        /// </remarks>
        Bulk_ScrapMetal,

        /// <summary>
        /// Bulk, solid, fine particles (“powders”) (Code: XVY)
        /// </summary>
        Bulk_Solid_FineParticles_Powders,

        /// <summary>
        /// Intermediate bulk container (Code: XWA)
        /// </summary>
        /// <remarks>
        /// A reusable container made of metal, plastic, textile, wood or composite materials used to facilitate transportation of bulk solids and liquids in manageable volumes.
        /// </remarks>
        IntermediateBulkContainer,

        /// <summary>
        /// Wickerbottle (Code: XWB)
        /// </summary>
        Wickerbottle,

        /// <summary>
        /// Intermediate bulk container, steel (Code: XWC)
        /// </summary>
        IntermediateBulkContainer_Steel,

        /// <summary>
        /// Intermediate bulk container, aluminium (Code: XWD)
        /// </summary>
        IntermediateBulkContainer_Aluminium,

        /// <summary>
        /// Intermediate bulk container, metal (Code: XWF)
        /// </summary>
        IntermediateBulkContainer_Metal,

        /// <summary>
        /// Intermediate bulk container, steel, pressurised > 10 kpa (Code: XWG)
        /// </summary>
        IntermediateBulkContainer_Steel_PressurisedGreaterThan10Kpa,

        /// <summary>
        /// Intermediate bulk container, aluminium, pressurised > 10 kpa (Code: XWH)
        /// </summary>
        IntermediateBulkContainer_Aluminium_PressurisedGreaterThan10Kpa,

        /// <summary>
        /// Intermediate bulk container, metal, pressure 10 kpa (Code: XWJ)
        /// </summary>
        IntermediateBulkContainer_Metal_Pressure10Kpa,

        /// <summary>
        /// Intermediate bulk container, steel, liquid (Code: XWK)
        /// </summary>
        IntermediateBulkContainer_Steel_Liquid,

        /// <summary>
        /// Intermediate bulk container, aluminium, liquid (Code: XWL)
        /// </summary>
        IntermediateBulkContainer_Aluminium_Liquid,

        /// <summary>
        /// Intermediate bulk container, metal, liquid (Code: XWM)
        /// </summary>
        IntermediateBulkContainer_Metal_Liquid,

        /// <summary>
        /// Intermediate bulk container, woven plastic, without coat/liner (Code: XWN)
        /// </summary>
        IntermediateBulkContainer_WovenPlastic_WithoutCoatPerLiner,

        /// <summary>
        /// Intermediate bulk container, woven plastic, coated (Code: XWP)
        /// </summary>
        IntermediateBulkContainer_WovenPlastic_Coated,

        /// <summary>
        /// Intermediate bulk container, woven plastic, with liner (Code: XWQ)
        /// </summary>
        IntermediateBulkContainer_WovenPlastic_WithLiner,

        /// <summary>
        /// Intermediate bulk container, woven plastic, coated and liner (Code: XWR)
        /// </summary>
        IntermediateBulkContainer_WovenPlastic_CoatedAndLiner,

        /// <summary>
        /// Intermediate bulk container, plastic film (Code: XWS)
        /// </summary>
        IntermediateBulkContainer_PlasticFilm,

        /// <summary>
        /// Intermediate bulk container, textile with out coat/liner (Code: XWT)
        /// </summary>
        IntermediateBulkContainer_TextileWithOutCoatPerLiner,

        /// <summary>
        /// Intermediate bulk container, natural wood, with inner liner (Code: XWU)
        /// </summary>
        IntermediateBulkContainer_NaturalWood_WithInnerLiner,

        /// <summary>
        /// Intermediate bulk container, textile, coated (Code: XWV)
        /// </summary>
        IntermediateBulkContainer_Textile_Coated,

        /// <summary>
        /// Intermediate bulk container, textile, with liner (Code: XWW)
        /// </summary>
        IntermediateBulkContainer_Textile_WithLiner,

        /// <summary>
        /// Intermediate bulk container, textile, coated and liner (Code: XWX)
        /// </summary>
        IntermediateBulkContainer_Textile_CoatedAndLiner,

        /// <summary>
        /// Intermediate bulk container, plywood, with inner liner (Code: XWY)
        /// </summary>
        IntermediateBulkContainer_Plywood_WithInnerLiner,

        /// <summary>
        /// Intermediate bulk container, reconstituted wood, with inner liner (Code: XWZ)
        /// </summary>
        IntermediateBulkContainer_ReconstitutedWood_WithInnerLiner,

        /// <summary>
        /// Bag, woven plastic, without inner coat/liner (Code: XXA)
        /// </summary>
        Bag_WovenPlastic_WithoutInnerCoatPerLiner,

        /// <summary>
        /// Bag, woven plastic, sift proof (Code: XXB)
        /// </summary>
        Bag_WovenPlastic_SiftProof,

        /// <summary>
        /// Bag, woven plastic, water resistant (Code: XXC)
        /// </summary>
        Bag_WovenPlastic_WaterResistant,

        /// <summary>
        /// Bag, plastics film (Code: XXD)
        /// </summary>
        Bag_PlasticsFilm,

        /// <summary>
        /// Bag, textile, without inner coat/liner (Code: XXF)
        /// </summary>
        Bag_Textile_WithoutInnerCoatPerLiner,

        /// <summary>
        /// Bag, textile, sift proof (Code: XXG)
        /// </summary>
        Bag_Textile_SiftProof,

        /// <summary>
        /// Bag, textile, water resistant (Code: XXH)
        /// </summary>
        Bag_Textile_WaterResistant,

        /// <summary>
        /// Bag, paper, multi-wall (Code: XXJ)
        /// </summary>
        Bag_Paper_MultiWall,

        /// <summary>
        /// Bag, paper, multi-wall, water resistant (Code: XXK)
        /// </summary>
        Bag_Paper_MultiWall_WaterResistant,

        /// <summary>
        /// Composite packaging, plastic receptacle in steel drum (Code: XYA)
        /// </summary>
        CompositePackaging_PlasticReceptacleInSteelDrum,

        /// <summary>
        /// Composite packaging, plastic receptacle in steel crate box (Code: XYB)
        /// </summary>
        CompositePackaging_PlasticReceptacleInSteelCrateBox,

        /// <summary>
        /// Composite packaging, plastic receptacle in aluminium drum (Code: XYC)
        /// </summary>
        CompositePackaging_PlasticReceptacleInAluminiumDrum,

        /// <summary>
        /// Composite packaging, plastic receptacle in aluminium crate (Code: XYD)
        /// </summary>
        CompositePackaging_PlasticReceptacleInAluminiumCrate,

        /// <summary>
        /// Composite packaging, plastic receptacle in wooden box (Code: XYF)
        /// </summary>
        CompositePackaging_PlasticReceptacleInWoodenBox,

        /// <summary>
        /// Composite packaging, plastic receptacle in plywood drum (Code: XYG)
        /// </summary>
        CompositePackaging_PlasticReceptacleInPlywoodDrum,

        /// <summary>
        /// Composite packaging, plastic receptacle in plywood box (Code: XYH)
        /// </summary>
        CompositePackaging_PlasticReceptacleInPlywoodBox,

        /// <summary>
        /// Composite packaging, plastic receptacle in fibre drum (Code: XYJ)
        /// </summary>
        CompositePackaging_PlasticReceptacleInFibreDrum,

        /// <summary>
        /// Composite packaging, plastic receptacle in fibreboard box (Code: XYK)
        /// </summary>
        CompositePackaging_PlasticReceptacleInFibreboardBox,

        /// <summary>
        /// Composite packaging, plastic receptacle in plastic drum (Code: XYL)
        /// </summary>
        CompositePackaging_PlasticReceptacleInPlasticDrum,

        /// <summary>
        /// Composite packaging, plastic receptacle in solid plastic box (Code: XYM)
        /// </summary>
        CompositePackaging_PlasticReceptacleInSolidPlasticBox,

        /// <summary>
        /// Composite packaging, glass receptacle in steel drum (Code: XYN)
        /// </summary>
        CompositePackaging_GlassReceptacleInSteelDrum,

        /// <summary>
        /// Composite packaging, glass receptacle in steel crate box (Code: XYP)
        /// </summary>
        CompositePackaging_GlassReceptacleInSteelCrateBox,

        /// <summary>
        /// Composite packaging, glass receptacle in aluminium drum (Code: XYQ)
        /// </summary>
        CompositePackaging_GlassReceptacleInAluminiumDrum,

        /// <summary>
        /// Composite packaging, glass receptacle in aluminium crate (Code: XYR)
        /// </summary>
        CompositePackaging_GlassReceptacleInAluminiumCrate,

        /// <summary>
        /// Composite packaging, glass receptacle in wooden box (Code: XYS)
        /// </summary>
        CompositePackaging_GlassReceptacleInWoodenBox,

        /// <summary>
        /// Composite packaging, glass receptacle in plywood drum (Code: XYT)
        /// </summary>
        CompositePackaging_GlassReceptacleInPlywoodDrum,

        /// <summary>
        /// Composite packaging, glass receptacle in wickerwork hamper (Code: XYV)
        /// </summary>
        CompositePackaging_GlassReceptacleInWickerworkHamper,

        /// <summary>
        /// Composite packaging, glass receptacle in fibre drum (Code: XYW)
        /// </summary>
        CompositePackaging_GlassReceptacleInFibreDrum,

        /// <summary>
        /// Composite packaging, glass receptacle in fibreboard box (Code: XYX)
        /// </summary>
        CompositePackaging_GlassReceptacleInFibreboardBox,

        /// <summary>
        /// Composite packaging, glass receptacle in expandable plastic pack (Code: XYY)
        /// </summary>
        CompositePackaging_GlassReceptacleInExpandablePlasticPack,

        /// <summary>
        /// Composite packaging, glass receptacle in solid plastic pack (Code: XYZ)
        /// </summary>
        CompositePackaging_GlassReceptacleInSolidPlasticPack,

        /// <summary>
        /// Intermediate bulk container, paper, multi-wall (Code: XZA)
        /// </summary>
        IntermediateBulkContainer_Paper_MultiWall,

        /// <summary>
        /// Bag, large (Code: XZB)
        /// </summary>
        Bag_Large,

        /// <summary>
        /// Intermediate bulk container, paper, multi-wall, water resistant (Code: XZC)
        /// </summary>
        IntermediateBulkContainer_Paper_MultiWall_WaterResistant,

        /// <summary>
        /// Intermediate bulk container, rigid plastic, with structural equipment, solids (Code: XZD)
        /// </summary>
        IntermediateBulkContainer_RigidPlastic_WithStructuralEquipment_Solids,

        /// <summary>
        /// Intermediate bulk container, rigid plastic, freestanding, solids (Code: XZF)
        /// </summary>
        IntermediateBulkContainer_RigidPlastic_Freestanding_Solids,

        /// <summary>
        /// Intermediate bulk container, rigid plastic, with structural equipment, pressurised (Code: XZG)
        /// </summary>
        IntermediateBulkContainer_RigidPlastic_WithStructuralEquipment_Pressurised,

        /// <summary>
        /// Intermediate bulk container, rigid plastic, freestanding, pressurised (Code: XZH)
        /// </summary>
        IntermediateBulkContainer_RigidPlastic_Freestanding_Pressurised,

        /// <summary>
        /// Intermediate bulk container, rigid plastic, with structural equipment, liquids (Code: XZJ)
        /// </summary>
        IntermediateBulkContainer_RigidPlastic_WithStructuralEquipment_Liquids,

        /// <summary>
        /// Intermediate bulk container, rigid plastic, freestanding, liquids (Code: XZK)
        /// </summary>
        IntermediateBulkContainer_RigidPlastic_Freestanding_Liquids,

        /// <summary>
        /// Intermediate bulk container, composite, rigid plastic, solids (Code: XZL)
        /// </summary>
        IntermediateBulkContainer_Composite_RigidPlastic_Solids,

        /// <summary>
        /// Intermediate bulk container, composite, flexible plastic, solids (Code: XZM)
        /// </summary>
        IntermediateBulkContainer_Composite_FlexiblePlastic_Solids,

        /// <summary>
        /// Intermediate bulk container, composite, rigid plastic, pressurised (Code: XZN)
        /// </summary>
        IntermediateBulkContainer_Composite_RigidPlastic_Pressurised,

        /// <summary>
        /// Intermediate bulk container, composite, flexible plastic, pressurised (Code: XZP)
        /// </summary>
        IntermediateBulkContainer_Composite_FlexiblePlastic_Pressurised,

        /// <summary>
        /// Intermediate bulk container, composite, rigid plastic, liquids (Code: XZQ)
        /// </summary>
        IntermediateBulkContainer_Composite_RigidPlastic_Liquids,

        /// <summary>
        /// Intermediate bulk container, composite, flexible plastic, liquids (Code: XZR)
        /// </summary>
        IntermediateBulkContainer_Composite_FlexiblePlastic_Liquids,

        /// <summary>
        /// Intermediate bulk container, composite (Code: XZS)
        /// </summary>
        IntermediateBulkContainer_Composite,

        /// <summary>
        /// Intermediate bulk container, fibreboard (Code: XZT)
        /// </summary>
        IntermediateBulkContainer_Fibreboard,

        /// <summary>
        /// Intermediate bulk container, flexible (Code: XZU)
        /// </summary>
        IntermediateBulkContainer_Flexible,

        /// <summary>
        /// Intermediate bulk container, metal, other than steel (Code: XZV)
        /// </summary>
        IntermediateBulkContainer_Metal_OtherThanSteel,

        /// <summary>
        /// Intermediate bulk container, natural wood (Code: XZW)
        /// </summary>
        IntermediateBulkContainer_NaturalWood,

        /// <summary>
        /// Intermediate bulk container, plywood (Code: XZX)
        /// </summary>
        IntermediateBulkContainer_Plywood,

        /// <summary>
        /// Intermediate bulk container, reconstituted wood (Code: XZY)
        /// </summary>
        IntermediateBulkContainer_ReconstitutedWood,

        /// <summary>
        /// Mutually defined  (Code: XZZ)
        /// </summary>
        MutuallyDefinedArbitrary,
    }
}