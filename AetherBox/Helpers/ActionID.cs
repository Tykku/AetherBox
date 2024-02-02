namespace AetherBox.Helpers;

/// <summary>
/// The ID the action.
/// </summary>
public enum ActionID : uint
{
    /// <summary>
    /// No Actions.
    /// </summary>
    None = 0,

    #region Normal Actions

    #region Astrologian
    /// <summary>
    /// 
    /// </summary>
    Ascend = 3603,

    /// <summary>
    /// 
    /// </summary>
    Malefic = 3596,

    /// <summary>
    /// 
    /// </summary>
    Combust = 3599,

    /// <summary>
    /// 
    /// </summary>
    Gravity = 3615,

    /// <summary>
    /// 
    /// </summary>
    Benefic = 3594,

    /// <summary>
    /// 
    /// </summary>
    Benefic2 = 3610,

    /// <summary>
    /// 
    /// </summary>
    AspectedBenefic = 3595,

    /// <summary>
    /// 
    /// </summary>
    EssentialDignity = 3614,

    /// <summary>
    /// 
    /// </summary>
    Synastry = 3612,

    /// <summary>
    /// 
    /// </summary>
    CelestialIntersection = 16556,

    /// <summary>
    /// 
    /// </summary>
    Exaltation = 25873,

    /// <summary>
    /// 
    /// </summary>
    Helios = 3600,

    /// <summary>
    /// 
    /// </summary>
    AspectedHelios = 3601,

    /// <summary>
    /// 
    /// </summary>
    CelestialOpposition = 16553,

    /// <summary>
    /// 
    /// </summary>
    EarthlyStar = 7439,

    /// <summary>
    /// 
    /// </summary>
    CollectiveUnconscious = 3613,

    /// <summary>
    /// 
    /// </summary>
    Horoscope = 16557,

    /// <summary>
    /// 
    /// </summary>
    Lightspeed = 3606,

    /// <summary>
    /// 
    /// </summary>
    NeutralSect = 16559,

    /// <summary>
    /// 
    /// </summary>
    Macrocosmos = 25874,

    /// <summary>
    /// 
    /// </summary>
    Microcosmos = 25875,

    /// <summary>
    /// 
    /// </summary>
    Astrodyne = 25870,

    /// <summary>
    /// 
    /// </summary>
    Divination = 16552,

    /// <summary>
    /// 
    /// </summary>
    Draw = 3590,

    /// <summary>
    /// 
    /// </summary>
    Redraw = 3593,

    /// <summary>
    /// 
    /// </summary>
    MinorArcana = 7443,

    /// <summary>
    /// 
    /// </summary>
    CrownPlay = 25869,

    /// <summary>
    /// 
    /// </summary>
    Balance = 4401,

    /// <summary>
    /// 
    /// </summary>
    Arrow = 4402,

    /// <summary>
    /// 
    /// </summary>
    Spear = 4403,

    /// <summary>
    /// 
    /// </summary>
    Bole = 4404,

    /// <summary>
    /// 
    /// </summary>
    Ewer = 4405,

    /// <summary>
    /// 
    /// </summary>
    Spire = 4406,
    #endregion

    #region BlackMage
    /// <summary>
    /// 
    /// </summary>
    Thunder = 144,

    /// <summary>
    /// 
    /// </summary>
    Thunder2 = 7447,

    /// <summary>
    /// 
    /// </summary>
    Thunder3 = 153,

    /// <summary>
    /// 
    /// </summary>
    Thunder4 = 7420,

    /// <summary>
    /// 
    /// </summary>
    Transpose = 149,

    /// <summary>
    /// 
    /// </summary>
    UmbralSoul = 16506,

    /// <summary>
    /// 
    /// </summary>
    Manaward = 157,

    /// <summary>
    /// 
    /// </summary>
    Manafont = 158,

    /// <summary>
    /// 
    /// </summary>
    SharpCast = 3574,

    /// <summary>
    /// 
    /// </summary>
    TripleCast = 7421,

    /// <summary>
    /// 
    /// </summary>
    LeyLines = 3573,

    /// <summary>
    /// 
    /// </summary>
    BetweenTheLines = 7419,

    /// <summary>
    /// 
    /// </summary>
    AetherialManipulation = 155,

    /// <summary>
    /// 
    /// </summary>
    Amplifier = 25796,

    /// <summary>
    /// 
    /// </summary>
    Flare = 162,

    /// <summary>
    /// 
    /// </summary>
    Despair = 16505,

    /// <summary>
    /// 
    /// </summary>
    Foul = 7422,

    /// <summary>
    /// 
    /// </summary>
    Xenoglossy = 16507,

    /// <summary>
    /// 
    /// </summary>
    Scathe = 156,

    /// <summary>
    /// 
    /// </summary>
    Paradox = 25797,

    /// <summary>
    /// 
    /// </summary>
    Fire = 141,

    /// <summary>
    /// 
    /// </summary>
    Fire2 = 147,

    /// <summary>
    /// 
    /// </summary>
    Fire3 = 152,

    /// <summary>
    /// 
    /// </summary>
    Fire4 = 3577,

    /// <summary>
    /// 
    /// </summary>
    Blizzard = 142,

    /// <summary>
    /// 
    /// </summary>
    Blizzard2 = 25793,

    /// <summary>
    /// 
    /// </summary>
    Blizzard3 = 154,

    /// <summary>
    /// 
    /// </summary>
    Blizzard4 = 3576,

    /// <summary>
    /// 
    /// </summary>
    Freeze = 159,
    #endregion

    #region BlueMage
    /// <summary>
    /// 
    /// </summary>
    WaterCannon = 11385,

    /// <summary>
    /// 
    /// </summary>
    FlameThrower = 7418,

    /// <summary>
    /// 
    /// </summary>
    AquaBreath = 11390,

    /// <summary>
    /// 
    /// </summary>
    FlyingFrenzy = 11389,

    /// <summary>
    /// 
    /// </summary>
    DrillCannons = 11398,

    /// <summary>
    /// 
    /// </summary>
    HighVoltage = 11387,

    /// <summary>
    /// 
    /// </summary>
    Loom = 11401,

    /// <summary>
    /// 
    /// </summary>
    FinalSting = 11407,

    /// <summary>
    /// 
    /// </summary>
    SongOfTorment = 11386,

    /// <summary>
    /// 
    /// </summary>
    Glower = 11404,

    /// <summary>
    /// 
    /// </summary>
    PlainCracker = 11391,

    /// <summary>
    /// 
    /// </summary>
    Bristle = 11393,

    /// <summary>
    /// 
    /// </summary>
    WhiteWind = 11406,

    /// <summary>
    /// 
    /// </summary>
    Level5Petrify = 11414,

    /// <summary>
    /// 
    /// </summary>
    SharpenedKnife = 11400,

    /// <summary>
    /// 
    /// </summary>
    IceSpikes = 11418,

    /// <summary>
    /// 
    /// </summary>
    BloodDrain = 11395,

    /// <summary>
    /// 
    /// </summary>
    AcornBomb = 11392,

    /// <summary>
    /// 
    /// </summary>
    BombToss = 11396,

    /// <summary>
    /// 
    /// </summary>
    OffGuard = 11411,

    /// <summary>
    /// 
    /// </summary>
    SelfDestruct = 11408,

    /// <summary>
    /// 
    /// </summary>
    Faze = 11403,

    /// <summary>
    /// 
    /// </summary>
    FlyingSardine = 11423,

    /// <summary>
    /// 
    /// </summary>
    Snort = 11383,

    /// <summary>
    /// 
    /// </summary>
    Weight4Tonze = 11384,

    /// <summary>
    /// 
    /// </summary>
    TheLook = 11399,

    /// <summary>
    /// 
    /// </summary>
    BadBreath = 11388,

    /// <summary>
    /// 
    /// </summary>
    Diamondback = 11424,

    /// <summary>
    /// 
    /// </summary>
    MightyGuard = 11417,

    /// <summary>
    /// 
    /// </summary>
    StickyTongue = 11412,

    /// <summary>
    /// 
    /// </summary>
    ToadOil = 11410,

    /// <summary>
    /// 
    /// </summary>
    TheRamVoice = 11419,

    /// <summary>
    /// 
    /// </summary>
    TheDragonVoice = 11420,

    /// <summary>
    /// 
    /// </summary>
    Missile = 11405,

    /// <summary>
    /// 
    /// </summary>
    Needles1000 = 11397,

    /// <summary>
    /// 
    /// </summary>
    InkJet = 11422,

    /// <summary>
    /// 
    /// </summary>
    FireAngon = 11425,

    /// <summary>
    /// 
    /// </summary>
    MoonFlute = 11415,

    /// <summary>
    /// 
    /// </summary>
    TailScrew = 11413,

    /// <summary>
    /// 
    /// </summary>
    MindBlast = 11394,

    /// <summary>
    /// 
    /// </summary>
    Doom = 11416,

    /// <summary>
    /// 
    /// </summary>
    PeculiarLight = 11421,

    /// <summary>
    /// 
    /// </summary>
    FeatherRain = 11426,

    /// <summary>
    /// 
    /// </summary>
    Eruption = 11427,

    /// <summary>
    /// 
    /// </summary>
    MountainBusterBLU = 11428,

    /// <summary>
    /// 
    /// </summary>
    ShockStrike = 11429,

    /// <summary>
    /// 
    /// </summary>
    GlassDance = 11430,

    /// <summary>
    /// 
    /// </summary>
    VeilOfTheWhorl = 11431,

    /// <summary>
    /// 
    /// </summary>
    AlpineDraft = 18295,

    /// <summary>
    /// 
    /// </summary>
    ProteanWave = 18296,

    /// <summary>
    /// 
    /// </summary>
    Northerlies = 18297,

    /// <summary>
    /// 
    /// </summary>
    Electrogenesis = 18298,

    /// <summary>
    /// 
    /// </summary>
    Kaltstrahl = 18299,

    /// <summary>
    /// 
    /// </summary>
    AbyssalTransfixion = 18300,

    /// <summary>
    /// 
    /// </summary>
    Chirp = 18301,

    /// <summary>
    /// 
    /// </summary>
    EerieSoundwave = 18302,

    /// <summary>
    /// 
    /// </summary>
    PomCure = 18303,

    /// <summary>
    /// 
    /// </summary>
    Gobskin = 18304,

    /// <summary>
    /// 
    /// </summary>
    MagicHammer = 18305,

    /// <summary>
    /// 
    /// </summary>
    Avail = 18306,

    /// <summary>
    /// 
    /// </summary>
    FrogLegs = 18307,

    /// <summary>
    /// 
    /// </summary>
    SonicBoom = 18308,

    /// <summary>
    /// 
    /// </summary>
    Whistle = 18309,

    /// <summary>
    /// 
    /// </summary>
    WhiteKnightsTour = 18310,

    /// <summary>
    /// 
    /// </summary>
    BlackKnightsTour = 18311,

    /// <summary>
    /// 
    /// </summary>
    Level5Death = 18312,

    /// <summary>
    /// 
    /// </summary>
    Launcher = 18313,

    /// <summary>
    /// 
    /// </summary>
    PerpetualRay = 18314,

    /// <summary>
    /// 
    /// </summary>
    CactGuard = 18315,

    /// <summary>
    /// 
    /// </summary>
    RevengeBlast = 18316,

    /// <summary>
    /// 
    /// </summary>
    AngelWhisper = 18317,

    /// <summary>
    /// 
    /// </summary>
    Exuviation = 18318,

    /// <summary>
    /// 
    /// </summary>
    Reflux = 18319,

    /// <summary>
    /// 
    /// </summary>
    Devour = 18320,

    /// <summary>
    /// 
    /// </summary>
    CondensedLibra = 18321,

    /// <summary>
    /// 
    /// </summary>
    AethericMimicry = 18322,

    /// <summary>
    /// 
    /// </summary>
    Surpanakha = 18323,

    /// <summary>
    /// 
    /// </summary>
    Quasar = 18324,

    /// <summary>
    /// 
    /// </summary>
    JKick = 18325,

    /// <summary>
    /// 
    /// </summary>
    TripleTrident = 23264,

    /// <summary>
    /// 
    /// </summary>
    Tingle = 23265,

    /// <summary>
    /// 
    /// </summary>
    Tatamigaeshi = 23266,

    /// <summary>
    /// 
    /// </summary>
    ColdFog = 23267,

    /// <summary>
    /// 
    /// </summary>
    Stotram = 23269,

    /// <summary>
    /// 
    /// </summary>
    SaintlyBeam = 23270,

    /// <summary>
    /// 
    /// </summary>
    FeculentFlood = 23271,

    /// <summary>
    /// 
    /// </summary>
    AngelsSnack = 23272,

    /// <summary>
    /// 
    /// </summary>
    ChelonianGate = 23273,

    /// <summary>
    /// 
    /// </summary>
    TheRoseOfDestruction = 23275,

    /// <summary>
    /// 
    /// </summary>
    BasicInstinct = 23276,

    /// <summary>
    /// 
    /// </summary>
    UltraVibration = 23277,

    /// <summary>
    /// 
    /// </summary>
    Blaze = 23278,

    /// <summary>
    /// 
    /// </summary>
    MustardBomb = 23279,

    /// <summary>
    /// 
    /// </summary>
    DragonForce = 23280,

    /// <summary>
    /// 
    /// </summary>
    AetherialSpark = 23281,

    /// <summary>
    /// 
    /// </summary>
    HydroPull = 23282,

    /// <summary>
    /// 
    /// </summary>
    MaledictionOfWater = 23283,

    /// <summary>
    /// 
    /// </summary>
    ChocoMeteor = 23284,

    /// <summary>
    /// 
    /// </summary>
    MatraMagic = 23285,

    /// <summary>
    /// 
    /// </summary>
    PeripheralSynthesis = 23286,

    /// <summary>
    /// 
    /// </summary>
    BothEnds = 23287,

    /// <summary>
    /// 
    /// </summary>
    PhantomFlurry = 23288,

    /// <summary>
    /// 
    /// </summary>
    NightBloom = 23290,

    /// <summary>
    /// 
    /// </summary>
    WhiteDeath = 23268,

    /// <summary>
    /// 
    /// </summary>
    DivineCataract = 23274,

    /// <summary>
    /// 
    /// </summary>
    PhantomFlurry2 = 23289,

    /// <summary>
    /// 
    /// </summary>
    GoblinPunch = 34563,

    /// <summary>
    /// 
    /// </summary>
    RightRound = 34564,

    /// <summary>
    /// 
    /// </summary>
    Schiltron = 34565,

    /// <summary>
    /// 
    /// </summary>
    Rehydration = 34566,

    /// <summary>
    /// 
    /// </summary>
    BreathOfMagic = 34567,

    /// <summary>
    /// 
    /// </summary>
    WildRage = 34568,

    /// <summary>
    /// 
    /// </summary>
    PeatPelt = 34569,

    /// <summary>
    /// 
    /// </summary>
    DeepClean = 34570,

    /// <summary>
    /// 
    /// </summary>
    RubyDynamics = 34571,

    /// <summary>
    /// 
    /// </summary>
    DivinationRune = 34572,

    /// <summary>
    /// 
    /// </summary>
    DimensionalShift = 34573,

    /// <summary>
    /// 
    /// </summary>
    ConvictionMarcato = 34574,

    /// <summary>
    /// 
    /// </summary>
    ForceField = 34575,

    /// <summary>
    /// 
    /// </summary>
    WingedReprobation = 34576,

    /// <summary>
    /// 
    /// </summary>
    LaserEye = 34577,

    /// <summary>
    /// 
    /// </summary>
    CandyCane = 34578,

    /// <summary>
    /// 
    /// </summary>
    MortalFlame = 34579,

    /// <summary>
    /// 
    /// </summary>
    SeaShanty = 34580,

    /// <summary>
    /// 
    /// </summary>
    Apokalypsis = 34581,

    /// <summary>
    /// 
    /// </summary>
    BeingMortal = 34582,
    #endregion

    #region Bard
    /// <summary>
    /// 
    /// </summary>
    HeavyShoot = 97,

    /// <summary>
    /// 
    /// </summary>
    StraitShoot = 98,

    /// <summary>
    /// 
    /// </summary>
    VenomousBite = 100,

    /// <summary>
    /// 
    /// </summary>
    WindBite = 113,

    /// <summary>
    /// 
    /// </summary>
    IronJaws = 3560,

    /// <summary>
    /// 
    /// </summary>
    MagesBallad = 114,

    /// <summary>
    /// 
    /// </summary>
    ArmysPaeon = 116,

    /// <summary>
    /// 
    /// </summary>
    WanderersMinuet = 3559,

    /// <summary>
    /// 
    /// </summary>
    BattleVoice = 118,

    /// <summary>
    /// 
    /// </summary>
    RagingStrikes = 101,

    /// <summary>
    /// 
    /// </summary>
    RadiantFinale = 25785,

    /// <summary>
    /// 
    /// </summary>
    Barrage = 107,

    /// <summary>
    /// 
    /// </summary>
    EmpyrealArrow = 3558,

    /// <summary>
    /// 
    /// </summary>
    PitchPerfect = 7404,

    /// <summary>
    /// 
    /// </summary>
    Bloodletter = 110,

    /// <summary>
    /// 
    /// </summary>
    RainOfDeath = 117,

    /// <summary>
    /// 
    /// </summary>
    QuickNock = 106,

    /// <summary>
    /// 
    /// </summary>
    ShadowBite = 16494,

    /// <summary>
    /// 
    /// </summary>
    WardensPaean = 3561,

    /// <summary>
    /// 
    /// </summary>
    NaturesMinne = 7408,

    /// <summary>
    /// 
    /// </summary>
    Sidewinder = 3562,

    /// <summary>
    /// 
    /// </summary>
    ApexArrow = 16496,

    /// <summary>
    /// 
    /// </summary>
    BlastArrow = 25784,

    /// <summary>
    /// 
    /// </summary>
    Troubadour = 7405,
    #endregion

    #region Dancer
    /// <summary>
    /// 
    /// </summary>
    Cascade = 15989,

    /// <summary>
    /// 
    /// </summary>
    Fountain = 15990,

    /// <summary>
    /// 
    /// </summary>
    ReverseCascade = 15991,

    /// <summary>
    /// 
    /// </summary>
    FountainFall = 15992,

    /// <summary>
    /// 
    /// </summary>
    FanDance = 16007,

    /// <summary>
    /// 
    /// </summary>
    Windmill = 15993,

    /// <summary>
    /// 
    /// </summary>
    BladeShower = 15994,

    /// <summary>
    /// 
    /// </summary>
    RisingWindmill = 15995,

    /// <summary>
    /// 
    /// </summary>
    BloodShower = 15996,

    /// <summary>
    /// 
    /// </summary>
    FanDance2 = 16008,

    /// <summary>
    /// 
    /// </summary>
    FanDance3 = 16009,

    /// <summary>
    /// 
    /// </summary>
    FanDance4 = 25791,

    /// <summary>
    /// 
    /// </summary>
    SaberDance = 16005,

    /// <summary>
    /// 
    /// </summary>
    StarFallDance = 25792,

    /// <summary>
    /// 
    /// </summary>
    EnAvant = 16010,

    /// <summary>
    /// 
    /// </summary>
    Emboite = 15999,

    /// <summary>
    /// 
    /// </summary>
    Entrechat = 16000,

    /// <summary>
    /// 
    /// </summary>
    Jete = 16001,

    /// <summary>
    /// 
    /// </summary>
    Pirouette = 16002,

    /// <summary>
    /// 
    /// </summary>
    StandardStep = 15997,

    /// <summary>
    /// 
    /// </summary>
    TechnicalStep = 15998,

    /// <summary>
    /// 
    /// </summary>
    StandardFinish = 16003,

    /// <summary>
    /// 
    /// </summary>
    TechnicalFinish = 16004,

    /// <summary>
    /// 
    /// </summary>
    ShieldSamba = 16012,

    /// <summary>
    /// 
    /// </summary>
    CuringWaltz = 16015,

    /// <summary>
    /// 
    /// </summary>
    ClosedPosition = 16006,

    /// <summary>
    /// 
    /// </summary>
    Devilment = 16011,

    /// <summary>
    /// 
    /// </summary>
    Flourish = 16013,

    /// <summary>
    /// 
    /// </summary>
    Improvisation = 16014,

    /// <summary>
    /// 
    /// </summary>
    Improvised = 25789,

    /// <summary>
    /// 
    /// </summary>
    Tillana = 25790,
    #endregion

    #region Dragoon
    /// <summary>
    /// 
    /// </summary>
    TrueThrust = 75,

    /// <summary>
    /// 
    /// </summary>
    VorpalThrust = 78,

    /// <summary>
    /// 
    /// </summary>
    RaidenThrust = 16479,

    /// <summary>
    /// 
    /// </summary>
    FullThrust = 84,

    /// <summary>
    /// 
    /// </summary>
    HeavensThrust = 25771,

    /// <summary>
    /// 
    /// </summary>
    Disembowel = 87,

    /// <summary>
    /// 
    /// </summary>
    ChaosThrust = 88,

    /// <summary>
    /// 
    /// </summary>
    ChaoticSpring = 25772,

    /// <summary>
    /// 
    /// </summary>
    WheelingThrust = 3556,

    /// <summary>
    /// 
    /// </summary>
    FangandClaw = 3554,

    /// <summary>
    /// 
    /// </summary>
    PiercingTalon = 90,

    /// <summary>
    /// 
    /// </summary>
    DoomSpike = 86,

    /// <summary>
    /// 
    /// </summary>
    SonicThrust = 7397,

    /// <summary>
    /// 
    /// </summary>
    DraconianFury = 25770,

    /// <summary>
    /// 
    /// </summary>
    CoerthanTorment = 16477,

    /// <summary>
    /// 
    /// </summary>
    SpineShatterDive = 95,

    /// <summary>
    /// 
    /// </summary>
    DragonFireDive = 96,

    /// <summary>
    /// 
    /// </summary>
    Jump = 92,

    /// <summary>
    /// 
    /// </summary>
    HighJump = 16478,

    /// <summary>
    /// 
    /// </summary>
    MirageDive = 7399,

    /// <summary>
    /// 
    /// </summary>
    Geirskogul = 3555,

    /// <summary>
    /// 
    /// </summary>
    Nastrond = 7400,

    /// <summary>
    /// 
    /// </summary>
    StarDiver = 16480,

    /// <summary>
    /// 
    /// </summary>
    WyrmwindThrust = 25773,

    /// <summary>
    /// 
    /// </summary>
    ElusiveJump = 94,
    #endregion

    #region DRK
    /// <summary>
    /// 
    /// </summary>
    HardSlash = 3617,

    /// <summary>
    /// 
    /// </summary>
    SyphonStrike = 3623,

    /// <summary>
    /// 
    /// </summary>
    Unleash = 3621,

    /// <summary>
    /// 
    /// </summary>
    Grit = 3629,

    /// <summary>
    /// 
    /// </summary>
    Unmend = 3624,

    /// <summary>
    /// 
    /// </summary>
    Souleater = 3632,

    /// <summary>
    /// 
    /// </summary>
    FloodOfDarkness = 16466,

    /// <summary>
    /// 
    /// </summary>
    EdgeOfDarkness = 16467,

    /// <summary>
    /// 
    /// </summary>
    BloodWeapon = 3625,

    /// <summary>
    /// 
    /// </summary>
    ShadowWall = 3636,

    /// <summary>
    /// 
    /// </summary>
    DarkMind = 3634,

    /// <summary>
    /// 
    /// </summary>
    LivingDead = 3638,

    /// <summary>
    /// 
    /// </summary>
    SaltedEarth = 3639,

    /// <summary>
    /// 
    /// </summary>
    Plunge = 3640,

    /// <summary>
    /// 
    /// </summary>
    AbyssalDrain = 3641,

    /// <summary>
    /// 
    /// </summary>
    CarveAndSpit = 3643,

    /// <summary>
    /// 
    /// </summary>
    BloodSpiller = 7392,

    /// <summary>
    /// 
    /// </summary>
    Quietus = 7391,

    /// <summary>
    /// 
    /// </summary>
    Delirium = 7390,

    /// <summary>
    /// 
    /// </summary>
    TheBlackestNight = 7393,

    /// <summary>
    /// 
    /// </summary>
    StalwartSoul = 16468,

    /// <summary>
    /// 
    /// </summary>
    DarkMissionary = 16471,

    /// <summary>
    /// 
    /// </summary>
    LivingShadow = 16472,

    /// <summary>
    /// 
    /// </summary>
    Oblation = 25754,

    /// <summary>
    /// 
    /// </summary>
    LifeSurge = 83,

    /// <summary>
    /// 
    /// </summary>
    LanceCharge = 85,

    /// <summary>
    /// 
    /// </summary>
    DragonSight = 7398,

    /// <summary>
    /// 
    /// </summary>
    BattleLitany = 3557,

    /// <summary>
    /// 
    /// </summary>
    ShadowBringer = 25757,

    /// <summary>
    /// 
    /// </summary>
    SaltandDarkness = 25755,
    #endregion

    #region GNB
    /// <summary>
    /// 
    /// </summary>
    RoyalGuard = 16142,

    /// <summary>
    /// 
    /// </summary>
    KeenEdge = 16137,

    /// <summary>
    /// 
    /// </summary>
    NoMercy = 16138,

    /// <summary>
    /// 
    /// </summary>
    BrutalShell = 16139,

    /// <summary>
    /// 
    /// </summary>
    Camouflage = 16140,

    /// <summary>
    /// 
    /// </summary>
    DemonSlice = 16141,

    /// <summary>
    /// 
    /// </summary>
    LightningShot = 16143,

    /// <summary>
    /// 
    /// </summary>
    DangerZone = 16144,

    /// <summary>
    /// 
    /// </summary>
    SolidBarrel = 16145,

    /// <summary>
    /// 
    /// </summary>
    BurstStrike = 16162,

    /// <summary>
    /// 
    /// </summary>
    Nebula = 16148,

    /// <summary>
    /// 
    /// </summary>
    DemonSlaughter = 16149,

    /// <summary>
    /// 
    /// </summary>
    Aurora = 16151,

    /// <summary>
    /// 
    /// </summary>
    SuperBolide = 16152,

    /// <summary>
    /// 
    /// </summary>
    SonicBreak = 16153,

    /// <summary>
    /// 
    /// </summary>
    RoughDivide = 16154,

    /// <summary>
    /// 
    /// </summary>
    GnashingFang = 16146,

    /// <summary>
    /// 
    /// </summary>
    BowShock = 16159,

    /// <summary>
    /// 
    /// </summary>
    HeartOfLight = 16160,

    /// <summary>
    /// 
    /// </summary>
    HeartOfStone = 16161,

    /// <summary>
    /// 
    /// </summary>
    FatedCircle = 16163,

    /// <summary>
    /// 
    /// </summary>
    BloodFest = 16164,

    /// <summary>
    /// 
    /// </summary>
    DoubleDown = 25760,

    /// <summary>
    /// 
    /// </summary>
    SavageClaw = 16147,

    /// <summary>
    /// 
    /// </summary>
    WickedTalon = 16150,

    /// <summary>
    /// 
    /// </summary>
    Continuation = 16155,

    /// <summary>
    /// 
    /// </summary>
    JugularRip = 16156,

    /// <summary>
    /// 
    /// </summary>
    AbdomenTear = 16157,

    /// <summary>
    /// 
    /// </summary>
    EyeGouge = 16158,

    /// <summary>
    /// 
    /// </summary>
    Hypervelocity = 25759,
    #endregion

    #region MCH
    /// <summary>
    /// 
    /// </summary>
    SplitShot = 2866,

    /// <summary>
    /// 
    /// </summary>
    HeatedSplitShot = 7411,

    /// <summary>
    /// 
    /// </summary>
    SlugShot = 2868,

    /// <summary>
    /// 
    /// </summary>
    HeatedSlugShot = 7412,

    /// <summary>
    /// 
    /// </summary>
    CleanShot = 2873,

    /// <summary>
    /// 
    /// </summary>
    HeatBlast = 7410,

    /// <summary>
    /// 
    /// </summary>
    SpreadShot = 2870,

    /// <summary>
    /// 
    /// </summary>
    AutoCrossbow = 16497,

    /// <summary>
    /// 
    /// </summary>
    HotShot = 2872,

    /// <summary>
    /// 
    /// </summary>
    AirAnchor = 16500,

    /// <summary>
    /// 
    /// </summary>
    Drill = 16498,

    /// <summary>
    /// 
    /// </summary>
    ChainSaw = 25788,

    /// <summary>
    /// 
    /// </summary>
    BioBlaster = 16499,

    /// <summary>
    /// 
    /// </summary>
    Reassemble = 2876,

    /// <summary>
    /// 
    /// </summary>
    Hypercharge = 17209,

    /// <summary>
    /// 
    /// </summary>
    Wildfire = 2878,

    /// <summary>
    /// 
    /// </summary>
    Detonator = 16766,

	/// <summary>
	/// 
	/// </summary>
	RookOverdrive = 7415,

	/// <summary>
	/// 
	/// </summary>
	Flamethrower = 7418,

	/// <summary>
	/// 
	/// </summary>
	QueenOverdrive = 16502,

    /// <summary>
    ///
    /// </summary>
    GaussRound = 2874,

    /// <summary>
    /// 
    /// </summary>
    Ricochet = 2890,

    /// <summary>
    /// 
    /// </summary>
    BarrelStabilizer = 7414,

    /// <summary>
    /// 
    /// </summary>
    RookAutoturret = 2864,

    /// <summary>
    /// 
    /// </summary>
    Tactician = 16889,

    /// <summary>
    /// 
    /// </summary>
    Dismantle = 2887,
    #endregion

    #region MNK
    /// <summary>
    /// 
    /// </summary>
    DragonKick = 74,

    /// <summary>
    /// 
    /// </summary>
    BootShine = 53,

    /// <summary>
    /// 
    /// </summary>
    ArmOfTheDestroyer = 62,

    /// <summary>
    /// 
    /// </summary>
    ShadowOfTheDestroyer = 25767,

    /// <summary>
    /// 
    /// </summary>
    TwinSnakes = 61,

    /// <summary>
    /// 
    /// </summary>
    TrueStrike = 54,

    /// <summary>
    /// 
    /// </summary>
    FourPointFury = 16473,

    /// <summary>
    /// 
    /// </summary>
    Demolish = 66,

    /// <summary>
    /// 
    /// </summary>
    SnapPunch = 56,

    /// <summary>
    /// 
    /// </summary>
    RockBreaker = 70,

    /// <summary>
    /// 
    /// </summary>
    Meditation = 3546,

    /// <summary>
    /// 
    /// </summary>
    SteelPeak = 25761,

    /// <summary>
    /// 
    /// </summary>
    HowlingFist = 25763,

    /// <summary>
    /// 
    /// </summary>
    Brotherhood = 7396,

    /// <summary>
    /// 
    /// </summary>
    RiddleOfFire = 7395,

    /// <summary>
    /// 
    /// </summary>
    Thunderclap = 25762,

    /// <summary>
    /// 
    /// </summary>
    Mantra = 65,

    /// <summary>
    /// 
    /// </summary>
    PerfectBalance = 69,

    /// <summary>
    /// 
    /// </summary>
    ElixirField = 3545,

    /// <summary>
    /// 
    /// </summary>
    FlintStrike = 25882,

    /// <summary>
    /// 
    /// </summary>
    CelestialRevolution = 25765,

    /// <summary>
    /// 
    /// </summary>
    RisingPhoenix = 25768,

    /// <summary>
    /// 
    /// </summary>
    TornadoKick = 3543,

    /// <summary>
    /// 
    /// </summary>
    PhantomRush = 25769,

    /// <summary>
    /// 
    /// </summary>
    FormShift = 4262,

    /// <summary>
    /// 
    /// </summary>
    RiddleOfEarth = 7394,

    /// <summary>
    /// 
    /// </summary>
    RiddleOfWind = 25766,
    #endregion

    #region NIN
    /// <summary>
    /// 
    /// </summary>
    Hide = 2245,

    /// <summary>
    /// 
    /// </summary>
    SpinningEdge = 2240,

    /// <summary>
    /// 
    /// </summary>
    ShadeShift = 2241,

    /// <summary>
    /// 
    /// </summary>
    GustSlash = 2242,

    /// <summary>
    /// 
    /// </summary>
    ThrowingDagger = 2247,

    /// <summary>
    /// 
    /// </summary>
    Mug = 2248,

    /// <summary>
    /// 
    /// </summary>
    TrickAttack = 2258,

    /// <summary>
    /// 
    /// </summary>
    AeolianEdge = 2255,

    /// <summary>
    /// 
    /// </summary>
    DeathBlossom = 2254,

    /// <summary>
    /// 
    /// </summary>
    Ten = 2259,

    /// <summary>
    /// 
    /// </summary>
    Ninjutsu = 2260,

    /// <summary>
    /// 
    /// </summary>
    Chi = 2261,

    /// <summary>
    /// 
    /// </summary>
    Jin = 2263,

    /// <summary>
    /// 
    /// </summary>
    TenChiJin = 7403,

    /// <summary>
    /// 
    /// </summary>
    Shukuchi = 2262,

    /// <summary>
    /// 
    /// </summary>
    Assassinate = 2246,

    /// <summary>
    /// 
    /// </summary>
    Meisui = 16489,

    /// <summary>
    /// 
    /// </summary>
    Kassatsu = 2264,

    /// <summary>
    /// 
    /// </summary>
    HakkeMujinsatsu = 16488,

    /// <summary>
    /// 
    /// </summary>
    ArmorCrush = 3563,

    /// <summary>
    /// 
    /// </summary>
    HellFrogMedium = 7401,

    /// <summary>
    /// 
    /// </summary>
    Bhavacakra = 7402,

    /// <summary>
    /// 
    /// </summary>
    Bunshin = 16493,

    /// <summary>
    /// 
    /// </summary>
    PhantomKamaitachi = 25774,

    /// <summary>
    /// 
    /// </summary>
    FleetingRaiju = 25778,

    /// <summary>
    /// 
    /// </summary>
    ForkedRaiju = 25777,

    /// <summary>
    /// 
    /// </summary>
    Huraijin = 25876,

    /// <summary>
    /// 
    /// </summary>
    DreamWithInADream = 3566,

    /// <summary>
    /// 
    /// </summary>
    FumaShurikenTen = 18873,

    /// <summary>
    /// 
    /// </summary>
    FumaShurikenJin = 18875,

    /// <summary>
    /// 
    /// </summary>
    KatonTen = 18876,

    /// <summary>
    /// 
    /// </summary>
    RaitonChi = 18877,

    /// <summary>
    /// 
    /// </summary>
    DotonChi = 18880,

    /// <summary>
    /// 
    /// </summary>
    SuitonJin = 18881,

    /// <summary>
    /// 
    /// </summary>
    RabbitMedium = 2272,

    /// <summary>
    /// 
    /// </summary>
    FumaShuriken = 2265,

    /// <summary>
    /// 
    /// </summary>
    Katon = 2266,

    /// <summary>
    /// 
    /// </summary>
    Raiton = 2267,

    /// <summary>
    /// 
    /// </summary>
    Hyoton = 2268,

    /// <summary>
    /// 
    /// </summary>
    Huton = 2269,

    /// <summary>
    /// 
    /// </summary>
    Doton = 2270,

    /// <summary>
    /// 
    /// </summary>
    Suiton = 2271,

    /// <summary>
    /// 
    /// </summary>
    GokaMekkyaku = 16491,

    /// <summary>
    /// 
    /// </summary>
    HyoshoRanryu = 16492,
    #endregion

    #region PLD
    /// <summary>
    /// 
    /// </summary>
    IronWill = 28,

    /// <summary>
    /// 
    /// </summary>
    Bulwark = 22,

    /// <summary>
    /// 
    /// </summary>
    FastBlade = 9,

    /// <summary>
    /// 
    /// </summary>
    RiotBlade = 15,

    /// <summary>
    /// 
    /// </summary>
    GoringBlade = 3538,

    /// <summary>
    /// 
    /// </summary>
    RageOfHalone = 21,

    /// <summary>
    /// 
    /// </summary>
    RoyalAuthority = 3539,

    /// <summary>
    /// 
    /// </summary>
    ShieldLob = 24,

    /// <summary>
    /// 
    /// </summary>
    ShieldBash = 16,

    /// <summary>
    /// 
    /// </summary>
    FightOrFlight = 20,

    /// <summary>
    /// 
    /// </summary>
    TotalEclipse = 7381,

    /// <summary>
    /// 
    /// </summary>
    Prominence = 16457,

    /// <summary>
    /// 
    /// </summary>
    Sentinel = 17,

    /// <summary>
    /// 
    /// </summary>
    CircleOfScorn = 23,

    /// <summary>
    /// 
    /// </summary>
    SpiritsWithin = 29,

    /// <summary>
    /// 
    /// </summary>
    HallowedGround = 30,

    /// <summary>
    /// 
    /// </summary>
    DivineVeil = 3540,

    /// <summary>
    /// 
    /// </summary>
    Clemency = 3541,

    /// <summary>
    /// 
    /// </summary>
    Intervention = 7382,

    /// <summary>
    /// 
    /// </summary>
    Intervene = 16461,

    /// <summary>
    /// 
    /// </summary>
    Atonement = 16460,

    /// <summary>
    /// 
    /// </summary>
    Expiacion = 25747,

    /// <summary>
    /// 
    /// </summary>
    BladeOfValor = 25750,

    /// <summary>
    /// 
    /// </summary>
    BladeOfTruth = 25749,

    /// <summary>
    /// 
    /// </summary>
    BladeOfFaith = 25748,

    /// <summary>
    /// 
    /// </summary>
    Requiescat = 7383,

    /// <summary>
    /// 
    /// </summary>
    Confiteor = 16459,

    /// <summary>
    /// 
    /// </summary>
    HolyCircle = 16458,

    /// <summary>
    /// 
    /// </summary>
    HolySpirit = 7384,

    /// <summary>
    /// 
    /// </summary>
    PassageOfArms = 7385,

    /// <summary>
    /// 
    /// </summary>
    Cover = 27,

    /// <summary>
    /// 
    /// </summary>
    Sheltron = 3542,
    #endregion

    #region RDM
    /// <summary>
    /// 
    /// </summary>
    Verraise = 7523,

    /// <summary>
    /// 
    /// </summary>
    Jolt = 7503,

    /// <summary>
    /// 
    /// </summary>
    Riposte = 7504,

    /// <summary>
    /// 
    /// </summary>
    Verthunder = 7505,

    /// <summary>
    /// 
    /// </summary>
    CorpsACorps = 7506,

    /// <summary>
    /// 
    /// </summary>
    Veraero = 7507,

    /// <summary>
    /// 
    /// </summary>
    Scatter = 7509,

    /// <summary>
    /// 
    /// </summary>
    Verthunder2 = 16524,

    /// <summary>
    /// 
    /// </summary>
    Veraero2 = 16525,

    /// <summary>
    /// 
    /// </summary>
    Verfire = 7510,

    /// <summary>
    /// 
    /// </summary>
    Verstone = 7511,

    /// <summary>
    /// 
    /// </summary>
    Zwerchhau = 7512,

    /// <summary>
    /// 
    /// </summary>
    Engagement = 16527,

    /// <summary>
    /// 
    /// </summary>
    Fleche = 7517,

    /// <summary>
    /// 
    /// </summary>
    Redoublement = 7516,

    /// <summary>
    /// 
    /// </summary>
    Acceleration = 7518,

    /// <summary>
    /// 
    /// </summary>
    Moulinet = 7513,

    /// <summary>
    /// 
    /// </summary>
    Vercure = 7514,

    /// <summary>
    /// 
    /// </summary>
    ContreSixte = 7519,

    /// <summary>
    /// 
    /// </summary>
    Embolden = 7520,

    /// <summary>
    /// 
    /// </summary>
    Reprise = 16529,

    /// <summary>
    /// 
    /// </summary>
    MagickBarrier = 25857,

    /// <summary>
    /// 
    /// </summary>
    Verflare = 7525,

    /// <summary>
    /// 
    /// </summary>
    Verholy = 7526,

    /// <summary>
    /// 
    /// </summary>
    Scorch = 16530,

    /// <summary>
    /// 
    /// </summary>
    Resolution = 25858,

    /// <summary>
    /// 
    /// </summary>
    Manafication = 7521,
    #endregion

    #region RPR
    /// <summary>
    /// 
    /// </summary>
    Slice = 24373,

    /// <summary>
    /// 
    /// </summary>
    WaxingSlice = 24374,

    /// <summary>
    /// 
    /// </summary>
    InfernalSlice = 24375,

    /// <summary>
    /// 
    /// </summary>
    ShadowOfDeath = 24378,

    /// <summary>
    /// 
    /// </summary>
    SoulSlice = 24380,

    /// <summary>
    /// 
    /// </summary>
    SpinningScythe = 24376,

    /// <summary>
    /// 
    /// </summary>
    NightmareScythe = 24377,

    /// <summary>
    /// 
    /// </summary>
    WhorlOfDeath = 24379,

    /// <summary>
    /// 
    /// </summary>
    SoulScythe = 24381,

    /// <summary>
    /// 
    /// </summary>
    Gibbet = 24382,

    /// <summary>
    /// 
    /// </summary>
    Gallows = 24383,

    /// <summary>
    /// 
    /// </summary>
    Guillotine = 24384,

    /// <summary>
    /// 
    /// </summary>
    BloodStalk = 24389,

    /// <summary>
    /// 
    /// </summary>
    GrimSwathe = 24392,

    /// <summary>
    /// 
    /// </summary>
    Gluttony = 24393,

    /// <summary>
    /// 
    /// </summary>
    ArcaneCircle = 24405,

    /// <summary>
    /// 
    /// </summary>
    PlentifulHarvest = 24385,

    /// <summary>
    /// 
    /// </summary>
    Enshroud = 24394,

    /// <summary>
    /// 
    /// </summary>
    Communio = 24398,

    /// <summary>
    /// 
    /// </summary>
    LemuresSlice = 24399,

    /// <summary>
    /// 
    /// </summary>
    LemuresScythe = 24400,

    /// <summary>
    /// 
    /// </summary>
    HellsIngress = 24401,

    /// <summary>
    /// 
    /// </summary>
    HellsEgress = 24402,

    /// <summary>
    /// 
    /// </summary>
    VoidReaping = 24395,

    /// <summary>
    /// 
    /// </summary>
    CrossReaping = 24396,

    /// <summary>
    /// 
    /// </summary>
    GrimReaping = 24397,

    /// <summary>
    /// 
    /// </summary>
    Harpe = 24386,

    /// <summary>
    /// 
    /// </summary>
    SoulSow = 24387,

    /// <summary>
    /// 
    /// </summary>
    HarvestMoon = 24388,

    /// <summary>
    /// 
    /// </summary>
    ArcaneCrest = 24404,
    #endregion

    #region SAM
    /// <summary>
    /// 
    /// </summary>
    Hakaze = 7477,

    /// <summary>
    /// 
    /// </summary>
    Jinpu = 7478,

    /// <summary>
    /// 
    /// </summary>
    ThirdEye = 7498,

    /// <summary>
    /// 
    /// </summary>
    Enpi = 7486,

    /// <summary>
    /// 
    /// </summary>
    Shifu = 7479,

    /// <summary>
    /// 
    /// </summary>
    Fuga = 7483,

    /// <summary>
    /// 
    /// </summary>
    Fuko = 25780,

    /// <summary>
    /// 
    /// </summary>
    Gekko = 7481,

    /// <summary>
    /// 
    /// </summary>
    Hagakure = 7495,

    /// <summary>
    /// 
    /// </summary>
    Higanbana = 7489,

    /// <summary>
    /// 
    /// </summary>
    TenkaGoken = 7488,

    /// <summary>
    /// 
    /// </summary>
    MidareSetsugekka = 7487,

    /// <summary>
    /// 
    /// </summary>
    Mangetsu = 7484,

    /// <summary>
    /// 
    /// </summary>
    Kasha = 7482,

    /// <summary>
    /// 
    /// </summary>
    Oka = 7485,

    /// <summary>
    /// 
    /// </summary>
    MeikyoShisui = 7499,

    /// <summary>
    /// 
    /// </summary>
    Yukikaze = 7480,

    /// <summary>
    /// 
    /// </summary>
    HissatsuGyoten = 7492,

    /// <summary>
    /// 
    /// </summary>
    HissatsuYaten = 7493,

    /// <summary>
    /// 
    /// </summary>
    HissatsuShinten = 7490,

    /// <summary>
    /// 
    /// </summary>
    HissatsuKyuten = 7491,

    /// <summary>
    /// 
    /// </summary>
    Ikishoten = 16482,

    /// <summary>
    /// 
    /// </summary>
    HissatsuGuren = 7496,

    /// <summary>
    /// 
    /// </summary>
    HissatsuSenei = 16481,

    /// <summary>
    /// 
    /// </summary>
    TsubameGaeshi = 16483,

    /// <summary>
    /// 
    /// </summary>
    KaeshiGoken = 16485,

    /// <summary>
    /// 
    /// </summary>
    KaeshiSetsugekka = 16486,

    /// <summary>
    /// 
    /// </summary>
    Shoha = 16487,

    /// <summary>
    /// 
    /// </summary>
    Shoha2 = 25779,

    /// <summary>
    /// 
    /// </summary>
    OgiNamikiri = 25781,

    /// <summary>
    /// 
    /// </summary>
    KaeshiNamikiri = 25782,
    #endregion

    #region SCH
    /// <summary>
    /// 
    /// </summary>
    Physick = 190,

    /// <summary>
    /// 
    /// </summary>
    Adloquium = 185,

    /// <summary>
    /// 
    /// </summary>
    Resurrection = 173,

    /// <summary>
    /// 
    /// </summary>
    Succor = 186,

    /// <summary>
    /// 
    /// </summary>
    Lustrate = 189,

    /// <summary>
    /// 
    /// </summary>
    SacredSoil = 188,

    /// <summary>
    /// 
    /// </summary>
    Indomitability = 3583,

    /// <summary>
    /// 
    /// </summary>
    Excogitation = 7434,

    /// <summary>
    /// 
    /// </summary>
    Consolation = 16546,

    /// <summary>
    /// 
    /// </summary>
    Protraction = 25867,

    /// <summary>
    /// 
    /// </summary>
    Bio = 17864,

    /// <summary>
    /// 
    /// </summary>
    Ruin = 17869,

    /// <summary>
    /// 
    /// </summary>
    Ruin2 = 17870,

    /// <summary>
    /// 
    /// </summary>
    EnergyDrain = 167,

    /// <summary>
    /// 
    /// </summary>
    ArtOfWar = 16539,

    /// <summary>
    /// 
    /// </summary>
    SummonSeraph = 16545,

    /// <summary>
    /// 
    /// </summary>
    SummonEos = 17215,

    /// <summary>
    /// 
    /// </summary>
    WhisperingDawn = 16537,

    /// <summary>
    /// 
    /// </summary>
    FeyIllumination = 16538,

    /// <summary>
    /// 
    /// </summary>
    Dissipation = 3587,

    /// <summary>
    /// 
    /// </summary>
    Aetherpact = 7437,

    /// <summary>
    /// 
    /// </summary>
    FeyBlessing = 16543,

    /// <summary>
    /// 
    /// </summary>
    Aetherflow = 166,

    /// <summary>
    /// 
    /// </summary>
    Recitation = 16542,

    /// <summary>
    /// 
    /// </summary>
    ChainStratagem = 7436,

    /// <summary>
    /// 
    /// </summary>
    DeploymentTactics = 3585,

    /// <summary>
    /// 
    /// </summary>
    EmergencyTactics = 3586,

    /// <summary>
    /// 
    /// </summary>
    Expedient = 25868,
    #endregion

    #region SGE
    /// <summary>
    /// 
    /// </summary>
    Egeiro = 24287,

    /// <summary>
    /// 
    /// </summary>
    Dosis = 24283,

    /// <summary>
    /// 
    /// </summary>
    EukrasianDosis = Dosis,

    /// <summary>
    /// 
    /// </summary>
    Phlegma = 24289,

    /// <summary>
    /// 
    /// </summary>
    Phlegma2 = 24307,

    /// <summary>
    /// 
    /// </summary>
    Phlegma3 = 24313,

    /// <summary>
    /// 
    /// </summary>
    Diagnosis = 24284,

    /// <summary>
    /// 
    /// </summary>
    Kardia = 24285,

    /// <summary>
    /// 
    /// </summary>
    Prognosis = 24286,

    /// <summary>
    /// 
    /// </summary>
    Physis = 24288,

    /// <summary>
    /// 
    /// </summary>
    Physis2 = 24302,

    /// <summary>
    /// 
    /// </summary>
    Eukrasia = 24290,

    /// <summary>
    /// 
    /// </summary>
    Soteria = 24294,

    /// <summary>
    /// 
    /// </summary>
    Icarus = 24295,

    /// <summary>
    /// 
    /// </summary>
    Druochole = 24296,

    /// <summary>
    /// 
    /// </summary>
    Dyskrasia = 24297,

    /// <summary>
    /// 
    /// </summary>
    Kerachole = 24298,

    /// <summary>
    /// 
    /// </summary>
    Ixochole = 24299,

    /// <summary>
    /// 
    /// </summary>
    Zoe = 24300,

    /// <summary>
    /// 
    /// </summary>
    Taurochole = 24303,

    /// <summary>
    /// 
    /// </summary>
    Toxikon = 24304,

    /// <summary>
    /// 
    /// </summary>
    Haima = 24305,

    /// <summary>
    /// 
    /// </summary>
    EukrasianDiagnosis = 24291,

    /// <summary>
    /// 
    /// </summary>
    EukrasianPrognosis = 24292,

    /// <summary>
    /// 
    /// </summary>
    Rhizomata = 24309,

    /// <summary>
    /// 
    /// </summary>
    Holos = 24310,

    /// <summary>
    /// 
    /// </summary>
    Panhaima = 24311,

    /// <summary>
    /// 
    /// </summary>
    Krasis = 24317,

    /// <summary>
    /// 
    /// </summary>
    Pneuma = 24318,

    /// <summary>
    /// 
    /// </summary>
    Pepsis = 24301,
    #endregion

    #region SMN
    /// <summary>
    /// 
    /// </summary>
    Gemshine = 25883,

    /// <summary>
    /// 
    /// </summary>
    PreciousBrilliance = 25884,

    /// <summary>
    /// 
    /// </summary>
    RuinSMN = 163,

    /// <summary>
    /// 
    /// </summary>
    Outburst = 16511,

    /// <summary>
    /// 
    /// </summary>
    SummonCarbuncle = 25798,

    /// <summary>
    /// 
    /// </summary>
    SearingLight = 25801,

    /// <summary>
    /// 
    /// </summary>
    RadiantAegis = 25799,

    /// <summary>
    /// 
    /// </summary>
    PhysickSMN = 16230,

    /// <summary>
    /// 
    /// </summary>
    AetherCharge = 25800,

    /// <summary>
    /// 
    /// </summary>
    SummonBahamut = 7427,

    /// <summary>
    /// 
    /// </summary>
    SummonRuby = 25802,

    /// <summary>
    /// 
    /// </summary>
    SummonTopaz = 25803,

    /// <summary>
    /// 
    /// </summary>
    SummonEmerald = 25804,

    /// <summary>
    /// 
    /// </summary>
    ResurrectionSMN = Resurrection,

    /// <summary>
    /// 
    /// </summary>
    EnergyDrainSMN = 16508,

    /// <summary>
    /// 
    /// </summary>
    EnergySiphon = 16510,

    /// <summary>
    /// 
    /// </summary>
    FountainOfFire = 16514,

    /// <summary>
    /// 
    /// </summary>
    Fester = 181,

    /// <summary>
    /// 
    /// </summary>
    PainFlare = 3578,

    /// <summary>
    /// 
    /// </summary>
    RuinIV = 7426,

    /// <summary>
    /// 
    /// </summary>
    AstralImpulse = 25820,

    /// <summary>
    /// 
    /// </summary>
    AstralFlow = 25822,

    /// <summary>
    /// 
    /// </summary>
    EnkindleBahamut = 7429,

    /// <summary>
    /// 
    /// </summary>
    DreadwyrmTrance = 3581,

    /// <summary>
    /// 
    /// </summary>
    DeathFlare = 3582,

    /// <summary>
    /// 
    /// </summary>
    Rekindle = 25830,

    /// <summary>
    /// 
    /// </summary>
    CrimsonCyclone = 25835,

    /// <summary>
    /// 
    /// </summary>
    CrimsonStrike = 25885,

    /// <summary>
    /// 
    /// </summary>
    MountainBuster = 25836,

    /// <summary>
    /// 
    /// </summary>
    Slipstream = 25837,
    #endregion

    #region WAR
    /// <summary>
    /// 
    /// </summary>
    Defiance = 48,

    /// <summary>
    /// 
    /// </summary>
    HeavySwing = 31,

    /// <summary>
    /// 
    /// </summary>
    Maim = 37,

    /// <summary>
    /// 
    /// </summary>
    StormsPath = 42,

    /// <summary>
    /// 
    /// </summary>
    StormsEye = 45,

    /// <summary>
    /// 
    /// </summary>
    Tomahawk = 46,

    /// <summary>
    /// 
    /// </summary>
    Onslaught = 7386,

    /// <summary>
    /// 
    /// </summary>
    Upheaval = 7387,

    /// <summary>
    /// 
    /// </summary>
    Overpower = 41,

    /// <summary>
    /// 
    /// </summary>
    MythrilTempest = 16462,

    /// <summary>
    /// 
    /// </summary>
    Orogeny = 25752,

    /// <summary>
    /// 
    /// </summary>
    InnerBeast = 49,

    /// <summary>
    /// 
    /// </summary>
    InnerRelease = 7389,

    /// <summary>
    /// 
    /// </summary>
    SteelCyclone = 51,

    /// <summary>
    /// 
    /// </summary>
    Infuriate = 52,

    /// <summary>
    /// 
    /// </summary>
    Berserk = 38,

    /// <summary>
    /// 
    /// </summary>
    ThrillOfBattle = 40,

    /// <summary>
    /// 
    /// </summary>
    Equilibrium = 3552,

    /// <summary>
    /// 
    /// </summary>
    NascentFlash = 16464,

    /// <summary>
    /// 
    /// </summary>
    BloodWhetting = 25751,

    /// <summary>
    /// 
    /// </summary>
    Vengeance = 44,

    /// <summary>
    /// 
    /// </summary>
    RawIntuition = 3551,

    /// <summary>
    /// 
    /// </summary>
    ShakeItOff = 7388,

    /// <summary>
    /// 
    /// </summary>
    Holmgang = 43,

    /// <summary>
    /// 
    /// </summary>
    PrimalRend = 25753,
    #endregion

    #region WHM
    /// <summary>
    /// 
    /// </summary>
    Cure = 120,

    /// <summary>
    /// 
    /// </summary>
    Medica = 124,

    /// <summary>
    /// 
    /// </summary>
    Raise1 = 125,

    /// <summary>
    /// 
    /// </summary>
    Cure2 = 135,

    /// <summary>
    /// 
    /// </summary>
    Medica2 = 133,

    /// <summary>
    /// 
    /// </summary>
    Regen = 137,

    /// <summary>
    /// 
    /// </summary>
    Cure3 = 131,

    /// <summary>
    /// 
    /// </summary>
    Benediction = 140,

    /// <summary>
    /// 
    /// </summary>
    Asylum = 3569,

    /// <summary>
    /// 
    /// </summary>
    AfflatusSolace = 16531,

    /// <summary>
    /// 
    /// </summary>
    Tetragrammaton = 3570,

    /// <summary>
    /// 
    /// </summary>
    DivineBenison = 7432,

    /// <summary>
    /// 
    /// </summary>
    AfflatusRapture = 16534,

    /// <summary>
    /// 
    /// </summary>
    Aquaveil = 25861,

    /// <summary>
    /// 
    /// </summary>
    LiturgyOfTheBell = 25862,

    /// <summary>
    /// 
    /// </summary>
    Stone = 119,

    /// <summary>
    /// 
    /// </summary>
    Aero = 121,

    /// <summary>
    /// 
    /// </summary>
    Holy = 139,

    /// <summary>
    /// 
    /// </summary>
    Assize = 3571,

    /// <summary>
    /// 
    /// </summary>
    AfflatusMisery = 16535,

    /// <summary>
    /// 
    /// </summary>
    PresenceOfMind = 136,

    /// <summary>
    /// 
    /// </summary>
    ThinAir = 7430,

    /// <summary>
    /// 
    /// </summary>
    PlenaryIndulgence = 7433,

    /// <summary>
    /// 
    /// </summary>
    Temperance = 16536,
    #endregion

    #region General
    /// <summary>
    /// 
    /// </summary>
    Addle = 7560,

    /// <summary>
    /// 
    /// </summary>
    SwiftCast = 7561,

    /// <summary>
    /// 
    /// </summary>
    Esuna = 7568,

    /// <summary>
    /// 
    /// </summary>
    Rescue = 7571,

    /// <summary>
    /// 
    /// </summary>
    Repose = 16560,

    /// <summary>
    /// 
    /// </summary>
    LucidDreaming = 7562,

    /// <summary>
    /// 
    /// </summary>
    SecondWind = 7541,

    /// <summary>
    /// 
    /// </summary>
    ArmsLength = 7548,

    /// <summary>
    /// 
    /// </summary>
    Rampart = 7531,

    /// <summary>
    /// Only used by the Tank Job Roll
    /// </summary>
    Provoke = 7533,

    /// <summary>
    /// 
    /// </summary>
    Reprisal = 7535,

    /// <summary>
    /// 
    /// </summary>
    Shirk = 7537,

    /// <summary>
    /// 
    /// </summary>
    Bloodbath = 7542,

    /// <summary>
    /// 
    /// </summary>
    Feint = 7549,

    /// <summary>
    /// 
    /// </summary>
    Interject = 7538,

    /// <summary>
    /// 
    /// </summary>
    LowBlow = 7540,

    /// <summary>
    /// 
    /// </summary>
    LegSweep = 7863,

    /// <summary>
    /// 
    /// </summary>
    HeadGraze = 7551,

    /// <summary>
    /// 
    /// </summary>
    SureCast = 7559,

    /// <summary>
    /// 
    /// </summary>
    TrueNorth = 7546,

    /// <summary>
    /// 
    /// </summary>
    Peloton = 7557,

    /// <summary>
    /// 
    /// </summary>
    Sprint = 3,
    #endregion

    #region Variant Actions
    /// <summary>
    /// 
    /// </summary>
    VariantCure = 29729,

    /// <summary>
    /// 
    /// </summary>
    VariantUltimatum = 29730,

    /// <summary>
    /// 
    /// </summary>
    VariantRaise = 29731,

    /// <summary>
    /// 
    /// </summary>
    VariantSpiritDart = 29732,

    /// <summary>
    /// 
    /// </summary>
    VariantRampart = 29733,

    /// <summary>
    /// 
    /// </summary>
    VariantRaise2 = 29734,

    /// <summary>
    /// 
    /// </summary>
    VariantCure2 = 33862,

    /// <summary>
    /// 
    /// </summary>
    VariantSpiritDart2 = 33863,

    /// <summary>
    /// 
    /// </summary>
    VariantRampart2 = 33864,
    #endregion

    #region Bozja Actions

    /// <summary>
    /// 
    /// </summary>
    LostSpellforge = 20706,

    /// <summary>
    /// 
    /// </summary>
    LostSteelsting = 20707,

    /// <summary>
    /// 
    /// </summary>
    LostRampage = 23910,

    /// <summary>
    /// 
    /// </summary>
    LostBurst = 23909,

    /// <summary>
    /// 
    /// </summary>
    LostBravery = 20713,

    /// <summary>
    /// 
    /// </summary>
    LostProtect = 20719,

    /// <summary>
    /// 
    /// </summary>
    LostShell = 20710,

    /// <summary>
    /// 
    /// </summary>
    LostProtect2 = 23915,

    /// <summary>
    /// 
    /// </summary>
    LostShell2 = 23916,

    /// <summary>
    /// 
    /// </summary>
    LostBubble = 23917,

    /// <summary>
    /// 
    /// </summary>
    LostStoneskin = 20712,

    /// <summary>
    /// 
    /// </summary>
    LostStoneskin2 = 23908,

    /// <summary>
    /// 
    /// </summary>
    LostFlarestar = 22352,

    /// <summary>
    /// 
    /// </summary>
    LostSeraphStrike = 22354,
    #endregion

    #region PvP Actions

    /// <summary>
    /// Teleport ability used to move to aetheryte locations.
    /// </summary>
    Teleport = 5,

    /// <summary>
    /// Return ability used to move to the designated home point.
    /// </summary>
    Return = 6,

    /// <summary>
    /// Ability that reduces damage and grants immunity to various status effects.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>Type:</term>
    ///         <description>Ability</description>
    ///     </item>
    ///     <item>
    ///         <term>Cast Time:</term>
    ///         <description>Instant</description>
    ///     </item>
    ///     <item>
    ///         <term>Recast Time:</term>
    ///         <description>30s</description>
    ///     </item>
    ///     <item>
    ///         <term>MP Cost:</term>
    ///         <description>N/A</description>
    ///     </item>
    ///     <item>
    ///         <term>Range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Main Effect:</term>
    ///         <description>Reduces damage taken by 90% and grants immunity to Stun, Heavy, Bind, Silence, Half-asleep, Sleep, Deep Freeze, and knockback and draw-in effects. Duration: 5s.</description>
    ///     </item>
    ///     <item>
    ///         <term>Additional Effect:</term>
    ///         <description>Movement speed is reduced by 50% for the duration of this effect.</description>
    ///     </item>
    ///     <item>
    ///         <term>Special Conditions:</term>
    ///         <description>Effect ends upon reuse, using another action, or when the effect duration expires.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    Guard = 29054,

    /// <summary>
    /// Standard-issue Elixir Ability
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>Type:</term>
    ///         <description>Ability</description>
    ///     </item>
    ///     <item>
    ///         <term>Cast Time:</term>
    ///         <description>4.5s</description>
    ///     </item>
    ///     <item>
    ///         <term>Recast Time:</term>
    ///         <description>5s</description>
    ///     </item>
    ///     <item>
    ///         <term>MP Cost:</term>
    ///         <description>N/A</description>
    ///     </item>
    ///     <item>
    ///         <term>Range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Effect:</term>
    ///         <description>Restores your HP and MP to maximum. Casting will be interrupted when damage is taken.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    StandardElixir = 29055,

    /// <summary>
    /// Ability that removes various status effects and grants Resilience.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>Type:</term>
    ///         <description>Ability</description>
    ///     </item>
    ///     <item>
    ///         <term>Cast Time:</term>
    ///         <description>Instant</description>
    ///     </item>
    ///     <item>
    ///         <term>Recast Time:</term>
    ///         <description>30s</description>
    ///     </item>
    ///     <item>
    ///         <term>MP Cost:</term>
    ///         <description>N/A</description>
    ///     </item>
    ///     <item>
    ///         <term>Range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Effect:</term>
    ///         <description>Removes Stun, Heavy, Bind, Silence, Half-asleep, Sleep, and Deep Freeze. Grants Resilience upon successfully removing one of the aforementioned effects.</description>
    ///     </item>
    ///     <item>
    ///         <term>Resilience Effect:</term>
    ///         <description>Nullifies status afflictions that can be removed by Purify. Duration: 5s.</description>
    ///     </item>
    ///     <item>
    ///         <term>Special Conditions:</term>
    ///         <description>Can be used even when under the effect of certain status afflictions.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    Purify = 29056,

    /// <summary>
    /// Ability that increases movement speed.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>Type:</term>
    ///         <description>Ability</description>
    ///     </item>
    ///     <item>
    ///         <term>Cast Time:</term>
    ///         <description>Instant</description>
    ///     </item>
    ///     <item>
    ///         <term>Recast Time:</term>
    ///         <description>1.5s</description>
    ///     </item>
    ///     <item>
    ///         <term>MP Cost:</term>
    ///         <description>N/A</description>
    ///     </item>
    ///     <item>
    ///         <term>Range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Effect:</term>
    ///         <description>Increases movement speed by 50%.</description>
    ///     </item>
    ///     <item>
    ///         <term>Special Conditions:</term>
    ///         <description>Effect ends upon reuse or execution of another action.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    SprintPvP = 29057,

    /// <summary>
    /// Ability that restores own HP.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>Type:</term>
    ///         <description>Ability</description>
    ///     </item>
    ///     <item>
    ///         <term>Cast Time:</term>
    ///         <description>Instant</description>
    ///     </item>
    ///     <item>
    ///         <term>Recast Time:</term>
    ///         <description>1s</description>
    ///     </item>
    ///     <item>
    ///         <term>MP Cost:</term>
    ///         <description>2500 MP</description>
    ///     </item>
    ///     <item>
    ///         <term>Range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>Effect:</term>
    ///         <description>Restores own HP with a Cure Potency of 15,000.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    Recuperate = 29711,

    /// <summary>
    /// 
    /// </summary>
    LimitBreak = 31399,
    #endregion
    #endregion

    #region PvP Actions
    /// <summary>
    /// ability that reduces damage and grants immunity to various status effects.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>type:</term>
    ///         <description>ability</description>
    ///     </item>
    ///     <item>
    ///         <term>cast time:</term>
    ///         <description>instant</description>
    ///     </item>
    ///     <item>
    ///         <term>recast time:</term>
    ///         <description>30s</description>
    ///     </item>
    ///     <item>
    ///         <term>mp cost:</term>
    ///         <description>n/a</description>
    ///     </item>
    ///     <item>
    ///         <term>range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>reduces damage taken by 90% and grants immunity to stun, heavy, bind, silence, half-asleep, sleep, deep freeze, and knockback and draw-in effects. duration: 5s.</description>
    ///     </item>
    ///     <item>
    ///         <term>additional effect:</term>
    ///         <description>movement speed is reduced by 50% for the duration of this effect.</description>
    ///     </item>
    ///     <item>
    ///         <term>special conditions:</term>
    ///         <description>effect ends upon reuse, using another action, or when the effect duration expires.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    guard = 29054,

    /// <summary>
    /// standard-issue elixir ability
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>type:</term>
    ///         <description>ability</description>
    ///     </item>
    ///     <item>
    ///         <term>cast time:</term>
    ///         <description>4.5s</description>
    ///     </item>
    ///     <item>
    ///         <term>recast time:</term>
    ///         <description>5s</description>
    ///     </item>
    ///     <item>
    ///         <term>mp cost:</term>
    ///         <description>n/a</description>
    ///     </item>
    ///     <item>
    ///         <term>range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>effect:</term>
    ///         <description>restores your hp and mp to maximum. casting will be interrupted when damage is taken.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    standardelixir = 29055,

    /// <summary>
    /// ability that removes various status effects and grants resilience.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>type:</term>
    ///         <description>ability</description>
    ///     </item>
    ///     <item>
    ///         <term>cast time:</term>
    ///         <description>instant</description>
    ///     </item>
    ///     <item>
    ///         <term>recast time:</term>
    ///         <description>30s</description>
    ///     </item>
    ///     <item>
    ///         <term>mp cost:</term>
    ///         <description>n/a</description>
    ///     </item>
    ///     <item>
    ///         <term>range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>effect:</term>
    ///         <description>removes stun, heavy, bind, silence, half-asleep, sleep, and deep freeze. grants resilience upon successfully removing one of the aforementioned effects.</description>
    ///     </item>
    ///     <item>
    ///         <term>resilience effect:</term>
    ///         <description>nullifies status afflictions that can be removed by purify. duration: 5s.</description>
    ///     </item>
    ///     <item>
    ///         <term>special conditions:</term>
    ///         <description>can be used even when under the effect of certain status afflictions.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    purify = 29056,

    /// <summary>
    /// ability that increases movement speed.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>type:</term>
    ///         <description>ability</description>
    ///     </item>
    ///     <item>
    ///         <term>cast time:</term>
    ///         <description>instant</description>
    ///     </item>
    ///     <item>
    ///         <term>recast time:</term>
    ///         <description>1.5s</description>
    ///     </item>
    ///     <item>
    ///         <term>mp cost:</term>
    ///         <description>n/a</description>
    ///     </item>
    ///     <item>
    ///         <term>range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>effect:</term>
    ///         <description>increases movement speed by 50%.</description>
    ///     </item>
    ///     <item>
    ///         <term>special conditions:</term>
    ///         <description>effect ends upon reuse or execution of another action.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    sprint = 29057,

    /// <summary>
    /// ability that restores own hp.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>type:</term>
    ///         <description>ability</description>
    ///     </item>
    ///     <item>
    ///         <term>cast time:</term>
    ///         <description>instant</description>
    ///     </item>
    ///     <item>
    ///         <term>recast time:</term>
    ///         <description>1s</description>
    ///     </item>
    ///     <item>
    ///         <term>mp cost:</term>
    ///         <description>2500 mp</description>
    ///     </item>
    ///     <item>
    ///         <term>range:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>radius:</term>
    ///         <description>0y</description>
    ///     </item>
    ///     <item>
    ///         <term>effect:</term>
    ///         <description>restores own hp with a cure potency of 15,000.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    recuperate = 29711,

    /// <summary>
    /// 
    /// </summary>
    limitbreak = 31399,



    #region blm_pvp
    /// <summary>
    /// 
    /// </summary>
    fire = 29649,
    /// <summary>
    /// 
    /// </summary>
    blizzard = 29653,
    /// <summary>
    /// 
    /// </summary>
    burst = 29657,
    /// <summary>
    /// 
    /// </summary>
    paradox = 29663,
    /// <summary>
    /// 
    /// </summary>
    nightwing = 29659,
    /// <summary>
    /// 
    /// </summary>
    aetherialmanipulation = 29660,
    /// <summary>
    /// 
    /// </summary>
    superflare = 29661,
    /// <summary>
    /// 
    /// </summary>
    fire4 = 29650,
    /// <summary>
    /// 
    /// </summary>
    flare = 29651,
    /// <summary>
    /// 
    /// </summary>
    blizzard4 = 29654,
    /// <summary>
    /// 
    /// </summary>
    freeze = 29655,
    /// <summary>
    /// 
    /// </summary>
    foul = 29371,
    #endregion

    #region brd_pvp
    /// <summary>
    /// 
    /// </summary>
    powerfulshot = 29391,

    /// <summary>
    /// 
    /// </summary>
    apexarrow = 29393,

    /// <summary>
    /// 
    /// </summary>
    silentnocturne = 29395,

    /// <summary>
    /// 
    /// </summary>
    empyrealarrow = 29398,

    /// <summary>
    /// 
    /// </summary>
    repellingshot = 29399,

    /// <summary>
    /// 
    /// </summary>
    wardenspaean = 29400,

    /// <summary>
    /// 
    /// </summary>
    pitchperfect = 29392,

    /// <summary>
    /// 
    /// </summary>
    blastarrow = 29394,
    #endregion

    #region dnc_pvp
    /// <summary>
    /// 
    /// </summary>
    fountaincombo = 54,

    /// <summary>
    /// 
    /// </summary>
    cascade = 29416,

    /// <summary>
    /// 
    /// </summary>
    fountain = 29417,

    /// <summary>
    /// 
    /// </summary>
    reversecascade = 29418,

    /// <summary>
    /// 
    /// </summary>
    fountainfall = 29419,

    /// <summary>
    /// 
    /// </summary>
    saberdance = 29420,

    /// <summary>
    /// 
    /// </summary>
    starfalldance = 29421,

    /// <summary>
    /// 
    /// </summary>
    honingdance = 29422,

    /// <summary>
    /// 
    /// </summary>
    honingovation = 29470,

    /// <summary>
    /// 
    /// </summary>
    fandance = 29428,

    /// <summary>
    /// 
    /// </summary>
    curingwaltz = 29429,

    /// <summary>
    /// 
    /// </summary>
    enavant = 29430,

    /// <summary>
    /// 
    /// </summary>
    closedposition = 29431,

    /// <summary>
    /// 
    /// </summary>
    contradance = 29432,
    #endregion

    #region drg_pvp
    /// <summary>
    /// 
    /// </summary>
    wheelingthrustcombo = 56,

    /// <summary>
    /// 
    /// </summary>
    raidenthrust = 29486,

    /// <summary>
    /// 
    /// </summary>
    fangandclaw = 29487,

    /// <summary>
    /// 
    /// </summary>
    wheelingthrust = 29488,

    /// <summary>
    /// 
    /// </summary>
    chaoticspring = 29490,

    /// <summary>
    /// 
    /// </summary>
    geirskogul = 29491,

    /// <summary>
    /// 
    /// </summary>
    highjump = 29493,

    /// <summary>
    /// 
    /// </summary>
    elusivejump = 29494,

    /// <summary>
    /// 
    /// </summary>
    wyrmwindthrust = 29495,

    /// <summary>
    /// 
    /// </summary>
    horridroar = 29496,

    /// <summary>
    /// 
    /// </summary>
    heavensthrust = 29489,

    /// <summary>
    /// 
    /// </summary>
    nastrond = 29492,

    /// <summary>
    /// 
    /// </summary>
    skyhigh = 29497,
    #endregion

    #region drk_pvp
    /// <summary>
    /// 
    /// </summary>
    souleatercombo = 52,

    /// <summary>
    /// 
    /// </summary>
    hardslash = 29085,

    /// <summary>
    /// 
    /// </summary>
    syphonstrike = 29086,

    /// <summary>
    /// 
    /// </summary>
    souleater = 29087,

    /// <summary>
    /// 
    /// </summary>
    quietus = 29737,

    /// <summary>
    /// 
    /// </summary>
    shadowbringer = 29091,

    /// <summary>
    /// 
    /// </summary>
    plunge = 29092,

    /// <summary>
    /// 
    /// </summary>
    blackestnight = 29093,

    /// <summary>
    /// 
    /// </summary>
    saltedearth = 29094,

    /// <summary>
    /// 
    /// </summary>
    bloodspiller = 29088,

    /// <summary>
    /// 
    /// </summary>
    saltanddarkness = 29095,

    /// <summary>
    /// drk's lb
    /// </summary>
    Eventide = 29097,
    #endregion

    #region gnb_pvp
    /// <summary>
    /// 
    /// </summary>
    keenedge = 29098,

    /// <summary>
    /// 
    /// </summary>
    brutalshell = 29099,

    /// <summary>
    /// 
    /// </summary>
    solidbarrel = 29100,

    /// <summary>
    /// 
    /// </summary>
    gnashingfang = 29102,

    /// <summary>
    /// 
    /// </summary>
    savageclaw = 29103,

    /// <summary>
    /// 
    /// </summary>
    wickedtalon = 29104,

    /// <summary>
    /// 
    /// </summary>
    doubledown = 29105,

    /// <summary>
    /// 
    /// </summary>
    continuation = 29106,

    /// <summary>
    /// 
    /// </summary>
    jugularrip = 29108,

    /// <summary>
    /// 
    /// </summary>
    abdomentear = 29109,

    /// <summary>
    /// 
    /// </summary>
    eyegouge = 29110,

    /// <summary>
    /// 
    /// </summary>
    roughdivide = 29123,

    /// <summary>
    /// 
    /// </summary>
    drawandjunction = 29124,

    /// <summary>
    /// 
    /// </summary>
    junctionedcast = 29125,
    #endregion

    #region mch_pvp
    /// <summary>
    /// delivers a ranged attack.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 4,000.</description>
    ///     </item>
    ///     <item>
    ///         <term>additional effect:</term>
    ///         <description>grants a stack of heat, up to a maximum of 5. duration: 15s.</description>
    ///     </item>
    ///     <item>
    ///         <term>maximum stacks effect:</term>
    ///         <description>grants overheated and increases movement speed by 25%. duration: 5s.</description>
    ///     </item>
    ///     <item>
    ///         <term>casting requirement:</term>
    ///         <description>requires casting time to execute. however, it is possible to walk while casting.</description>
    ///     </item>
    /// </list>
    /// <para>※action changes to heat blast while under the effect of overheated.</para>
    /// </remarks>
    blastcharge = 29402,

    /// <summary>
    /// delivers a ranged attack.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 6,000.</description>
    ///     </item>
    ///     <item>
    ///         <term>special conditions:</term>
    ///         <description>can only be executed while under the effect of overheated. does not share a recast timer with any other actions.</description>
    ///     </item>
    /// </list>
    /// <para>※this action cannot be assigned to a hotbar.</para>
    /// </remarks>
    heatblast = 29403,

    /// <summary>
    /// delivers an attack to all enemies in a cone before you.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 6,000. strikes twice when hitting only a single target.</description>
    ///     </item>
    ///     <item>
    ///         <term>additional effect:</term>
    ///         <description>10-yalm knockback.</description>
    ///     </item>
    ///     <item>
    ///         <term>special condition:</term>
    ///         <description>this weaponskill does not share a recast timer with any other actions.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    scattergun = 29404,

    /// <summary>
    /// delivers a ranged attack.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 10,000. increased to 20,000 while under the effect of analysis.</description>
    ///     </item>
    ///     <item>
    ///         <term>damage properties:</term>
    ///         <description>ignores the effects of guard when dealing damage.</description>
    ///     </item>
    ///     <item>
    ///         <term>additional effect:</term>
    ///         <description>grants bioblaster primed.</description>
    ///     </item>
    ///     <item>
    ///         <term>maximum charges:</term>
    ///         <description>2</description>
    ///     </item>
    ///     <item>
    ///         <term>special conditions:</term>
    ///         <description>can only be executed while under the effect of drill primed. does not share a recast timer with any other actions.</description>
    ///     </item>
    /// </list>
    /// <para>※action changes to bioblaster while under the effect of bioblaster primed.</para>
    /// </remarks>
    drill = 29405,

    /// <summary>
    /// delivers an attack to all enemies in a cone before you.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 4,000.</description>
    ///     </item>
    ///     <item>
    ///         <term>first additional effect:</term>
    ///         <description>doubles potency and afflicts target with heavy +75% while under the effect of analysis. duration: 5s.</description>
    ///     </item>
    ///     <item>
    ///         <term>second additional effect:</term>
    ///         <description>damage over time with a potency of 4,000. duration: 12s. doubled potency does not apply to damage over time effect.</description>
    ///     </item>
    ///     <item>
    ///         <term>third additional effect:</term>
    ///         <description>grants air anchor primed.</description>
    ///     </item>
    ///     <item>
    ///         <term>maximum charges:</term>
    ///         <description>2</description>
    ///     </item>
    ///     <item>
    ///         <term>special conditions:</term>
    ///         <description>can only be executed while under the effect of bioblaster primed. does not share a recast timer with any other actions.</description>
    ///     </item>
    /// </list>
    /// <para>※action changes to air anchor while under the effect of air anchor primed.</para>
    /// <para>※this action cannot be assigned to a hotbar.</para>
    /// </remarks>
    bioblaster = 29406,

    /// <summary>
    /// delivers a ranged attack.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 8,000.</description>
    ///     </item>
    ///     <item>
    ///         <term>first additional effect:</term>
    ///         <description>bind. duration: 3s.</description>
    ///     </item>
    ///     <item>
    ///         <term>second additional effect:</term>
    ///         <description>potency is increased by 50%, and the bind effect becomes stun while under the effect of analysis. duration: 3s.</description>
    ///     </item>
    ///     <item>
    ///         <term>third additional effect:</term>
    ///         <description>grants chain saw primed.</description>
    ///     </item>
    ///     <item>
    ///         <term>maximum charges:</term>
    ///         <description>2</description>
    ///     </item>
    ///     <item>
    ///         <term>special conditions:</term>
    ///         <description>can only be executed while under the effect of air anchor primed. does not share a recast timer with any other actions.</description>
    ///     </item>
    /// </list>
    /// <para>※action changes to chain saw while under the effect of chain saw primed.</para>
    /// <para>※this action cannot be assigned to a hotbar.</para>
    /// </remarks>
    airanchor = 29407,

    /// <summary>
    /// delivers an attack to all enemies in a straight line before you.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 8,000. increased by 50% when target's hp is below 50%.</description>
    ///     </item>
    ///     <item>
    ///         <term>first additional effect:</term>
    ///         <description>potency is increased by 50% while under the effect of analysis.</description>
    ///     </item>
    ///     <item>
    ///         <term>second additional effect:</term>
    ///         <description>grants drill primed.</description>
    ///     </item>
    ///     <item>
    ///         <term>maximum charges:</term>
    ///         <description>2</description>
    ///     </item>
    ///     <item>
    ///         <term>special conditions:</term>
    ///         <description>can only be executed while under the effect of chain saw primed. does not share a recast timer with any other actions.</description>
    ///     </item>
    /// </list>
    /// <para>※action changes to drill while under the effect of drill primed.</para>
    /// <para>※this action cannot be assigned to a hotbar.</para>
    /// </remarks>
    chainsaw = 29408,

    /// <summary>
    /// covers target's body in a slow-burning pitch. deals damage when time expires.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>effect range:</term>
    ///         <description>target and all enemies within 5 yalms.</description>
    ///     </item>
    ///     <item>
    ///         <term>duration:</term>
    ///         <description>7s</description>
    ///     </item>
    ///     <item>
    ///         <term>potency increase:</term>
    ///         <description>increased by 4,000 for each of your own attack actions landed prior to the end of the effect.</description>
    ///     </item>
    ///     <item>
    ///         <term>special trigger:</term>
    ///         <description>landing 3 attack actions will cause the slow-burning pitch to detonate immediately.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    wildfire = 29409,

    /// <summary>
    /// deploys an area of effect battle turret for auto-attacks.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>auto-attacks enemies within range with a potency of 6,000. duration: 10s.</description>
    ///     </item>
    ///     <item>
    ///         <term>first additional effect:</term>
    ///         <description>increases target's damage taken by 10%. duration: 7s.</description>
    ///     </item>
    ///     <item>
    ///         <term>second additional effect:</term>
    ///         <description>creates a barrier that absorbs damage equivalent to a heal of 6,000 potency. duration: 7s.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    bishopturret = 29412,

    /// <summary>
    /// deals unaspected damage to all nearby enemies.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 6,000.</description>
    ///     </item>
    ///     <item>
    ///         <term>first additional effect:</term>
    ///         <description>increases target's damage taken by 10%. duration: 7s.</description>
    ///     </item>
    ///     <item>
    ///         <term>second additional effect:</term>
    ///         <description>creates a barrier that absorbs damage equivalent to a heal of 6,000 potency. duration: 7s.</description>
    ///     </item>
    /// </list>
    /// <para>※this action cannot be assigned to a hotbar.</para>
    /// </remarks>
    aethermortar = 29413,

    /// <summary>
    /// grants additional effects to multiple weaponskills when executed.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>general duration:</term>
    ///         <description>10s</description>
    ///     </item>
    ///     <item>
    ///         <term>drill additional effect:</term>
    ///         <description>potency is increased to 200%.</description>
    ///     </item>
    ///     <item>
    ///         <term>bioblaster additional effect:</term>
    ///         <description>doubles potency and afflicts target with heavy +75%.</description>
    ///     </item>
    ///     <item>
    ///         <term>air anchor additional effect:</term>
    ///         <description>potency is increased by 50% and the bind effect becomes stun.</description>
    ///     </item>
    ///     <item>
    ///         <term>chain saw additional effect:</term>
    ///         <description>potency is increased by 50%.</description>
    ///     </item>
    ///     <item>
    ///         <term>maximum charges:</term>
    ///         <description>2</description>
    ///     </item>
    /// </list>
    /// </remarks>
    analysis = 29414,

    /// <summary>
    /// delivers a high-potency ranged attack.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 36,000.</description>
    ///     </item>
    ///     <item>
    ///         <term>special conditions:</term>
    ///         <description>can only be executed when the limit gauge is full. gauge charge time: 90s.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    marksmanspite = 29415,
    #endregion

    #region mnk_pvp
    /// <summary>
    /// 
    /// </summary>
    phantomrushcombo = 55,

    /// <summary>
    /// 
    /// </summary>
    bootshine = 29472,

    /// <summary>
    /// 
    /// </summary>
    truestrike = 29473,

    /// <summary>
    /// 
    /// </summary>
    snappunch = 29474,

    /// <summary>
    /// 
    /// </summary>
    dragonkick = 29475,

    /// <summary>
    /// 
    /// </summary>
    twinsnakes = 29476,

    /// <summary>
    /// 
    /// </summary>
    demolish = 29477,

    /// <summary>
    /// 
    /// </summary>
    phantomrush = 29478,

    /// <summary>
    /// 
    /// </summary>
    sixsidedstar = 29479,

    /// <summary>
    /// 
    /// </summary>
    enlightenment = 29480,

    /// <summary>
    /// 
    /// </summary>
    risingphoenix = 29481,

    /// <summary>
    /// 
    /// </summary>
    riddleofearth = 29482,

    /// <summary>
    /// 
    /// </summary>
    thunderclap = 29484,

    /// <summary>
    /// 
    /// </summary>
    earthsreply = 29483,

    /// <summary>
    /// 
    /// </summary>
    meteordrive = 29485,
    #endregion

    #region nin_pvp
    /// <summary>
    /// 
    /// </summary>
    spinningedge = 29500,

    /// <summary>
    /// 
    /// </summary>
    gustslash = 29501,

    /// <summary>
    /// 
    /// </summary>
    aeolianedge = 29502,

    /// <summary>
    /// 
    /// </summary>
    fumashuriken = 29505,

    /// <summary>
    /// 
    /// </summary>
    mug = 29509,

    /// <summary>
    /// 
    /// </summary>
    threemudra = 29507,

    /// <summary>
    /// 
    /// </summary>
    bunshin = 29511,

    /// <summary>
    /// 
    /// </summary>
    shukuchi = 29513,

    /// <summary>
    /// 
    /// </summary>
    seitontenchu = 29515,

    /// <summary>
    /// 
    /// </summary>
    forkedraiju = 29510,

    /// <summary>
    /// 
    /// </summary>
    fleetingraiju = 29707,

    /// <summary>
    /// 
    /// </summary>
    hyoshoranryu = 29506,

    /// <summary>
    /// 
    /// </summary>
    gokamekkyaku = 29504,

    /// <summary>
    /// 
    /// </summary>
    meisui = 29508,

    /// <summary>
    /// 
    /// </summary>
    huton = 29512,

    /// <summary>
    /// 
    /// </summary>
    doton = 29514,

    /// <summary>
    /// 
    /// </summary>
    assassinate = 29503,
    #endregion

    #region pld_pvp
    /// <summary>
    /// 
    /// </summary>
    fastblade = 29058,

    /// <summary>
    /// 
    /// </summary>
    riotblade = 29059,

    /// <summary>
    /// 
    /// </summary>
    royalauthority = 29060,

    /// <summary>
    /// 
    /// </summary>
    shieldbash = 29064,

    /// <summary>
    /// 
    /// </summary>
    confiteor = 29070,
    #endregion

    #region rdm_pvp
    /// <summary>
    /// 
    /// </summary>
    verstone = 29683,

    /// <summary>
    /// 
    /// </summary>
    enchantedriposte = 29689,

    /// <summary>
    /// 
    /// </summary>
    resolution = 29695,

    /// <summary>
    /// 
    /// </summary>
    magickbarrier = 29697,

    /// <summary>
    /// 
    /// </summary>
    corpsacorps = 29699,

    /// <summary>
    /// 
    /// </summary>
    displacement = 29700,

    /// <summary>
    /// 
    /// </summary>
    veraero3 = 29684,

    /// <summary>
    /// 
    /// </summary>
    verholy = 29685,

    /// <summary>
    /// 
    /// </summary>
    verfire = 29686,

    /// <summary>
    /// 
    /// </summary>
    verthunder3 = 29687,

    /// <summary>
    /// 
    /// </summary>
    verflare = 29688,

    /// <summary>
    /// 
    /// </summary>
    enchantedzwerchhau = 29690,

    /// <summary>
    /// 
    /// </summary>
    enchantedredoublement = 29691,

    /// <summary>
    /// 
    /// </summary>
    frazzle = 29698,

    /// <summary>
    /// 
    /// </summary>
    whiteshift = 29703,

    /// <summary>
    /// 
    /// </summary>
    blackshift = 29702,

    /// <summary>
    /// 
    /// </summary>
    southerncross = 29704,
    #endregion

    #region rpr_pvp
    /// <summary>
    /// 
    /// </summary>
    slice = 29538,

    /// <summary>
    /// 
    /// </summary>
    waxingslice = 29539,

    /// <summary>
    /// 
    /// </summary>
    infernalslice = 29540,

    /// <summary>
    /// 
    /// </summary>
    harvestmoon = 29545,

    /// <summary>
    /// 
    /// </summary>
    plentifulharvest = 29546,

    /// <summary>
    /// 
    /// </summary>
    grimswathe = 29547,

    /// <summary>
    /// 
    /// </summary>
    lemuresslice = 29548,

    /// <summary>
    /// 
    /// </summary>
    deathwarrant = 29549,

    /// <summary>
    /// 
    /// </summary>
    arcanecrest = 29552,

    /// <summary>
    /// 
    /// </summary>
    hellsingress = 29550,

    /// <summary>
    /// 
    /// </summary>
    regress = 29551,

    /// <summary>
    /// 
    /// </summary>
    communio = 29554,

    /// <summary>
    /// 
    /// </summary>
    soulslice = 29566,
    #endregion

    #region sam_pvp
    /// <summary>
    /// 
    /// </summary>
    kashakcombo = 58,

    /// <summary>
    /// 
    /// </summary>
    yukikaze = 29523,

    /// <summary>
    /// 
    /// </summary>
    gekko = 29524,

    /// <summary>
    /// 
    /// </summary>
    kasha = 29525,

    /// <summary>
    /// 
    /// </summary>
    hyosetsu = 29526,

    /// <summary>
    /// 
    /// </summary>
    mangetsu = 29527,

    /// <summary>
    /// 
    /// </summary>
    oka = 29528,

    /// <summary>
    /// 
    /// </summary>
    oginamikiri = 29530,

    /// <summary>
    /// 
    /// </summary>
    soten = 29532,

    /// <summary>
    /// reduces damage taken by 25%, while increasing damage dealt by 25%. additional effect: afflicts target with kuzushi
    /// kuzushi effect: increases damage you deal target by 25%
    /// also can instantly kill an enemy with lb if enemy hasa the kuzushi effect
    /// </summary>
    chiten = 29533,

    /// <summary>
    /// 
    /// </summary>
    mineuchi = 29535,

    /// <summary>
    /// 
    /// </summary>
    meikyoshisui = 29536,

    /// <summary>
    /// 
    /// </summary>
    midare = 29529,

    /// <summary>
    /// 
    /// </summary>
    kaeshi = 29531,

    /// <summary>
    /// 
    /// </summary>
    zantetsuken = 29537,
    #endregion

    #region sch_pvp
    /// <summary>
    /// deals unaspected damage.
    /// </summary>
    /// <remarks>
    /// <para>potency: 5,000</para>
    /// </remarks>
    broil = 29231,

    /// <summary>
    /// restores target's hp.
    /// </summary>
    /// <remarks>
    /// <para>cure potency: 3,000</para>
    /// <para>additional effect: grants galvanize and catalyze to target</para>
    /// <list type="bullet">
    ///     <item>
    ///         <term>galvanize effect:</term>
    ///         <description>absorbs damage equivalent to a heal of 6,000 potency. duration: 15s.</description>
    ///     </item>
    ///     <item>
    ///         <term>barrier potency</term>
    ///         <description>increased by 50% when you are under the effect of recitation.</description>
    ///     </item>
    ///     <item>
    ///         <term>catalyze effect:</term>
    ///         <description>increases damage dealt by 8%. duration: 15s.</description>
    ///     </item>
    /// </list>
    /// <para>maximum charges: 2</para>
    /// <para>this action does not share a recast timer with any other actions.</para>
    /// </remarks>
    aqloquilum = 29232,

    /// <summary>
    /// afflicts target with biolysis and biolytic.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>biolysis effect:</term>
    ///         <description>damage over time. potency: 3,000. duration: 15s.</description>
    ///     </item>
    ///     <item>
    ///         <term>potency increase:</term>
    ///         <description>increased by 50% when you are under the effect of recitation.</description>
    ///     </item>
    ///     <item>
    ///         <term>biolytic effect:</term>
    ///         <description>reduces target's damage dealt by 8%. duration: 15s.</description>
    ///     </item>
    /// </list>
    /// <para>this action does not share a recast timer with any other actions.</para>
    /// </remarks>
    biolysis = 29233,

    /// <summary>
    /// extends galvanize and catalyze effects cast on self or target to nearby party members. 
    /// when targeting an enemy, extends biolysis and biolytic effects to other nearby enemies.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>duration:</term>
    ///         <description>time remaining on original effect.</description>
    ///     </item>
    ///     <item>
    ///         <term>limitations:</term>
    ///         <description>no effect on targets not under effects applied by you, players riding machina, or non-player combatants.</description>
    ///     </item>
    ///     <item>
    ///         <term>maximum charges:</term>
    ///         <description>2</description>
    ///     </item>
    /// </list>
    /// </remarks>
    deploymenttactics = 29234,

    /// <summary>
    /// deals unaspected damage to all enemies in a cone before you.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>main effect:</term>
    ///         <description>potency of 6,000.</description>
    ///     </item>
    ///     <item>
    ///         <term>additional effect:</term>
    ///         <description>reduces target's hp recovered by healing actions by 25%. duration: 10s.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    mummification = 29235,

    /// <summary>
    /// grants expedience and desperate measures to self and all nearby party members.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>expedience effect:</term>
    ///         <description>increases movement speed by 25%. duration: 10s.</description>
    ///     </item>
    ///     <item>
    ///         <term>desperate measures effect:</term>
    ///         <description>reduces damage taken by 10%. duration: 10s.</description>
    ///     </item>
    ///     <item>
    ///         <term>additional effect:</term>
    ///         <description>grants recitation.</description>
    ///     </item>
    ///     <item>
    ///         <term>recitation effect:</term>
    ///         <description>increases the potency of galvanize, biolysis, and biolytic effects. duration: 15s.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    expedient = 29236,

    /// <summary>
    /// summons seraph to fight at a designated location.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>immediate effect:</term>
    ///         <description>seraph will execute seraph flight immediately after being summoned.</description>
    ///     </item>
    ///     <item>
    ///         <term>automatic cast:</term>
    ///         <description>automatically casts seraphic veil on party members who suffer damage.</description>
    ///     </item>
    ///     <item>
    ///         <term>additional effect:</term>
    ///         <description>grants recitation.</description>
    ///     </item>
    ///     <item>
    ///         <term>recitation effect:</term>
    ///         <description>increases the potency of galvanize, biolysis, and biolytic effects. duration: 15s.</description>
    ///     </item>
    ///     <item>
    ///         <term>limitations:</term>
    ///         <description>can only be executed when the limit gauge is full. gauge charge time: 90s.</description>
    ///     </item>
    /// </list>
    /// <para>※action changes to consolation upon execution.</para>
    /// </remarks>
    summmonseraph = 29237,

    /// <summary>
    /// restores the hp of all nearby party members.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>
    ///         <term>cure potency:</term>
    ///         <description>4,000</description>
    ///     </item>
    ///     <item>
    ///         <term>additional effect:</term>
    ///         <description>erects a magicked barrier which nullifies damage equivalent to a heal of 4,000 potency. duration: 10s.</description>
    ///     </item>
    /// </list>
    /// <para>※this action cannot be assigned to a hotbar.</para>
    /// </remarks>
    consolation = 29238,

    #endregion

    #region sge_pvp
    /// <summary>
    /// 
    /// </summary>
    dosis = 29256,

    /// <summary>
    /// 
    /// </summary>
    phlegma = 29259,

    /// <summary>
    /// 
    /// </summary>
    pneuma = 29260,

    /// <summary>
    /// 
    /// </summary>
    eukrasia = 29258,

    /// <summary>
    /// 
    /// </summary>
    icarus = 29261,

    /// <summary>
    /// 
    /// </summary>
    toxikon = 29262,

    /// <summary>
    /// 
    /// </summary>
    kardia = 29264,

    /// <summary>
    /// 
    /// </summary>
    eukrasiandosis = 29257,

    /// <summary>
    /// 
    /// </summary>
    toxicon2 = 29263,
    #endregion

    #region smn_pvp
    /// <summary>
    /// 
    /// </summary>
    ruin3 = 29664,

    /// <summary>
    /// 
    /// </summary>
    astralimpulse = 29665,

    /// <summary>
    /// 
    /// </summary>
    fountainoffire = 29666,

    /// <summary>
    /// 
    /// </summary>
    crimsoncyclone = 29667,

    /// <summary>
    /// 
    /// </summary>
    crimsonstrike = 29668,

    /// <summary>
    /// 
    /// </summary>
    slipstream = 29669,

    /// <summary>
    /// 
    /// </summary>
    radiantaegis = 29670,

    /// <summary>
    /// 
    /// </summary>
    mountainbuster = 29671,

    /// <summary>
    /// 
    /// </summary>
    fester = 29672,

    /// <summary>
    /// 
    /// </summary>
    enkindlebahamut = 29674,

    /// <summary>
    /// 
    /// </summary>
    megaflare = 29675,          // unused

    /// <summary>
    /// 
    /// </summary>
    wyrmwave = 29676,           // unused

    /// <summary>
    /// 
    /// </summary>
    akhmorn = 29677,            // unused

    /// <summary>
    /// 
    /// </summary>
    enkindlephoenix = 29679,

    /// <summary>
    /// 
    /// </summary>
    scarletflame = 29681,       // unused

    /// <summary>
    /// 
    /// </summary>
    revelation = 29682,         // unused
    #endregion

    #region war_pvp
    /// <summary>
    /// 
    /// </summary>
    heavyswing = 29074,

    /// <summary>
    /// 
    /// </summary>
    maim = 29075,

    /// <summary>
    /// 
    /// </summary>
    stormspath = 29076,

    /// <summary>
    /// 
    /// </summary>
    primalrend = 29084,

    /// <summary>
    /// 
    /// </summary>
    onslaught = 29079,

    /// <summary>
    /// 
    /// </summary>
    orogeny = 29080,

    /// <summary>
    /// 
    /// </summary>
    blota = 29081,

    /// <summary>
    /// 
    /// </summary>
    bloodwhetting = 29082,
    #endregion

    #region whm_pvp
    /// <summary>
    /// 
    /// </summary>
    glare = 29223,

    /// <summary>
    /// 
    /// </summary>
    cure2 = 29224,

    /// <summary>
    /// 
    /// </summary>
    cure3 = 29225,

    /// <summary>
    /// 
    /// </summary>
    afflatusmisery = 29226,

    /// <summary>
    /// 
    /// </summary>
    aquaveil = 29227,

    /// <summary>
    /// 
    /// </summary>
    miracleofnature = 29228,

    /// <summary>
    /// 
    /// </summary>
    seraphstrike = 29229,
    #endregion
    #endregion
}
