﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWhizz.WordleModelTests;
internal static class WordSifterData
{
    public static List<string> fiveLetterWords = new List<string>(){"ABACK",
"ABAFT",
"ABASE",
"ABASH",
"ABATE",
"ABBAS",
"ABBED",
"ABBES",
"ABBEY",
"ABBOT",
"ABEAM",
"ABEYS",
"ABHOR",
"ABIDE",
"ABIES",
"ABLED",
"ABLER",
"ABLES",
"ABODE",
"ABOIL",
"ABORT",
"ABOUT",
"ABOVE",
"ABUSE",
"ABUZZ",
"ABYSS",
"ACHED",
"ACHES",
"ACHOO",
"ACIDS",
"ACIDY",
"ACING",
"ACMES",
"ACORN",
"ACRED",
"ACRES",
"ACRID",
"ACTED",
"ACTIN",
"ACTOR",
"ACUTE",
"ADAGE",
"ADAPT",
"ADDED",
"ADDER",
"ADDLE",
"ADEPT",
"ADIEU",
"ADIOS",
"ADLIB",
"ADMAN",
"ADMEN",
"ADMIN",
"ADMIT",
"ADMIX",
"ADOBE",
"ADOBO",
"ADOPT",
"ADORE",
"ADORN",
"ADULT",
"AEGIS",
"AEONS",
"AERIE",
"AFFIX",
"AFIRE",
"AFOOT",
"AFORE",
"AFOUL",
"AFROS",
"AFTER",
"AGAIN",
"AGAPE",
"AGATE",
"AGAVE",
"AGENT",
"AGGRO",
"AGILE",
"AGING",
"AGISM",
"AGIST",
"AGLOW",
"AGONY",
"AGORA",
"AGREE",
"AHEAD",
"AHOLD",
"AIDED",
"AIDER",
"AIDES",
"AIMED",
"AIMER",
"AIRED",
"AISLE",
"AKITA",
"ALAMO",
"ALARM",
"ALBUM",
"ALERT",
"ALGAE",
"ALIAS",
"ALIBI",
"ALIEN",
"ALIGN",
"ALIKE",
"ALIVE",
"ALLAY",
"ALLEY",
"ALLOT",
"ALLOW",
"ALLOY",
"ALOFT",
"ALOHA",
"ALONE",
"ALONG",
"ALOOF",
"ALOUD",
"ALPHA",
"ALTAR",
"ALTER",
"ALURE",
"AMASS",
"AMAZE",
"AMBER",
"AMBLE",
"AMEND",
"AMENS",
"AMINO",
"AMISS",
"AMITY",
"AMONG",
"AMOUR",
"AMPLE",
"AMPLY",
"AMUSE",
"ANGEL",
"ANGER",
"ANGLE",
"ANGRY",
"ANGST",
"ANIME",
"ANKLE",
"ANNEX",
"ANNOY",
"ANNUL",
"ANODE",
"ANTIC",
"ANVIL",
"AORTA",
"APART",
"APHID",
"APING",
"APNEA",
"APPLE",
"APPLY",
"APRON",
"APTLY",
"ARBOR",
"ARCED",
"ARDOR",
"AREAR",
"AREAS",
"ARENA",
"AREPA",
"ARGUE",
"ARIAS",
"ARISE",
"ARJUN",
"ARMED",
"ARMOR",
"AROMA",
"AROSE",
"ARRAY",
"ARROW",
"ARSON",
"ARTSY",
"ASCOT",
"ASHEN",
"ASHES",
"ASIDE",
"ASKED",
"ASKEW",
"ASPEN",
"ASSAY",
"ASSES",
"ASSET",
"ATLAS",
"ATOLL",
"ATOMS",
"ATONE",
"ATTIC",
"AUDIO",
"AUDIT",
"AUGUR",
"AUNTS",
"AUNTY",
"AUTOS",
"AVAIL",
"AVANT",
"AVAST",
"AVERT",
"AVIAN",
"AVOID",
"AWAIT",
"AWAKE",
"AWARD",
"AWARE",
"AWASH",
"AWAYS",
"AWFUL",
"AWOKE",
"AXELS",
"AXIAL",
"AXIOM",
"AXION",
"AZURE",
"BABES",
"BACKS",
"BACON",
"BADDY",
"BADGE",
"BADLY",
"BAGEL",
"BAGGY",
"BAKED",
"BAKER",
"BAKES",
"BALDS",
"BALER",
"BALES",
"BALKS",
"BALLS",
"BALMS",
"BALMY",
"BALSA",
"BANAL",
"BANCO",
"BANDS",
"BANGS",
"BANJO",
"BANKS",
"BARDS",
"BARED",
"BARER",
"BARES",
"BARFS",
"BARGE",
"BARKS",
"BARNS",
"BARON",
"BARRE",
"BASAL",
"BASED",
"BASES",
"BASIC",
"BASIL",
"BASIN",
"BASIS",
"BASKS",
"BASTE",
"BATCH",
"BATED",
"BATES",
"BATHE",
"BATHS",
"BATIK",
"BATON",
"BATTY",
"BAULK",
"BAWDY",
"BAWLS",
"BAYOU",
"BEACH",
"BEADS",
"BEADY",
"BEAMS",
"BEANS",
"BEARD",
"BEARS",
"BEAST",
"BEATS",
"BEECH",
"BEEFS",
"BEEFY",
"BEEPS",
"BEERS",
"BEETS",
"BEFIT",
"BEFOG",
"BEGAN",
"BEGAR",
"BEGAT",
"BEGET",
"BEGIN",
"BEGOT",
"BEGUN",
"BEIGE",
"BEING",
"BELCH",
"BELIE",
"BELLA",
"BELLE",
"BELLS",
"BELLY",
"BELOW",
"BELTS",
"BENCH",
"BENDS",
"BENNY",
"BERET",
"BERGS",
"BERMS",
"BERRY",
"BERTH",
"BESET",
"BETEL",
"BEVEL",
"BEZEL",
"BIBLE",
"BICEP",
"BIDDY",
"BIDED",
"BIDES",
"BIDET",
"BIGGS",
"BIGOT",
"BIKED",
"BIKER",
"BIKES",
"BILGE",
"BILKS",
"BILLS",
"BILLY",
"BIMBO",
"BINDS",
"BINGE",
"BINGO",
"BIOME",
"BIOTA",
"BIPED",
"BIRCH",
"BIRDS",
"BIRTH",
"BISON",
"BITCH",
"BITER",
"BITES",
"BITSY",
"BITTY",
"BLABS",
"BLACK",
"BLADE",
"BLAME",
"BLANC",
"BLAND",
"BLANK",
"BLARE",
"BLAST",
"BLAZE",
"BLEAK",
"BLEAT",
"BLEED",
"BLEEP",
"BLEND",
"BLESS",
"BLIMP",
"BLIND",
"BLING",
"BLINK",
"BLISS",
"BLITZ",
"BLOAT",
"BLOCK",
"BLOGS",
"BLOKE",
"BLOND",
"BLOOD",
"BLOOM",
"BLOWN",
"BLOWS",
"BLUER",
"BLUES",
"BLUFF",
"BLUNT",
"BLURB",
"BLURT",
"BLUSH",
"BOARD",
"BOARS",
"BOAST",
"BOATS",
"BOBBY",
"BOGEY",
"BOGUS",
"BOILS",
"BOING",
"BOLTS",
"BOLUS",
"BOMBS",
"BONDS",
"BONED",
"BONER",
"BONES",
"BONEY",
"BONGO",
"BONGS",
"BONUS",
"BOOBS",
"BOOBY",
"BOOED",
"BOOKS",
"BOOMS",
"BOONS",
"BOOST",
"BOOTH",
"BOOTS",
"BOOTY",
"BOOZE",
"BOOZY",
"BORAX",
"BORED",
"BORER",
"BORNE",
"BORON",
"BOSOM",
"BOSON",
"BOSSY",
"BOTCH",
"BOUGH",
"BOULE",
"BOUND",
"BOUTS",
"BOWED",
"BOWEL",
"BOWER",
"BOWIE",
"BOWLS",
"BOXED",
"BOXER",
"BOXES",
"BRACE",
"BRADS",
"BRAID",
"BRAIN",
"BRAKE",
"BRAND",
"BRASH",
"BRASS",
"BRAVE",
"BRAVO",
"BRAWL",
"BRAWN",
"BREAD",
"BREAK",
"BREED",
"BRETT",
"BRIAR",
"BRIBE",
"BRICK",
"BRIDE",
"BRIEF",
"BRILL",
"BRIMS",
"BRINE",
"BRING",
"BRINK",
"BRINY",
"BRISK",
"BRITS",
"BRITT",
"BROAD",
"BROCK",
"BROIL",
"BROKE",
"BROOD",
"BROOK",
"BROOM",
"BROTH",
"BROWN",
"BROWS",
"BRUNT",
"BRUSH",
"BRUSK",
"BRUTE",
"BUBBA",
"BUCKS",
"BUCKY",
"BUDDY",
"BUDGE",
"BUFFS",
"BUFFY",
"BUGGY",
"BUGLE",
"BUILD",
"BUILT",
"BULBS",
"BULGE",
"BULGY",
"BULKY",
"BULLS",
"BULLY",
"BUMPS",
"BUMPY",
"BUNCH",
"BUNDT",
"BUNDY",
"BUNNY",
"BURKE",
"BURLS",
"BURLY",
"BURNS",
"BURNT",
"BURST",
"BUSED",
"BUSES",
"BUSHY",
"BUSTS",
"BUSTY",
"BUTCH",
"BUTES",
"BUTTE",
"BUTTS",
"BUXOM",
"BUYER",
"BYLAW",
"BYTES",
"BYWAY",
"CABAL",
"CABBY",
"CABIN",
"CABLE",
"CACAO",
"CACHE",
"CACTI",
"CADDY",
"CADET",
"CADRE",
"CAFES",
"CAGED",
"CAGES",
"CAGEY",
"CAIRN",
"CAKED",
"CAKES",
"CALIF",
"CALLS",
"CALMS",
"CAMEL",
"CAMEO",
"CAMOS",
"CAMPS",
"CANAL",
"CANDY",
"CANED",
"CANES",
"CANNY",
"CANOE",
"CANON",
"CAPED",
"CAPER",
"CARAT",
"CARBO",
"CARBS",
"CARDS",
"CARED",
"CARER",
"CARES",
"CARET",
"CARGO",
"CAROL",
"CARPS",
"CARRY",
"CARTE",
"CARTS",
"CARVE",
"CASES",
"CASKS",
"CASTE",
"CASTS",
"CATCH",
"CATER",
"CATTY",
"CAUKS",
"CAULK",
"CAUSE",
"CAVED",
"CAVES",
"CAVIL",
"CAWED",
"CEASE",
"CEDAR",
"CEDED",
"CELLO",
"CELLS",
"CENTS",
"CHAFE",
"CHAFF",
"CHAIN",
"CHAIR",
"CHALK",
"CHAMP",
"CHANT",
"CHAOS",
"CHAPS",
"CHARD",
"CHARM",
"CHARS",
"CHART",
"CHASE",
"CHASM",
"CHATS",
"CHEAP",
"CHEAT",
"CHECK",
"CHEEK",
"CHEER",
"CHEFS",
"CHEMO",
"CHENG",
"CHESS",
"CHEST",
"CHEVY",
"CHEWS",
"CHICK",
"CHIDE",
"CHIEF",
"CHILD",
"CHILE",
"CHILI",
"CHILL",
"CHIME",
"CHIMP",
"CHINA",
"CHINO",
"CHINS",
"CHIPS",
"CHIRP",
"CHIVE",
"CHOCK",
"CHOIR",
"CHOKE",
"CHOPS",
"CHORD",
"CHORE",
"CHOSE",
"CHUCK",
"CHUMP",
"CHUNK",
"CHURN",
"CHUTE",
"CIDER",
"CIGAR",
"CINCH",
"CIRCA",
"CISCO",
"CITED",
"CITES",
"CIVIC",
"CIVIL",
"CLACK",
"CLADS",
"CLAIM",
"CLAMP",
"CLAMS",
"CLANG",
"CLANK",
"CLANS",
"CLAPS",
"CLAPT",
"CLASH",
"CLASP",
"CLASS",
"CLAWS",
"CLAYS",
"CLEAN",
"CLEAR",
"CLEAT",
"CLEFT",
"CLEGG",
"CLERK",
"CLICK",
"CLIFF",
"CLIMB",
"CLING",
"CLINK",
"CLINT",
"CLIPS",
"CLOAK",
"CLOCK",
"CLOGS",
"CLONE",
"CLOPS",
"CLOSE",
"CLOTH",
"CLOTS",
"CLOUD",
"CLOUT",
"CLOVE",
"CLOWN",
"CLUBS",
"CLUCK",
"CLUED",
"CLUES",
"CLUMP",
"CLUNG",
"CLUNK",
"COACH",
"COAST",
"COATS",
"COBRA",
"COCKS",
"COCKY",
"COCOA",
"CODED",
"CODES",
"CODEX",
"COILS",
"COINS",
"COLES",
"COLIN",
"COLON",
"COLOR",
"COLTS",
"COMBO",
"COMBS",
"COMES",
"COMET",
"COMFY",
"COMIC",
"COMMA",
"CONCH",
"CONDO",
"CONES",
"CONEY",
"CONIC",
"CONTE",
"COOED",
"COOKS",
"COOLS",
"COPAY",
"COPED",
"COPSE",
"CORAL",
"CORDS",
"CORED",
"CORER",
"CORES",
"CORGI",
"CORNS",
"CORNY",
"CORPS",
"COSMO",
"COSTA",
"COSTS",
"COUCH",
"COUGH",
"COULD",
"COUNT",
"COUPE",
"COURT",
"COVEN",
"COVER",
"COVES",
"COVET",
"COVEY",
"COVID",
"COWAN",
"COWED",
"COWER",
"COYLY",
"CRABS",
"CRACK",
"CRAFT",
"CRAIG",
"CRAMP",
"CRAMS",
"CRANE",
"CRANK",
"CRAPS",
"CRASH",
"CRASS",
"CRATE",
"CRAVE",
"CRAWL",
"CRAZE",
"CRAZY",
"CREAK",
"CREAM",
"CREDO",
"CREDS",
"CREED",
"CREEK",
"CREEP",
"CREME",
"CREPE",
"CREPT",
"CRESS",
"CREST",
"CREWS",
"CRICK",
"CRIED",
"CRIER",
"CRIES",
"CRIME",
"CRIMP",
"CRISP",
"CROAK",
"CROCK",
"CROFT",
"CRONE",
"CRONY",
"CROOK",
"CROPS",
"CRORE",
"CROSS",
"CROUP",
"CROWD",
"CROWN",
"CROWS",
"CRUDE",
"CRUEL",
"CRUET",
"CRUMB",
"CRUMP",
"CRUSH",
"CRUST",
"CRYER",
"CRYPT",
"CUBBY",
"CUBES",
"CUBIC",
"CUFFS",
"CULTS",
"CUMIN",
"CUPID",
"CURDS",
"CURED",
"CURES",
"CURIO",
"CURLS",
"CURLY",
"CURRY",
"CURSE",
"CURVE",
"CURVY",
"CUTIE",
"CYBER",
"CYCLE",
"CYNIC",
"DADDY",
"DAFFY",
"DAILY",
"DAIRY",
"DAISY",
"DALES",
"DALLY",
"DAMES",
"DAMNS",
"DANCE",
"DANDY",
"DARBY",
"DARCY",
"DARED",
"DARES",
"DARTS",
"DATED",
"DATER",
"DATES",
"DATUM",
"DAUBS",
"DAUNT",
"DAWNS",
"DAZED",
"DAZES",
"DEALS",
"DEALT",
"DEANS",
"DEARS",
"DEATH",
"DEBAR",
"DEBIT",
"DEBTS",
"DEBUG",
"DEBUR",
"DEBUT",
"DECAF",
"DECAL",
"DECAY",
"DECKS",
"DECOR",
"DECOY",
"DECRY",
"DEEDS",
"DEEMS",
"DEEPS",
"DEFER",
"DEIFY",
"DEIGN",
"DEITY",
"DELAY",
"DELTA",
"DELVE",
"DEMON",
"DEMOS",
"DEMUR",
"DENIM",
"DENSE",
"DEPOT",
"DEPTH",
"DERBY",
"DESKS",
"DETER",
"DETOX",
"DEUCE",
"DEVIL",
"DEVON",
"DIALS",
"DIARY",
"DICED",
"DICEY",
"DICKS",
"DIETS",
"DIGIT",
"DILDO",
"DILLY",
"DIMLY",
"DINER",
"DINGO",
"DINGS",
"DINGY",
"DIODE",
"DIRGE",
"DIRTY",
"DISCO",
"DISCS",
"DISKS",
"DITCH",
"DITTO",
"DITTY",
"DIVAS",
"DIVER",
"DIZZY",
"DOCKS",
"DODGE",
"DODGY",
"DOGGY",
"DOGMA",
"DOING",
"DOLCE",
"DOLLS",
"DOLLY",
"DOLOR",
"DONNA",
"DONOR",
"DONUT",
"DOORS",
"DOPEY",
"DORMS",
"DOSES",
"DOUBT",
"DOUGH",
"DOVES",
"DOWDY",
"DOWEL",
"DOWNS",
"DOWNY",
"DOWRY",
"DOZED",
"DOZEN",
"DOZER",
"DRAFT",
"DRAGS",
"DRAIN",
"DRAKE",
"DRAMA",
"DRAMS",
"DRANK",
"DRAPE",
"DRAWL",
"DRAWN",
"DRAWS",
"DREAD",
"DREAM",
"DREAR",
"DREGS",
"DRESS",
"DRIED",
"DRIER",
"DRIES",
"DRIFT",
"DRILL",
"DRINK",
"DRIPS",
"DRIVE",
"DROID",
"DROIT",
"DROLL",
"DRONE",
"DROOL",
"DROOP",
"DROPS",
"DROSS",
"DROVE",
"DROWN",
"DRUGS",
"DRUID",
"DRUMS",
"DRUNK",
"DRYER",
"DRYLY",
"DUCHY",
"DUCKS",
"DUCTS",
"DUDES",
"DUELS",
"DUETS",
"DUKES",
"DULLY",
"DUMMY",
"DUMPS",
"DUMPY",
"DUNCE",
"DUNES",
"DUNNO",
"DUPED",
"DUSKY",
"DUSTY",
"DUTCH",
"DUVET",
"DWARF",
"DWELL",
"DWELT",
"DYING",
"EAGER",
"EAGLE",
"EARLS",
"EARLY",
"EARNS",
"EARTH",
"EASED",
"EASEL",
"EASES",
"EATEN",
"EATER",
"EAVES",
"EBONY",
"ECLAT",
"EDGED",
"EDGES",
"EDICT",
"EDIFY",
"EDITS",
"EERIE",
"EGRET",
"EIGHT",
"EJECT",
"EKING",
"ELATE",
"ELBOW",
"ELDER",
"ELECT",
"ELEGY",
"ELFIN",
"ELIDE",
"ELITE",
"ELOPE",
"ELUDE",
"ELVEN",
"ELVES",
"EMAIL",
"EMBED",
"EMBER",
"EMCEE",
"EMERY",
"EMITS",
"EMOJI",
"EMPTY",
"ENACT",
"ENDED",
"ENDOW",
"ENEMA",
"ENEMY",
"ENJOY",
"ENNUI",
"ENSUE",
"ENTER",
"ENTRY",
"ENVOY",
"EPOCH",
"EPOXY",
"EQUAL",
"EQUIP",
"ERASE",
"ERECT",
"ERICA",
"ERODE",
"ERROR",
"ERUPT",
"ESSAY",
"ESTER",
"ETHEL",
"ETHER",
"ETHIC",
"ETHOS",
"ETUDE",
"EUROS",
"EVADE",
"EVENT",
"EVERY",
"EVICT",
"EVILS",
"EVOKE",
"EXACT",
"EXALT",
"EXAMS",
"EXCEL",
"EXECS",
"EXERT",
"EXILE",
"EXIST",
"EXITS",
"EXPAT",
"EXPEL",
"EXTOL",
"EXTRA",
"EXULT",
"EYING",
"FABLE",
"FACED",
"FACES",
"FACET",
"FACTO",
"FACTS",
"FADED",
"FADER",
"FADES",
"FAILS",
"FAINT",
"FAIRS",
"FAIRY",
"FAITH",
"FAKED",
"FAKER",
"FAKES",
"FAKIR",
"FALLS",
"FALSE",
"FAMED",
"FANCY",
"FANGS",
"FANNY",
"FARCE",
"FARCI",
"FARED",
"FARES",
"FARMS",
"FARSE",
"FARTS",
"FASTS",
"FATAL",
"FATED",
"FATES",
"FATTY",
"FAULT",
"FAUNA",
"FAUNS",
"FAVES",
"FAVOR",
"FAWNS",
"FAXED",
"FAXES",
"FAZED",
"FAZES",
"FEARS",
"FEAST",
"FEATS",
"FECAL",
"FECES",
"FEEDS",
"FEELS",
"FEIGN",
"FELLA",
"FELON",
"FEMME",
"FEMUR",
"FENCE",
"FENDS",
"FERAL",
"FERNS",
"FERRY",
"FETAL",
"FETCH",
"FETID",
"FETUS",
"FEUDS",
"FEVER",
"FEWER",
"FIBER",
"FIBRE",
"FICUS",
"FIELD",
"FIEND",
"FIERY",
"FIFED",
"FIFER",
"FIFES",
"FIFTH",
"FIFTY",
"FIGHT",
"FILCH",
"FILED",
"FILER",
"FILES",
"FILET",
"FILLO",
"FILLS",
"FILLY",
"FILMS",
"FILMY",
"FILTH",
"FINAL",
"FINCH",
"FINDS",
"FINED",
"FINER",
"FINES",
"FINKS",
"FIORD",
"FIRED",
"FIRES",
"FIRMS",
"FIRST",
"FIRTH",
"FISHY",
"FISTS",
"FITCH",
"FIVES",
"FIXED",
"FIXER",
"FIXES",
"FIZZY",
"FJORD",
"FLABS",
"FLACK",
"FLAGS",
"FLAIL",
"FLAIR",
"FLAKE",
"FLAKY",
"FLAME",
"FLANK",
"FLANS",
"FLAPS",
"FLARE",
"FLASH",
"FLASK",
"FLATS",
"FLAWS",
"FLEAS",
"FLECK",
"FLEET",
"FLESH",
"FLICK",
"FLIER",
"FLIES",
"FLING",
"FLINT",
"FLIPS",
"FLIRT",
"FLOAT",
"FLOCK",
"FLOOD",
"FLOOR",
"FLOPS",
"FLORA",
"FLOSS",
"FLOUR",
"FLOUT",
"FLOWN",
"FLOWS",
"FLUBS",
"FLUES",
"FLUFF",
"FLUID",
"FLUKE",
"FLUME",
"FLUNG",
"FLUNK",
"FLUSH",
"FLUTE",
"FLYER",
"FOALS",
"FOAMS",
"FOAMY",
"FOCAL",
"FOCUS",
"FOGGY",
"FOILS",
"FOIST",
"FOLDS",
"FOLIO",
"FOLKS",
"FOLLY",
"FONTS",
"FOODS",
"FOOLS",
"FOOTY",
"FORAY",
"FORCE",
"FORGE",
"FORGO",
"FORKS",
"FORMS",
"FORTE",
"FORTH",
"FORTS",
"FORTY",
"FORUM",
"FOULS",
"FOUND",
"FOURS",
"FOXED",
"FOXES",
"FOYER",
"FRAIL",
"FRAME",
"FRANC",
"FRANK",
"FRATS",
"FRAUD",
"FRAYS",
"FREAK",
"FREED",
"FREER",
"FREES",
"FRESH",
"FRIAR",
"FRIED",
"FRIER",
"FRIES",
"FRILL",
"FRISK",
"FRITZ",
"FROCK",
"FROGS",
"FROND",
"FRONT",
"FROST",
"FROTH",
"FROWN",
"FROZE",
"FRUIT",
"FUDGE",
"FUDGY",
"FUELS",
"FUGUE",
"FULLY",
"FUMES",
"FUNDS",
"FUNGI",
"FUNKY",
"FUNNY",
"FUROR",
"FURRY",
"FUSED",
"FUSES",
"FUSSY",
"FUZZY",
"GABBY",
"GABLE",
"GAFFE",
"GAILY",
"GAINS",
"GAMER",
"GAMES",
"GAMEY",
"GAMMA",
"GAMUT",
"GANGS",
"GAPED",
"GAPES",
"GARTH",
"GASES",
"GASPS",
"GASSY",
"GATED",
"GATES",
"GATOR",
"GAUDY",
"GAUGE",
"GAUNT",
"GAUZE",
"GAVEL",
"GAWKS",
"GAWKY",
"GAYER",
"GAYLY",
"GAZED",
"GAZER",
"GAZES",
"GEARS",
"GECKO",
"GEEKS",
"GEEKY",
"GEESE",
"GELDS",
"GEMMA",
"GENES",
"GENIE",
"GENOA",
"GENRE",
"GENTS",
"GENUS",
"GEODE",
"GERMS",
"GHOST",
"GHOUL",
"GIANT",
"GIDDY",
"GIFTS",
"GILDS",
"GILLS",
"GIMME",
"GIRLS",
"GIRLY",
"GIRTH",
"GIVEN",
"GIVER",
"GIVES",
"GIZMO",
"GLADE",
"GLAND",
"GLARE",
"GLASS",
"GLAZE",
"GLEAM",
"GLEAN",
"GLIDE",
"GLINT",
"GLOAT",
"GLOBE",
"GLOCK",
"GLOOM",
"GLORY",
"GLOSS",
"GLOVE",
"GLUED",
"GLUER",
"GLUES",
"GLYPH",
"GNASH",
"GNATS",
"GNAWS",
"GNOME",
"GOADS",
"GOALS",
"GOATS",
"GODLY",
"GOERS",
"GOING",
"GOLDS",
"GOLEM",
"GOLFS",
"GOLLY",
"GONAD",
"GONER",
"GONGS",
"GONNA",
"GONZO",
"GOODS",
"GOODY",
"GOOEY",
"GOOFS",
"GOOFY",
"GOONS",
"GOOSE",
"GORGE",
"GOTTA",
"GOUGE",
"GOURD",
"GOWNS",
"GRABS",
"GRACE",
"GRADE",
"GRAFT",
"GRAIL",
"GRAIN",
"GRAMS",
"GRAND",
"GRANT",
"GRAPE",
"GRAPH",
"GRASP",
"GRASS",
"GRATE",
"GRAVE",
"GRAVY",
"GRAZE",
"GREAT",
"GREED",
"GREEK",
"GREEN",
"GREET",
"GRIDS",
"GRIEF",
"GRIFT",
"GRILL",
"GRIME",
"GRIMY",
"GRIND",
"GRINS",
"GRIPE",
"GRIPS",
"GROAN",
"GROIN",
"GROOM",
"GROPE",
"GROSS",
"GROUP",
"GROUT",
"GROVE",
"GROWL",
"GROWN",
"GROWS",
"GRUEL",
"GRUFF",
"GRUNT",
"GUANO",
"GUARD",
"GUAVA",
"GUESS",
"GUEST",
"GUIDE",
"GUILD",
"GUILE",
"GUILT",
"GUISE",
"GULAG",
"GULCH",
"GULLS",
"GULLY",
"GUMBO",
"GUMMY",
"GUNKY",
"GUPPY",
"GUSTO",
"GUSTS",
"GUSTY",
"HABIT",
"HACKS",
"HAIKU",
"HAILS",
"HAIRS",
"HAIRY",
"HALAL",
"HALLS",
"HALVE",
"HANDS",
"HANDY",
"HANGS",
"HANKS",
"HAPPY",
"HARAM",
"HARDY",
"HAREM",
"HARMS",
"HARPY",
"HARRY",
"HARSH",
"HASTE",
"HASTY",
"HATCH",
"HATED",
"HATER",
"HATES",
"HAUNT",
"HAUTE",
"HAVEN",
"HAVES",
"HAVOC",
"HAWKS",
"HAYES",
"HAZEL",
"HEADS",
"HEADY",
"HEALS",
"HEAPS",
"HEARD",
"HEARS",
"HEART",
"HEATH",
"HEATS",
"HEAVE",
"HEAVY",
"HEDGE",
"HEEDS",
"HEELS",
"HEFTY",
"HEIRS",
"HEIST",
"HELIX",
"HELLA",
"HELLO",
"HELLS",
"HELPS",
"HEMPS",
"HENCE",
"HENRY",
"HERBS",
"HERDS",
"HERES",
"HERON",
"HERTZ",
"HEWED",
"HEXES",
"HICKS",
"HIDES",
"HIGHS",
"HIJAB",
"HIKED",
"HIKER",
"HIKES",
"HILLS",
"HILLY",
"HILTS",
"HINES",
"HINGE",
"HINTS",
"HIPPO",
"HIPPY",
"HIRED",
"HIRES",
"HITCH",
"HIVES",
"HOARD",
"HOBBY",
"HOBOS",
"HOCKS",
"HODGE",
"HOGAN",
"HOIST",
"HOLDS",
"HOLED",
"HOLES",
"HOLLY",
"HOLTS",
"HOMER",
"HOMES",
"HOMIE",
"HONDA",
"HONED",
"HONES",
"HONEY",
"HONOR",
"HOODS",
"HOOKS",
"HOOPS",
"HOOTS",
"HOPED",
"HOPES",
"HORDE",
"HORNS",
"HORNY",
"HORSE",
"HOSTS",
"HOTEL",
"HOTLY",
"HOUND",
"HOURS",
"HOUSE",
"HOVEL",
"HOVER",
"HOWDY",
"HUBBY",
"HUMAN",
"HUMID",
"HUMOR",
"HUMPH",
"HUMPS",
"HUMUS",
"HUNCH",
"HUNKS",
"HUNKY",
"HUNTS",
"HURRY",
"HURTS",
"HUSKY",
"HUSSY",
"HUTCH",
"HYDRA",
"HYDRO",
"HYENA",
"HYMEN",
"HYMNS",
"HYPED",
"HYPER",
"HYPES",
"ICIER",
"ICILY",
"ICING",
"ICONS",
"IDEAL",
"IDEAS",
"IDIOM",
"IDIOT",
"IDLED",
"IDLER",
"IDLES",
"IDOLS",
"IDYLL",
"IGLOO",
"ILIAC",
"IMAGE",
"IMBUE",
"IMPEL",
"IMPLY",
"INANE",
"INBOX",
"INCUR",
"INDEX",
"INDIA",
"INDIE",
"INEPT",
"INERT",
"INFER",
"INGOT",
"INKED",
"INKER",
"INLAY",
"INLET",
"INNER",
"INPUT",
"INTEL",
"INTER",
"INTRO",
"IONIC",
"IRATE",
"IRENE",
"IRONS",
"IRONY",
"ISLES",
"ISLET",
"ISSUE",
"ITCHY",
"ITEMS",
"JACKS",
"JAILS",
"JAPAN",
"JAUNT",
"JAZZY",
"JEANS",
"JELLY",
"JENNY",
"JERKS",
"JERKY",
"JETTY",
"JEWEL",
"JIFFY",
"JIHAD",
"JIMMY",
"JOHNS",
"JOINS",
"JOINT",
"JOIST",
"JOKED",
"JOKER",
"JOKES",
"JOLLY",
"JONES",
"JOSEF",
"JOSIE",
"JOUST",
"JUDGE",
"JUICE",
"JUICY",
"JULIO",
"JUMBO",
"JUMPS",
"JUMPY",
"JUNTA",
"JUNTO",
"JUROR",
"JADED",
"JAWED",
"JEEPS",
"JELLO",
"JESTS",
"JOEYS",
"JOLTS",
"JUKED",
"JUKES",
"JUNKY",
"KANJI",
"KAPOW",
"KAPPA",
"KAPUT",
"KARMA",
"KAYAK",
"KAZOO",
"KEBAB",
"KEELS",
"KEEPS",
"KELLY",
"KERRY",
"KEYED",
"KHAKI",
"KICKS",
"KIDDO",
"KILLS",
"KILNS",
"KILOS",
"KILTS",
"KINDA",
"KINDS",
"KINGS",
"KINKS",
"KINKY",
"KIOSK",
"KIRBY",
"KITTY",
"KLUGE",
"KNACK",
"KNAVE",
"KNEAD",
"KNEED",
"KNEEL",
"KNEES",
"KNELL",
"KNELT",
"KNICK",
"KNIFE",
"KNITS",
"KNOBS",
"KNOCK",
"KNOLL",
"KNOTS",
"KNOWN",
"KNOWS",
"KOALA",
"KODAK",
"KOOKS",
"KOOKY",
"KRAFT",
"KRILL",
"KUDOS",
"KUDZU",
"KYLIE",
"KYRIE",
"LABEL",
"LABOR",
"LACED",
"LACES",
"LACEY",
"LACKS",
"LADEN",
"LADLE",
"LAGER",
"LAIRD",
"LAIRS",
"LAKES",
"LAKHS",
"LAMBS",
"LAMER",
"LAMES",
"LAMPS",
"LANCE",
"LANDS",
"LANES",
"LANKY",
"LAPEL",
"LAPSE",
"LARGE",
"LARRY",
"LARVA",
"LASER",
"LASSO",
"LASTS",
"LATCH",
"LATER",
"LATEX",
"LATHE",
"LATTE",
"LAUDS",
"LAUGH",
"LAURA",
"LAWNS",
"LAYER",
"LEACH",
"LEADS",
"LEAFS",
"LEAFY",
"LEAKS",
"LEAKY",
"LEANS",
"LEANT",
"LEAPS",
"LEAPT",
"LEARN",
"LEASE",
"LEASH",
"LEAST",
"LEAVE",
"LEDGE",
"LEECH",
"LEEDS",
"LEERS",
"LEERY",
"LEFTY",
"LEGAL",
"LEGGY",
"LEGIT",
"LEMON",
"LEMUR",
"LENDS",
"LEONE",
"LEPER",
"LEVEE",
"LEVEL",
"LEVER",
"LEVIN",
"LEWIS",
"LIANG",
"LIARS",
"LIBEL",
"LIBRA",
"LICKS",
"LIEGE",
"LIFTS",
"LIGHT",
"LIKED",
"LIKEN",
"LIKES",
"LILAC",
"LIMBO",
"LIMBS",
"LIMES",
"LIMIT",
"LINED",
"LINEN",
"LINER",
"LINES",
"LINGO",
"LINKS",
"LINUS",
"LIONS",
"LIPID",
"LISTS",
"LITER",
"LITHE",
"LITRE",
"LIVED",
"LIVER",
"LIVES",
"LIVID",
"LLAMA",
"LOADS",
"LOAMY",
"LOANS",
"LOATH",
"LOBBY",
"LOBED",
"LOBES",
"LOCAL",
"LOCKS",
"LOCUS",
"LODGE",
"LOFTY",
"LOGIC",
"LOGIN",
"LOHAN",
"LONER",
"LONGS",
"LOOKS",
"LOOMS",
"LOONS",
"LOONY",
"LOOPS",
"LOOPY",
"LOOSE",
"LORRY",
"LOSER",
"LOSES",
"LOTTA",
"LOTTO",
"LOTUS",
"LOUIE",
"LOUSE",
"LOUSY",
"LOVED",
"LOVER",
"LOVES",
"LOWER",
"LOWLY",
"LOYAL",
"LUBED",
"LUBES",
"LUCID",
"LUCKY",
"LULLS",
"LUMEN",
"LUMPS",
"LUMPY",
"LUNAR",
"LUNCH",
"LUNGE",
"LUNGS",
"LUPUS",
"LURCH",
"LURED",
"LURES",
"LURID",
"LUSTS",
"LUSTY",
"LYING",
"LYMPH",
"LYNCH",
"LYRIC",
"MACAW",
"MACHO",
"MACON",
"MACOS",
"MACRO",
"MADAM",
"MADLY",
"MAFIA",
"MAGIC",
"MAGMA",
"MAGNA",
"MAHAL",
"MAIDS",
"MAILS",
"MAINS",
"MAIZE",
"MAJOR",
"MAKER",
"MAKES",
"MALES",
"MALIK",
"MALLS",
"MALTS",
"MALTY",
"MAMBA",
"MAMBO",
"MAMMA",
"MAMMY",
"MANED",
"MANES",
"MANGA",
"MANGE",
"MANGO",
"MANGY",
"MANIA",
"MANIC",
"MANLY",
"MANOR",
"MAPLE",
"MARCH",
"MARGE",
"MARIA",
"MARKS",
"MARRY",
"MARSH",
"MASKS",
"MASON",
"MASSE",
"MATCH",
"MATED",
"MATER",
"MATES",
"MATEY",
"MATHS",
"MATTE",
"MAULS",
"MAUVE",
"MAVEN",
"MAXIM",
"MAYBE",
"MAYOR",
"MEALS",
"MEALY",
"MEANS",
"MEANT",
"MEATS",
"MEATY",
"MECCA",
"MEDAL",
"MEDIA",
"MEDIC",
"MEETS",
"MELEE",
"MELON",
"MELTS",
"MEMES",
"MENDS",
"MENUS",
"MERCH",
"MERCY",
"MERGE",
"MERIT",
"MERLE",
"MERRY",
"MESAS",
"MESSY",
"METAL",
"METER",
"METRE",
"METRO",
"MICRO",
"MIDGE",
"MIDST",
"MIGHT",
"MILES",
"MILKY",
"MILLS",
"MIMES",
"MIMIC",
"MINCE",
"MINDS",
"MINED",
"MINER",
"MINES",
"MINIM",
"MINOR",
"MINTS",
"MINTY",
"MINUS",
"MIRTH",
"MISER",
"MISSY",
"MISTY",
"MITCH",
"MITER",
"MITES",
"MIXED",
"MIXER",
"MIXES",
"MIXUP",
"MOANS",
"MOATS",
"MOCHA",
"MOCKS",
"MODAL",
"MODEL",
"MODEM",
"MODES",
"MOGUL",
"MOIRA",
"MOIST",
"MOLAR",
"MOLDS",
"MOLDY",
"MOLES",
"MOLLY",
"MOLTS",
"MOMMA",
"MOMMY",
"MONDE",
"MONEY",
"MONKS",
"MONTE",
"MONTH",
"MOODS",
"MOODY",
"MOOED",
"MOONS",
"MOORS",
"MOOSE",
"MOPED",
"MORAL",
"MORAY",
"MORON",
"MORPH",
"MOSSY",
"MOTEL",
"MOTHS",
"MOTIF",
"MOTOR",
"MOTTO",
"MOULD",
"MOULT",
"MOUND",
"MOUNT",
"MOURN",
"MOUSE",
"MOUTH",
"MOVED",
"MOVER",
"MOVES",
"MOVIE",
"MOWER",
"MUCKS",
"MUCKY",
"MUCUS",
"MUDDY",
"MULCH",
"MULES",
"MUMMY",
"MUNCH",
"MURAL",
"MURKY",
"MUSES",
"MUSHY",
"MUSIC",
"MUSKY",
"MUSTY",
"MUTED",
"MUTES",
"MYRRH",
"MYTHS",
"NACHO",
"NADIR",
"NAILS",
"NAIVE",
"NAKED",
"NAMED",
"NAMES",
"NANCY",
"NANNY",
"NASAL",
"NASTY",
"NATAL",
"NAVAL",
"NAVEL",
"NECKS",
"NEEDS",
"NEEDY",
"NEGRO",
"NEIGH",
"NELLY",
"NERDS",
"NERDY",
"NERVE",
"NESTS",
"NEURO",
"NEVER",
"NEWER",
"NEWLY",
"NEXUS",
"NICER",
"NICHE",
"NICKS",
"NICKY",
"NIECE",
"NIFTY",
"NIGHT",
"NINJA",
"NINNY",
"NINTH",
"NITRO",
"NIXED",
"NOBLE",
"NOBLY",
"NODES",
"NOELS",
"NOISE",
"NOISY",
"NOMAD",
"NOOSE",
"NORMA",
"NORMS",
"NORTH",
"NOSED",
"NOSES",
"NOSEY",
"NOTCH",
"NOTED",
"NOTES",
"NOUNS",
"NOVEL",
"NUDES",
"NUDGE",
"NUKED",
"NUKES",
"NUMBS",
"NURSE",
"NUTTY",
"NYLON",
"NYMPH",
"OAKEN",
"OASIS",
"OBESE",
"OBEYS",
"OBITS",
"OBOES",
"OCCUR",
"OCEAN",
"OCHRE",
"OCTAL",
"OCTET",
"ODDER",
"ODDLY",
"ODORS",
"OFFAL",
"OFFER",
"OFTEN",
"OGRES",
"OILED",
"OILER",
"OINKS",
"OLDEN",
"OLDER",
"OLDIE",
"OLIVE",
"OLLIE",
"OMBRE",
"OMEGA",
"OMENS",
"OMITS",
"ONION",
"ONSET",
"OOZED",
"OOZES",
"OPALS",
"OPENS",
"OPERA",
"OPINE",
"OPIUM",
"OPTED",
"OPTIC",
"ORBIT",
"ORDER",
"ORGAN",
"OTHER",
"OTTER",
"OUGHT",
"OUIJA",
"OUNCE",
"OUTDO",
"OUTER",
"OUTGO",
"OUTIE",
"OUTTA",
"OVARY",
"OVATE",
"OVENS",
"OVERS",
"OVERT",
"OVINE",
"OVOID",
"OWING",
"OWLET",
"OWNED",
"OWNER",
"OXBOW",
"OXIDE",
"OZONE",
"PABLO",
"PACED",
"PACES",
"PACKS",
"PADDY",
"PADRE",
"PAGAN",
"PAGED",
"PAGER",
"PAGES",
"PAILS",
"PAINS",
"PAINT",
"PAIRS",
"PALEO",
"PALER",
"PALES",
"PALET",
"PALMS",
"PALSY",
"PANDA",
"PANEL",
"PANES",
"PANGS",
"PANIC",
"PANSY",
"PANTS",
"PAOLO",
"PAPAL",
"PAPAS",
"PAPER",
"PARED",
"PARER",
"PARKA",
"PARKS",
"PARRY",
"PARSE",
"PARTS",
"PARTY",
"PASHA",
"PASTA",
"PASTE",
"PASTY",
"PATCH",
"PATEL",
"PATHS",
"PATIO",
"PATSY",
"PATTY",
"PAUSE",
"PAVED",
"PAVES",
"PAWED",
"PAWNS",
"PAYEE",
"PAYER",
"PEACE",
"PEACH",
"PEAKS",
"PEARL",
"PEARS",
"PECAN",
"PECTS",
"PEDAL",
"PEELS",
"PEEPS",
"PEERS",
"PEGGY",
"PENAL",
"PENCE",
"PENIS",
"PENNE",
"PENNY",
"PERCH",
"PERIL",
"PERKS",
"PERKY",
"PERRY",
"PESKY",
"PESOS",
"PESTO",
"PESTS",
"PETAL",
"PETER",
"PETIT",
"PETTY",
"PHASE",
"PHONE",
"PHONY",
"PHOTO",
"PIANO",
"PICKS",
"PICKY",
"PIECE",
"PIERS",
"PIETY",
"PIGGY",
"PILED",
"PILES",
"PILLS",
"PILOT",
"PINCH",
"PINES",
"PINEY",
"PINKS",
"PINKY",
"PINOT",
"PINTO",
"PINTS",
"PIOUS",
"PIPED",
"PIPER",
"PIPES",
"PIQUE",
"PITCH",
"PITHY",
"PIVOT",
"PIXEL",
"PIXIE",
"PIZZA",
"PLACE",
"PLAID",
"PLAIN",
"PLAIT",
"PLANE",
"PLANK",
"PLANS",
"PLANT",
"PLATE",
"PLAYA",
"PLAYS",
"PLAZA",
"PLEAD",
"PLEAS",
"PLEAT",
"PLIED",
"PLOTS",
"PLOYS",
"PLUCK",
"PLUGS",
"PLUMB",
"PLUME",
"PLUMP",
"PLUMS",
"PLUNK",
"PLUSH",
"PLUTO",
"POACH",
"POEMS",
"POESY",
"POETS",
"POINT",
"POISE",
"POKED",
"POKER",
"POLAR",
"POLES",
"POLIO",
"POLKA",
"POLLS",
"POLLY",
"POLYP",
"PONDS",
"POOCH",
"POOLS",
"POOPS",
"POPES",
"POPPY",
"PORCH",
"PORES",
"PORNO",
"PORTS",
"POSED",
"POSER",
"POSES",
"POSIT",
"POSSE",
"POSTS",
"POTTY",
"POUCH",
"POUND",
"POURS",
"POUTY",
"POWER",
"PRANK",
"PRAWN",
"PRAYS",
"PREEN",
"PRESS",
"PRICE",
"PRICK",
"PRIDE",
"PRIED",
"PRIMA",
"PRIME",
"PRIMO",
"PRIMP",
"PRINT",
"PRIOR",
"PRISM",
"PRIUS",
"PRIVY",
"PRIZE",
"PROBE",
"PROMO",
"PROMS",
"PRONE",
"PRONG",
"PROOF",
"PROPS",
"PROSE",
"PROUD",
"PROVE",
"PROWL",
"PROWS",
"PROXY",
"PRUDE",
"PRUNE",
"PSALM",
"PSYCH",
"PUBIC",
"PUBIS",
"PUDGY",
"PUFFS",
"PUFFY",
"PULLS",
"PULPY",
"PULSE",
"PUMPS",
"PUNCH",
"PUNKS",
"PUNTS",
"PUPAL",
"PUPIL",
"PUPPY",
"PUREE",
"PURER",
"PURGE",
"PURSE",
"PUSHY",
"PUSSY",
"PUTTY",
"PYGMY",
"PYREX",
"QUACK",
"QUADS",
"QUAIL",
"QUAKE",
"QUALM",
"QUARK",
"QUART",
"QUASH",
"QUASI",
"QUEEN",
"QUEER",
"QUELL",
"QUERY",
"QUEST",
"QUEUE",
"QUICK",
"QUIET",
"QUILL",
"QUILT",
"QUIRK",
"QUITE",
"QUITS",
"QUOTA",
"QUOTE",
"QUOTH",
"RABBI",
"RABID",
"RACED",
"RACER",
"RACES",
"RACKS",
"RADAR",
"RADII",
"RADIO",
"RADON",
"RAFTS",
"RAGED",
"RAGES",
"RAIDS",
"RAILS",
"RAINS",
"RAINY",
"RAISE",
"RAJAH",
"RAKED",
"RAKES",
"RALLY",
"RALPH",
"RAMEN",
"RAMON",
"RAMPS",
"RANCH",
"RANDY",
"RANGE",
"RANKS",
"RANTS",
"RAPED",
"RAPES",
"RAPID",
"RARER",
"RASPY",
"RATED",
"RATES",
"RATIO",
"RATTY",
"RAVEN",
"RAVES",
"RAYON",
"RAZED",
"RAZES",
"RAZOR",
"REACH",
"REACT",
"READS",
"READY",
"REALM",
"REARM",
"REBAR",
"REBEL",
"REBUS",
"REBUT",
"RECAP",
"RECON",
"RECUR",
"RECUT",
"REEDS",
"REEDY",
"REEFS",
"REEKS",
"REELS",
"REFER",
"REFIT",
"REGAL",
"REHAB",
"REIGN",
"REINS",
"RELAX",
"RELAY",
"RELIC",
"REMIT",
"REMIX",
"RENAL",
"RENEW",
"RENTS",
"REPAY",
"REPEL",
"REPLY",
"RERUN",
"RESET",
"RESIN",
"RESTS",
"RETCH",
"RETRO",
"RETRY",
"REUSE",
"REVEL",
"REVUE",
"RHINO",
"RHYME",
"RICER",
"RICIN",
"RIDER",
"RIDES",
"RIDGE",
"RIFFS",
"RIFLE",
"RIFTS",
"RIGHT",
"RIGID",
"RIGOR",
"RILED",
"RILES",
"RILEY",
"RINDS",
"RINGS",
"RINSE",
"RIOTS",
"RIPEN",
"RIPER",
"RISEN",
"RISER",
"RISES",
"RISKS",
"RISKY",
"RITES",
"RIVAL",
"RIVER",
"RIVET",
"ROACH",
"ROADS",
"ROAST",
"ROBED",
"ROBES",
"ROBIN",
"ROBOT",
"ROCHE",
"ROCKS",
"ROCKY",
"RODEO",
"ROGER",
"ROGUE",
"ROHAN",
"ROLES",
"ROLLS",
"ROMAN",
"RONDO",
"ROOFS",
"ROOMS",
"ROOMY",
"ROOST",
"ROOTS",
"ROPED",
"ROPER",
"ROPES",
"ROSES",
"ROTOR",
"ROUGE",
"ROUGH",
"ROUND",
"ROUSE",
"ROUTE",
"ROVER",
"ROWAN",
"ROWDY",
"ROWED",
"ROWER",
"ROYAL",
"RUBES",
"RUBIN",
"RUDDY",
"RUDER",
"RUFUS",
"RUGBY",
"RUINS",
"RULED",
"RULER",
"RULES",
"RUMBA",
"RUMOR",
"RUMPS",
"RUNES",
"RUPEE",
"RURAL",
"RUSTY",
"RYDER",
"SABER",
"SABHA",
"SABLE",
"SABRE",
"SACKS",
"SADLY",
"SAFER",
"SAFES",
"SAGES",
"SAHIB",
"SAILS",
"SAINT",
"SAKES",
"SALAD",
"SALAH",
"SALES",
"SALLE",
"SALLY",
"SALON",
"SALSA",
"SALTS",
"SALTY",
"SALVE",
"SALVO",
"SAMBA",
"SAMMY",
"SANDS",
"SANDY",
"SANER",
"SANTA",
"SANTO",
"SAPPY",
"SASSY",
"SATES",
"SATIN",
"SATYR",
"SAUCE",
"SAUCY",
"SAUNA",
"SAUTE",
"SAVED",
"SAVER",
"SAVES",
"SAVOR",
"SAVOY",
"SAVVY",
"SAXES",
"SCABS",
"SCALA",
"SCALD",
"SCALE",
"SCALP",
"SCALY",
"SCAMP",
"SCAMS",
"SCANS",
"SCANT",
"SCARE",
"SCARF",
"SCARS",
"SCARY",
"SCENE",
"SCENT",
"SCION",
"SCOFF",
"SCOLD",
"SCONE",
"SCOOP",
"SCOPE",
"SCORE",
"SCORN",
"SCOUR",
"SCOUT",
"SCOWL",
"SCRAM",
"SCRAP",
"SCREE",
"SCREW",
"SCRUB",
"SCRUM",
"SCUBA",
"SEALS",
"SEAMS",
"SEARS",
"SEATS",
"SECTS",
"SEDAN",
"SEEDS",
"SEEDY",
"SEEKS",
"SEEMS",
"SEEPS",
"SEERS",
"SEGUE",
"SEINE",
"SEIZE",
"SELLS",
"SEMEN",
"SEMIS",
"SENDS",
"SENSE",
"SEPIA",
"SERFS",
"SERGE",
"SERIF",
"SERUM",
"SERVE",
"SETUP",
"SEVEN",
"SEVER",
"SEWED",
"SEWER",
"SEXES",
"SHACK",
"SHADE",
"SHADY",
"SHAFT",
"SHAKE",
"SHAKY",
"SHALE",
"SHALL",
"SHALT",
"SHAME",
"SHAMS",
"SHANK",
"SHAPE",
"SHARD",
"SHARE",
"SHARK",
"SHARP",
"SHAVE",
"SHAWL",
"SHEAF",
"SHEAR",
"SHEDS",
"SHEEN",
"SHEEP",
"SHEER",
"SHEET",
"SHEIK",
"SHELF",
"SHELL",
"SHIED",
"SHIFT",
"SHIMS",
"SHINE",
"SHINS",
"SHINY",
"SHIPS",
"SHIRE",
"SHIRK",
"SHIRT",
"SHIVA",
"SHOAL",
"SHOCK",
"SHOES",
"SHONE",
"SHOOK",
"SHOOT",
"SHOPS",
"SHORE",
"SHORN",
"SHORT",
"SHOTS",
"SHOUT",
"SHOVE",
"SHOWN",
"SHOWS",
"SHOWY",
"SHRED",
"SHREW",
"SHRUB",
"SHRUG",
"SHUCK",
"SHUNT",
"SHUSH",
"SHUTS",
"SHYLY",
"SIDED",
"SIDES",
"SIEGE",
"SIEVE",
"SIGHS",
"SIGHT",
"SIGMA",
"SIGNS",
"SILKS",
"SILKY",
"SILLS",
"SILLY",
"SILVA",
"SINCE",
"SINEW",
"SINGE",
"SINGS",
"SINKS",
"SINUS",
"SIREN",
"SISSY",
"SITES",
"SIXTH",
"SIXTY",
"SIZED",
"SIZES",
"SKATE",
"SKIER",
"SKIES",
"SKIFF",
"SKILL",
"SKIMP",
"SKIMS",
"SKINS",
"SKIPS",
"SKIRT",
"SKULK",
"SKULL",
"SKUNK",
"SLABS",
"SLACK",
"SLADE",
"SLAIN",
"SLAMS",
"SLANG",
"SLANT",
"SLAPS",
"SLASH",
"SLATE",
"SLATS",
"SLAVE",
"SLAWS",
"SLEEK",
"SLEEP",
"SLEET",
"SLEPT",
"SLICE",
"SLICK",
"SLIDE",
"SLIME",
"SLIMS",
"SLIMY",
"SLING",
"SLINK",
"SLIPS",
"SLOOP",
"SLOPE",
"SLOSH",
"SLOTH",
"SLOTS",
"SLOWS",
"SLUGS",
"SLUMP",
"SLUMS",
"SLUNG",
"SLUNK",
"SLURP",
"SLURS",
"SLUSH",
"SLYLY",
"SMACK",
"SMALL",
"SMART",
"SMASH",
"SMEAR",
"SMELL",
"SMELT",
"SMILE",
"SMIRK",
"SMITE",
"SMITH",
"SMOCK",
"SMOKE",
"SMOKY",
"SMOTE",
"SNACK",
"SNAIL",
"SNAKE",
"SNAKY",
"SNAPS",
"SNARE",
"SNARF",
"SNARL",
"SNEAK",
"SNEER",
"SNIDE",
"SNIFF",
"SNIPE",
"SNIPS",
"SNOOP",
"SNORE",
"SNORT",
"SNOUT",
"SNOWY",
"SNUBS",
"SNUCK",
"SNUFF",
"SOAKS",
"SOAPS",
"SOAPY",
"SOBER",
"SOCKS",
"SOFAS",
"SOGGY",
"SOILS",
"SOLAR",
"SOLES",
"SOLID",
"SOLOS",
"SOLVE",
"SONAR",
"SONGS",
"SONIC",
"SONNY",
"SOOTH",
"SOOTY",
"SORES",
"SORRY",
"SORTA",
"SORTS",
"SOULS",
"SOUND",
"SOUPS",
"SOUPY",
"SOUTH",
"SOWED",
"SOWER",
"SPACE",
"SPADE",
"SPANK",
"SPANS",
"SPARE",
"SPARK",
"SPASM",
"SPAWN",
"SPEAK",
"SPEAR",
"SPECK",
"SPECS",
"SPEED",
"SPELL",
"SPELT",
"SPEND",
"SPENT",
"SPERM",
"SPICE",
"SPICY",
"SPIED",
"SPIEL",
"SPIES",
"SPIKE",
"SPIKY",
"SPILL",
"SPILT",
"SPINE",
"SPINS",
"SPINY",
"SPIRE",
"SPITE",
"SPITS",
"SPLAT",
"SPLIT",
"SPOIL",
"SPOKE",
"SPOOF",
"SPOOK",
"SPOOL",
"SPOON",
"SPORE",
"SPORT",
"SPOTS",
"SPOUT",
"SPRAY",
"SPREE",
"SPRIG",
"SPUNK",
"SPURN",
"SPURS",
"SPURT",
"SQUAD",
"SQUAT",
"SQUIB",
"SQUID",
"STABS",
"STACK",
"STAFF",
"STAGE",
"STAID",
"STAIN",
"STAIR",
"STAKE",
"STALE",
"STALK",
"STALL",
"STAMP",
"STAND",
"STANK",
"STARE",
"STARK",
"STARS",
"START",
"STASH",
"STATE",
"STATS",
"STAVE",
"STAYS",
"STEAD",
"STEAK",
"STEAL",
"STEAM",
"STEED",
"STEEL",
"STEEP",
"STEER",
"STEIN",
"STEMS",
"STEPS",
"STERN",
"STICK",
"STIFF",
"STILL",
"STILT",
"STING",
"STINK",
"STINT",
"STOCK",
"STOIC",
"STOKE",
"STOLE",
"STOMP",
"STONE",
"STONY",
"STOOD",
"STOOL",
"STOOP",
"STOPS",
"STORE",
"STORK",
"STORM",
"STORY",
"STOUT",
"STOVE",
"STRAP",
"STRAW",
"STRAY",
"STRIP",
"STRUT",
"STUCK",
"STUDS",
"STUDY",
"STUFF",
"STUMP",
"STUNG",
"STUNK",
"STUNT",
"STYLE",
"SUAVE",
"SUCKS",
"SUEDE",
"SUETS",
"SUGAR",
"SUING",
"SUITE",
"SUITS",
"SULKS",
"SULKY",
"SULLY",
"SUMAC",
"SUNNY",
"SUPER",
"SUPRA",
"SURER",
"SURGE",
"SURLY",
"SUSAN",
"SUSHI",
"SWABS",
"SWAMI",
"SWAMP",
"SWANK",
"SWANS",
"SWAPS",
"SWARM",
"SWASH",
"SWATH",
"SWEAR",
"SWEAT",
"SWEDE",
"SWEEP",
"SWEET",
"SWELL",
"SWEPT",
"SWIFT",
"SWILL",
"SWIMS",
"SWINE",
"SWING",
"SWIPE",
"SWIRL",
"SWISH",
"SWOON",
"SWOOP",
"SWORD",
"SWORE",
"SWORN",
"SWUNG",
"SYKES",
"SYNOD",
"SYNTH",
"SYRUP",
"TABBY",
"TABLE",
"TABOO",
"TACIT",
"TACKS",
"TACKY",
"TACOS",
"TACTS",
"TAFFY",
"TAILS",
"TAINT",
"TAKEN",
"TAKER",
"TAKES",
"TAKIN",
"TALES",
"TALKS",
"TALLY",
"TALON",
"TAMED",
"TAMER",
"TAMMY",
"TANGO",
"TANGY",
"TANKS",
"TANYA",
"TAPED",
"TAPER",
"TAPES",
"TAPIR",
"TARDY",
"TAROT",
"TARPS",
"TASKS",
"TASTE",
"TASTY",
"TATTY",
"TAUNT",
"TAWNY",
"TAXED",
"TAXES",
"TAXIS",
"TEACH",
"TEAMS",
"TEARS",
"TEARY",
"TEASE",
"TEATS",
"TEDDY",
"TEENS",
"TEENY",
"TEETH",
"TELLS",
"TELLY",
"TEMPO",
"TEMPS",
"TEMPT",
"TENDS",
"TENET",
"TENOR",
"TENSE",
"TENTH",
"TENTS",
"TEPEE",
"TEPID",
"TERMS",
"TERRA",
"TERRY",
"TERSE",
"TESLA",
"TESTS",
"TESTY",
"TEXAS",
"TEXTS",
"THANK",
"THEFT",
"THEIR",
"THEME",
"THERE",
"THESE",
"THETA",
"THICK",
"THIEF",
"THIGH",
"THINE",
"THING",
"THINK",
"THIRD",
"THONG",
"THORN",
"THOSE",
"THREE",
"THREW",
"THROB",
"THROW",
"THRUM",
"THUDS",
"THUGS",
"THUMB",
"THUMP",
"THYME",
"TIARA",
"TIBET",
"TIBIA",
"TICKS",
"TIDAL",
"TIDES",
"TIERS",
"TIGER",
"TIGHT",
"TILDE",
"TILED",
"TILES",
"TIMED",
"TIMER",
"TIMES",
"TIMID",
"TIPSY",
"TIRED",
"TIRES",
"TITAN",
"TITER",
"TITHE",
"TITLE",
"TITTY",
"TOADS",
"TOAST",
"TODAY",
"TODDY",
"TOFFY",
"TOKEN",
"TOLLS",
"TOMBS",
"TONAL",
"TONED",
"TONER",
"TONES",
"TONGA",
"TONIC",
"TONNE",
"TOOLS",
"TOONS",
"TOOTH",
"TOOTS",
"TOPAZ",
"TOPEE",
"TOPIC",
"TORCH",
"TORSO",
"TORUS",
"TOTAL",
"TOTEM",
"TOUCH",
"TOUGH",
"TOURS",
"TOWED",
"TOWEL",
"TOWER",
"TOWNS",
"TOXIC",
"TOXIN",
"TRACE",
"TRACK",
"TRACT",
"TRADE",
"TRAIL",
"TRAIN",
"TRAIT",
"TRAMP",
"TRAMS",
"TRANS",
"TRAPS",
"TRASH",
"TRAWL",
"TRAYS",
"TREAD",
"TREAT",
"TREES",
"TREND",
"TRIAD",
"TRIAL",
"TRIBE",
"TRICE",
"TRICK",
"TRIED",
"TRIER",
"TRIES",
"TRIKE",
"TRIMS",
"TRIPE",
"TRIPS",
"TRITE",
"TROLL",
"TROMP",
"TROOP",
"TROPE",
"TROTS",
"TROUT",
"TROVE",
"TRUCE",
"TRUCK",
"TRUER",
"TRULY",
"TRUMP",
"TRUNK",
"TRUSS",
"TRUST",
"TRUTH",
"TRYST",
"TUBAL",
"TUBER",
"TUBES",
"TUCKS",
"TUFTS",
"TULIP",
"TULLE",
"TUMMY",
"TUMOR",
"TUNED",
"TUNER",
"TUNES",
"TUNIC",
"TURBO",
"TURFS",
"TURNS",
"TUTOR",
"TWAIN",
"TWANG",
"TWEAK",
"TWEED",
"TWEET",
"TWICE",
"TWIGS",
"TWINE",
"TWINS",
"TWIRL",
"TWIST",
"TWITS",
"TWIXT",
"TYING",
"TYPED",
"TYPES",
"TYPOS",
"TYRES",
"TZARS",
"UDDER",
"ULCER",
"ULTRA",
"UMBRA",
"UNBAR",
"UNBOX",
"UNCLE",
"UNCUT",
"UNDER",
"UNDID",
"UNDUE",
"UNFED",
"UNFIT",
"UNIFY",
"UNION",
"UNITE",
"UNITS",
"UNITY",
"UNLIT",
"UNMET",
"UNSET",
"UNTIE",
"UNTIL",
"UNWED",
"UNZIP",
"UPEND",
"UPPED",
"UPPER",
"UPSET",
"URBAN",
"URGED",
"URGES",
"URINE",
"USAGE",
"USERS",
"USHER",
"USING",
"USUAL",
"USURP",
"UTILE",
"UTTER",
"UVULA",
"VAGUE",
"VALET",
"VALID",
"VALOR",
"VALUE",
"VALVE",
"VAPES",
"VAPID",
"VAPOR",
"VASES",
"VAULT",
"VAUNT",
"VEGAN",
"VEILS",
"VEINS",
"VELUM",
"VENOM",
"VENTS",
"VENUE",
"VERBS",
"VERGE",
"VERSE",
"VERSO",
"VERVE",
"VESTS",
"VEXED",
"VEXES",
"VIALS",
"VIBES",
"VICAR",
"VICES",
"VIDEO",
"VIEWS",
"VIGIL",
"VIGOR",
"VILLA",
"VINES",
"VINYL",
"VIOLA",
"VIPER",
"VIRAL",
"VIRUS",
"VISAS",
"VISES",
"VISIT",
"VISOR",
"VISTA",
"VITAL",
"VITRO",
"VIVID",
"VIXEN",
"VOCAL",
"VODKA",
"VOGUE",
"VOICE",
"VOIDS",
"VOILA",
"VOLTS",
"VOMIT",
"VOTED",
"VOTER",
"VOTES",
"VOUCH",
"VOWED",
"VOWEL",
"VYING",
"WACKY",
"WAFER",
"WAFTS",
"WAGED",
"WAGER",
"WAGES",
"WAGON",
"WAGYU",
"WAHOO",
"WAIFS",
"WAILS",
"WAIST",
"WAITS",
"WAIVE",
"WAKES",
"WALES",
"WALKS",
"WALLS",
"WALLY",
"WALTZ",
"WANDS",
"WANED",
"WANES",
"WANNA",
"WANTS",
"WARDS",
"WARES",
"WARMS",
"WARNS",
"WARPS",
"WARTS",
"WARTY",
"WASPS",
"WASTE",
"WATCH",
"WATER",
"WATTS",
"WAVED",
"WAVER",
"WAVES",
"WAXED",
"WAXEN",
"WAXER",
"WAXES",
"WEARS",
"WEARY",
"WEAVE",
"WEBER",
"WEDGE",
"WEEDS",
"WEEDY",
"WEEKS",
"WEEPS",
"WEIGH",
"WEIRD",
"WELCH",
"WELDS",
"WELLS",
"WELSH",
"WELTS",
"WENCH",
"WENDS",
"WHACK",
"WHALE",
"WHARF",
"WHATS",
"WHEAT",
"WHEEL",
"WHELP",
"WHERE",
"WHICH",
"WHIFF",
"WHILE",
"WHIMS",
"WHINE",
"WHINY",
"WHIPS",
"WHIRL",
"WHISK",
"WHITE",
"WHOLE",
"WHOOP",
"WHORE",
"WHORL",
"WHOSE",
"WIDEN",
"WIDER",
"WIDOW",
"WIDTH",
"WIELD",
"WIGAN",
"WIGHT",
"WILLS",
"WILLY",
"WILTS",
"WIMPS",
"WIMPY",
"WINCE",
"WINCH",
"WINDS",
"WINDY",
"WINES",
"WINGS",
"WINKS",
"WIPED",
"WIPER",
"WIPES",
"WIRED",
"WIRES",
"WISER",
"WISPY",
"WITCH",
"WITTY",
"WIVES",
"WOKEN",
"WOMAN",
"WOMBS",
"WOMEN",
"WOODS",
"WOODY",
"WOOED",
"WOOER",
"WOOFS",
"WOOLY",
"WOOSH",
"WOOZY",
"WORDS",
"WORDY",
"WORKS",
"WORLD",
"WORMS",
"WORMY",
"WORRY",
"WORSE",
"WORST",
"WORTH",
"WOULD",
"WOUND",
"WOVEN",
"WOWED",
"WRACK",
"WRAPS",
"WRATH",
"WREAK",
"WRECK",
"WRENS",
"WREST",
"WRING",
"WRIST",
"WRITE",
"WRONG",
"WROTE",
"WRUNG",
"WRYLY",
"XEROX",
"YACHT",
"YAHOO",
"YANKS",
"YAPPY",
"YARDS",
"YARNS",
"YATES",
"YAWNS",
"YEARN",
"YEARS",
"YEAST",
"YELLS",
"YIELD",
"YIKES",
"YODLE",
"YOKED",
"YOLKS",
"YOUNG",
"YOURS",
"YOUTH",
"YUCCA",
"YUCKY",
"YUMMY",
"YURTS",
"ZEBRA",
"ZEROS",
"ZESTS",
"ZESTY",
"ZILCH",
"ZINGS",
"ZIPPO",
"ZIPPY",
"ZONAL",
"ZONED",
"ZONES"}; 
}
