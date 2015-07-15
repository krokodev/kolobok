--# Kolobok
--[[---------------------------------------------------------
-- Papa's game studio (c) 2014
-- Kolobok roadmap
-- stage Empathic

TODO
~~~~
= release 1.4.0 "Signals"
- refactoring 
- comfort.exp
- Rational: adjust signal emotions based upon tactics and expectation
- Rational: eyes attitude emotion -- open or squint
- eyebrow to show attitude (good or evil or neutral for selected)
- long tap on actor to enter explore mode -- keep cureent (focused) view and add new 

= release 1.5.0
- undo
- Pack.Beliefs
- Pack.Distortions
- Pack.Sympathy -- wishing good to smbdy
- point out cause in "past" when print Map
- tactics: "look around", "curiosity"
- pack.level.mission
- calculated condition of level completeness
- automatic moving to next level
- verify location names' uniqaueness
- transformations rules (zombies from corpuses)
- asking peers
- log rename to Diary, put Journal to use
- draw trace for current subj
- Tests: secret and imaginary logics
- Tests: assert SightRange is always more than moveRange to prevent barriers tunelling
- optimize Grid drawing
- kolobok: make game
- form out Engine
- stage: select commando view
- add "app" and "worlds" to stack to choice worlds
- stage Strategic (Empathic)
- Test: Can secret imaginary subj in one's mind make aware about other secret imaginaries?
- Test: Secret info cant be known by subpersons
- stage Intuitive (Empathic, Strategic)
- scheme.edit: hand-move objects in "present"
- correct positions after realising to prevent crossing unpassable objects (?)
- Communication: show signs if partner misanderstend your intention (scout & fighter exm)
- touching Stage put ExpiredAttention to change look of all present creations just for fun
- Watch panel -- laws, attitudes, etc

-------------------------------------------------------------

DONE
~~~~
+ beware.exp
+ set up intention.expectation in Tactics to use in signal emotions
x Rational: future and present emotions (plans and done)
x Actor: first show present, then future emotions
+ Actor: mouth shows happiness/fear
+ Actor: map emotions to draw parameters, just on mouth for now
+ Rational: calc emotions
+ Watch panel -- emotions
+ mouths
+ long tap on space in standart mode will put order
+ stage: put into panel
+ abandon ui.inModalMode
+ panels: stopTouchProc()
+ stage: in Explore mode allow select nonreflexive objects
+ Watch panel -- name, kind, reflevel, tactics, point of attention
x show tactics on top panel
+ prevent crash via garbage collection
+ tactics Attack -- only if view in real, use in Commando for Fighters
x sight sector (viewing angle)
+ draw properties in Pack
+ eyes

-- 1.3.0 "Games" --

+ Pack.App.Lawbook.Collisions did not work
+ run only view world in menu mode
x add leo to ants and insert those gang to Exit imagination -- leo must pursue ants
+ disable Run and Edit buttons in AppMenu mode
+ format text about controls
+ info / Purpose / Construction / How to use / etc
+ add Ants to App screen -- Likes Games:1, Locations:2
+ toucher: onSlide
+ long tap to explore mode
+ exit / conform
+ menu item Close
+ save and restore app.stage.canvas coords
+ open recent game when popup loading screen
+ add Info to App screen
+ Pack: point out game/level background colour
+ save and restart recent game
+ suggested info
+ Pack: set up initial window for best scene's view
+ allow to select and load games and levels via stage, scheme and actor.action
+ Scheme: try implant some compex secret creattion instead of Orders
+ actor: show estimation of View-subject on others
+ game Commando
+ improve perfomance
* actor:error long intention vectors are shown if tap on actor with rl=1 and then on space
+ leader
+ comfortDist
x error: public order does not disapear in mouse mind (?)
+ tactics: comfortable distance
+ pack: attitudes
+ rename likes / dislikes()
* tactics beware does not work properly
+ stage: onTap -- first mode then subject
+ stage: select place for new object
x why fScout know secret order for Fighter?
+ in Pack rename radius to size
+ in Pack rename midst to disposition and descr to description
* why can't put secret order in subj's bounds?
* why fighter ignored public order in it's bounds?
+ Rational:convinceOf() wellknown or secret -- only if imaginary or invisible
+ assert imaginary must be invisible -- to test
+ assert secret must be invisible -- to test
+ scheme: button to put order
+ imaginary objects
+ visible - invisible objects
+ error(?) sFighter beware Scouts and vice versa (chek like and diskike for "none")
+ show attitude
+ write new level 
+ add level Collision in Lawbook
* error in panel elements touch -- shift txy accordinaly to panel position 
+ show popup on stack click
+ panel.text
+ stack panel text font size error
+ simplify ui stack
+ rename Strategies to Tactic/s
+ show descr of current location
+ remove Common prj
+ clear code
+ milestone Empathic
. demo to AS and EG

-- 1.2.0 "Scheme" --

+ release 1.2.0
x desr in top panel
- show info first time
x godzilla
+ info button -- about app and how to use
+ actor: mark supposed for View subjs
+ rename passable to impassable
+ barriers -- impassable, adjustMoveToPassability
+ tactics refactoring
+ rational canSee take in count opaque 
+ barriers -- opaque or/and impassable

-- 1.1.5 --

x rename debug buttons
+ set up colours in Pack-Kinds/Persons and use them by Actors and Stack
+ improve text color generation
+ Actors' states -- isSelected, isWorld
x invisible objects should be drawn diferently than visible
x use Stack to select world
x "run" must refere to current subj, "back to stack" should restore its prev state
x show steps in Present
+ correct show deep stack on dead subjects (view and world)
x add tests fo Actors to check scene for adequation for scheme
+ show View in stack
+ when come back from deep world set focus to current isWorld actor
+ buttons autoset colors
+ state button

-- 1.1.4 --

+ provide using selection and falling in worlds more transparently 
+ stage: institute mode "explore" (button on Stack and long tap)
* err: select fly, unselect, run -- got fly selected w/o isView
+ use debug
x long tap to fall in
+ optimize delay in animation in Stage:setWorld
+ refactore - Actor:drawIntention, Actor:drawMoveRange, Actor:drawSightRange
+ one tap Actor to select it, double tap to fall in its Present World
+ actor remove isPhantom
+ world cgahging animation
+ fly does not make rounds
+ boost circles
+ pcircle for move range
+ smooth fitting
+ rename scene to stage
+ fps

-- 1.1.3 --

+ buttons: speed, run, debug, info, restart
+ actors: smooth disappearence 
+ past -- to keep info about forgotten objects
+ rational class refactoring
+ actors: smooth appearence 
+ actors: smooth moving using tweens
+ forget unlawful, mind-only objects wich position conflicts with laws and visible objects
+ Canvas as helper class
+ limit scale
+ canvas as superclass of stage
+ improve scaling -- keep focus between t1 and t2 -- use pseudocode
+ stage -- scaling
+ stage -- scrolling
+ use events

-- 1.1.2 --

+ draw grid on playground
+ rename introduceToContextDeeply ~learn,study etc (explore)
+ implement other autotests
+ deeply update
+ forget deeply -- just forgot and then update deeply to eliminate ghosts
+ abandon is-Existent flag
+ deeply forget
+ introduce deeply when meet obj
x abandon from inroduction, try to use only main loop
x first inq then realize -- to prevent mismatched collisions
+ memory for invisible subpersons 
+ revise: incrimental update subpersons
+ log

-- 1.1.1 --

+ split state into flags
+ delete Eternal flag
+ protection from apathia in dangerous by random
+ tactics collection tactics={"courage","wary"}
+ autofit scheme in playground
+ pack.kinds : all properties from persons
+ kinds hierarchy
+ use superior classes in Lawbook: feed={animals=bad}
+ tactics: wary -- find safetest place
-- 1.1.0 --
...
-- 1.0.0 --
--]]---------------------------------------------------------

-- eof --




























--# Pack
-- pack.lua
-- Papa's game studio (c) 2014

-- consts --

Const={}
Const.Lawbook={}
Const.Lawbook.Collision        ={}
Const.Lawbook.Collision.Good   = 1
Const.Lawbook.Collision.Bad    =-1
Const.Lawbook.Collision.None   = 0
Const.Lawbook.Attitude         ={}
Const.Lawbook.Attitude.Like    = 1
Const.Lawbook.Attitude.Dislike =-1
Const.Lawbook.Attitude.Ignore  = 0
Const.Draw              ={}
Const.Draw.Name         ={}
Const.Draw.Name.None    = 0
Const.Draw.Name.Center  = 1
Const.Draw.Eyes         ={}
Const.Draw.Eyes.None    = 0
Const.Draw.Eyes.Normal  = 1
Const.Draw.Mouth        ={}
Const.Draw.Mouth.None   = 0
Const.Draw.Mouth.Normal = 1


-- pack --

Pack = 
{
    Zoo      = { Description = "Animals life"     , IsGame = true, n=1 },
    Commando = { Description = "Empathic missions", IsGame = true, n=2 },
    Common   = { Description = "Common elements" },
    App      = { Description = "App menu" },
}
Pack.Background = color(31, 83, 36, 255)

-- common --

Pack.Common.Kinds = {
    Essences = {
        kind        = nil,
        tactics     = {},
        imagination = {},
        refLevel    = 0,
        sightRange  = 0,
        moveRange   = 0,
        comfortDist = 0,
        size        = 6,
        impassable  = false,
        opaque      = false,
        imaginary   = false,
        suggested   = false,
        visible     = true,
        secret      = false,
        onTap       = nil,
        onFocus     = nil,
        drawName    = Const.Draw.Name.Center,
        drawEyes    = Const.Draw.Eyes.None,
        drawMouth   = Const.Draw.Mouth.None,
        colour      = color(127, 127, 127, 133),
    },
    Entities = { 
        kind       = "Essences",
        colour     = color(60,70,110,170),
    },
    Ideas = { 
        kind       = "Essences",
        imaginary  = true,
        visible    = false,
        colour     = color(159, 164, 93, 102),
    },
    Signs = {
        kind       = "Ideas",
        colour     = color(89, 93, 145, 148),
    },
    Barriers = {
        kind       = "Entities",
        impassable = true,
        opaque     = true,
    },
    Creatures = { 
        kind       = "Entities",   
        tactics    = {"hunt", "avoid", "comfort", "wait", "panic"},
        refLevel   = 2,
        comfortDist= 1,
        drawName    = Const.Draw.Name.None,
        drawEyes    = Const.Draw.Eyes.Normal,
        drawMouth   = Const.Draw.Mouth.Normal,
    },
    Rocks = {
        kind       = "Barriers",
        colour     = color(49, 49, 49, 148),
    },
    Orders = {
        kind       = "Signs",
        size       = 4,
        colour     = color(255, 16, 0, 201),
    },
}

Pack.Common.Kinds.InsertTo = function(branch)
    for n,k in pairs(Pack.Common.Kinds) do
        branch[n]=k
    end
end

-- eof --

















--# Commando
-- commando.lua
-- Papa's game studio (c) 2014

-- locations --

Pack.Commando.Locations = {
    ["Intro"] = { n=1,
        Description = "Destroy enemy",
        Disposition = {
            Enemy1   = { x= 15, y= 100, tactics={"beware"}},
            Fighter  = { x= 15, y=  70, moveRange=20, sightRange=200 },
        },
    },
    ["Bar"] = { n=3,
        Description = "Scout would find enemies and fighter destroy them",
        Disposition = {
            Enemy1   = { x=  15, y= 250 },
            Enemy2   = { x=-200, y=-300, imagination={Bar={x=0,y=100,kind="Bars"}} },
            Bar      = { x= -40, y= 100, kind = "Bars" },
            Drink1   = { x= -45, y=  95, kind = "Drinks" },
            Drink2   = { x= -35, y=  95, kind = "Drinks" },
            Drink3   = { x= -40, y= 105, kind = "Drinks" },
            Scout    = { x= -10, y=  20 },
            Fighter  = { x= -30, y=  10 },
        },
        Center     = {x=-25,y=60,scale=7},
    },
    ["Order"] = { n=2,
        Description = "Use one secret order and two moves to destroy enemy",
        Disposition = {
            Enemy1   = { x= 20, y= 60 },
            Scout    = { x=  0, y= 40, moveRange = 30 },
            Fighter  = { x=-30, y= 10, refLevel  = 2 },
        },
    },
}

-- persons --

Pack.Commando.Persons = {
    Enemy1    = { kind = "Enemies"  },
    Enemy2    = { kind = "Enemies", refLevel=4  },
    Scout     = { kind = "Scouts"   },
    Fighter   = { kind = "Fighters" },
}

-- kinds --

Pack.Commando.Kinds = {
    Buildings = {
        kind       = "Entities",
        colour     = color(49, 49, 49, 148),
    },
    Bars = {
        kind       = "Buildings",
        size       = 25,
    },
    Drinks = {
        kind       = "Entities",
        size       = 4,
        colour     = color(255, 113, 0, 203),
    },
    Warriors = {
        kind       = "Creatures",
        tactics    = {"hunt", "avoid", "comfort", "wait", "panic"},
        refLevel   =  2,
        sightRange = 30,
        moveRange  = 20,
        size       = 10,
    },
    Enemies = {
        kind       = "Warriors",
        sightRange = 50,
        moveRange  = 15,
        colour     = color(162, 81, 29, 198),
    },
    Members = {
        kind       = "Warriors",
        colour     = color(32, 62, 29, 255),
    },
    Scouts = {
        kind       = "Members",
        refLevel   =  4,
        size       =  8,
        sightRange =200,
        comfortDist=  0,
        moveRange  = 10,
    },
    Fighters = {
        kind       = "Members",
        refLevel   =  3,
        size       = 12,
        comfortDist=  0,
        sightRange = 70,
        moveRange  = 20,
    },
}
Pack.Common.Kinds.InsertTo(Pack.Commando.Kinds)

-- laws --

local bad     = Const.Lawbook.Collision.Bad
local good    = Const.Lawbook.Collision.Good
local none    = Const.Lawbook.Collision.None

local like    = Const.Lawbook.Attitude.Like
local dislike = Const.Lawbook.Attitude.Dislike
local ignore  = Const.Lawbook.Attitude.Ignore

Pack.Commando.Lawbook = {
    Collisions = {
        Drinks   = { Warriors =  bad                                  },
        Warriors = { Warriors =  bad,                                 },
        Enemies  = { Scouts   = good,  Drinks = good                  },
        Members  = { Enemies  = good,  Members = none, Orders = good  },
        Scouts   = { Enemies  =  bad                                  },
        Orders   = {                   Members = bad                  },
    },
    Attitudes = {
        Warriors = { Bars    = {like,1},  Drinks   = {like,3}},
        Fighters = { Scouts  = {like,100} },
        Scouts   = { Enemies = {like,100}, Fighters = {like,2}},
    },
}

-- eof --


























--# Zoo
-- zoo.lua
-- Papa's game studio (c) 2014

-- locations --

local mt  = {"hunt","comfort"}
local mk  = "Mice"
local mrl = 2

Pack.Zoo.Locations = {
    ["Feeding"] = { n=1,
        Description = "Feed mouse and leave it alone, note fly beats dog!",
        Disposition = {
            Dog    = { x= 15, y= 70 },
            Cat    = { x=-10, y= 30 },
            Mouse  = { x= 10, y=  5 },
            Fly    = { x= 20, y= 20 },
            Cheese = { x=-10, y=-14 },
            Honey  = { x= 45, y=-25 },
            Mount  = { x=-20, y= 70, size = 30, kind = "Rocks" },
            Rock   = { x= 15, y= 40, size = 16, kind = "Rocks" },
        },
    },
    ["Dance"] = { n=2,
        Description = "Mice dancing",
        Disposition = {
            M1     = { x=10, y= 40, refLevel = mrl, kind = mk, tactics = mt },
            M2     = { x=10, y= 10, refLevel = mrl, kind = mk, tactics = mt },
            M3     = { x=40, y= 10, refLevel = mrl, kind = mk, tactics = mt },
            M4     = { x=40, y= 40, refLevel = mrl, kind = mk, tactics = mt },
            M5     = { x=25, y= 60, refLevel = mrl, kind = mk, tactics = mt },
            M6     = { x=10, y= 70, refLevel = mrl, kind = mk, tactics = mt },
            M7     = { x=40, y= 70, refLevel = mrl, kind = mk, tactics = mt },
        },
    },
    ["Tom"] = { n=3,
        Description = "Tom hunting",
        Disposition = {
            Cat    = { x=99, y=99, refLevel = 3,           },
            M0     = { x= 0, y= 0, refLevel = 4, kind = mk },
            M1     = { x=10, y=40, refLevel = 2, kind = mk },
            M2     = { x=10, y=10, refLevel = 2, kind = mk },
            Fly    = { x=10, y=30, refLevel = 5 }
        },
    },
    ["Leader"] = { n=4,
        Description = "Mice leader",
        Disposition = {
            M0     = { x= 0, y= 0, refLevel = 3, kind = "MiceLeader" },
            M1     = { x=10, y=40, refLevel = 2, kind = mk },
            M2     = { x=10, y=10, refLevel = 2, kind = mk },
            M3     = { x=40, y=10, refLevel = 1, kind = mk },
            M4     = { x=40, y=40, refLevel = 1, kind = mk },
            M5     = { x=25, y=60, refLevel = 1, kind = mk },
            M6     = { x=10, y=70, refLevel = 1, kind = mk },
            M7     = { x=40, y=70, refLevel = 1, kind = mk },
        },
    },
}

-- persons --

Pack.Zoo.Persons = {
    Dog     = { kind = "Dogs"    },
    Cat     = { kind = "Cats"    },
    Mouse   = { kind = "Mice"    },
    Fly     = { kind = "Insects" },
    Cheese  = { kind = "Feeds"   ,  colour = color(111, 97, 35, 200) },
    Honey   = { kind = "Feeds"   ,  colour = color(127, 110, 30, 255) },
}

-- kinds --

Pack.Zoo.Kinds = {
    Animals = { 
        kind       = "Creatures",   
        tactics    = {"hunt", "avoid", "comfort", "around", "wait", "panic"},
        refLevel   = 2,
        size       = 6,
    },
    Dogs    = {
        kind       = "Animals",
        refLevel   =  3,
        sightRange = 50,
        moveRange  = 40,
        size       = 12,
        colour     = color(76, 51, 32, 160),
    },
    Cats = {
        kind       = "Animals",
        refLevel   =  2,
        sightRange = 35,
        moveRange  = 30,
        size       = 10,
        colour     = color(31, 62, 101, 201),
    },
    Mice = {
        kind       = "Animals",
        refLevel   =  5,
        sightRange = 55,
        moveRange  = 15,
        size       =  8,
        comfortDist= 20,
        colour     = color(65, 66, 65, 255),
    },
    MiceLeader = {
        kind       = "Mice",
        sightRange = 100,
        moveRange  =  10,
        colour     = color(54, 54, 54, 255),
    },
    Insects = {
        kind       = "Animals",
        refLevel   =  4,
        sightRange = 30,
        moveRange  = 20,
        size       =  6,
        colour     = color(32, 62, 29, 255),
    },
    Feeds = {
        kind       = "Entities",
    },
}
Pack.Common.Kinds.InsertTo(Pack.Zoo.Kinds)

-- laws --

local bad     = Const.Lawbook.Collision.Bad
local good    = Const.Lawbook.Collision.Good
local none    = Const.Lawbook.Collision.None

local like    = Const.Lawbook.Attitude.Like
local dislike = Const.Lawbook.Attitude.Dislike
local ignore  = Const.Lawbook.Attitude.Ignore

Pack.Zoo.Lawbook = {
    Collisions = {
        Orders  = { Animals = bad  },
        Animals = { Feeds   = good, Orders = good },
        Feeds   = { Animals = bad  },
        Dogs    = { Dogs = good, Cats = good, Mice = good,  Insects = bad  },
        Cats    = { Dogs = bad,  Cats = bad,  Mice = good,  Insects = good },
        Mice    = { Dogs = bad,  Cats = bad,  Mice = none,  Insects = good },
        Insects = { Dogs = good,                            Animals = bad  },
    },
    Attitudes = {
        Mice    = { Mice={like}, MiceLeader={like,10}, Orders={like}, Rocks={like} },
        Fly     = { Mice={like} },
    }
}


-- eof --

























--# App
-- app.lua
-- Papa's game studio (c) 2014

App = class()
App.tickNum = 0
App.TheApp  = nil

-- metadata --

description = "Kolobok – explore your mind!"
author      = "Papa's games studio"
since       = "27 March 2014"
version     = "1.3"

-- init --

function App:init()
    App.TheApp      = self
    self.fps        = ""
    self.inMenuMode = false
    self.recent={game=nil,location=nil}
    self:initGeometry()
    self:preparePackApp()
    self:createElements()
    self:initParameters()
    self:bindEvents()
    self:loadData()
    self:onInit()
end

function App:initGeometry()
    self.topHight    = 45
    self.bottomHight = 70
    displayMode(FULLSCREEN_NO_BUTTONS)
    backingMode(STANDARD)
    supportedOrientations(PORTRAIT_ANY)
end

-- elements --

function App:createElements()
    self.scheme  = Scheme("App")
    self.stage   = Stage(self.scheme, self.topHight-1, self.bottomHight-1)
    self.ui      = UI(self.stage, self.topHight, self.bottomHight)
    self.scheme:popupLocationInfo()
end

-- events --

function App:bindEvents()
    Events.bind("app.close",     self, App.onClose      )
    Events.bind("app.restart",   self, App.onRestart    )
    Events.bind("slide.left",    self, App.showDevPanel )
    Events.bind("slide.right",   self, App.hideDevPanel )
    Events.bind("app.menu",      self, App.onMenu       )
end

function App:onTick()
    App.tickNum = App.tickNum + 1
    self.ui:onTick()
    if self.inMenuMode then
        self:runStageEvery(1)
    else
        self.scheme:onTick() 
        self.stage:onTick()
    end
    self:updateFps()
end

function App:onInit()
    self.fpsCounter  = FrameRateC(60)  
    self:saveProjectMetadata(description,author,since,version)
    self:loadRecentGame()
    self:restoreUI()
end

function App:onClose()
    self:saveData()
    close()
end

function App:onRestart()
    self:loadGame(self.scheme.game.name, self.scheme.location.name)
end

function App:onMenu()
    self:loadMenu()
end

function App:onTouch(t)
    self.ui:onTouch(t)
    if self.ui.continueTouchProc then
        self.stage:onTouch(t)
    else
        self.stage:clearTouch()
    end
end

function App:onDraw()
    self.stage:onDraw()
    self.ui:onDraw()
    self:drawFps()
end

-- dev panel --

function App:showDevPanel()
    displayMode(OVERLAY)
end

function App:hideDevPanel()
    displayMode(FULLSCREEN_NO_BUTTONS)
end

-- info --

function App.getTicks()
    return App.tickNum
end

function App:updateFps()
    self.fpsCounter:calc()
    local fps = self.fpsCounter.getAverageFrameRate()
    self.fps = string.format("fps:%3d", fps)
end

-- data --

function App:saveData()
    saveProjectData("recent.game",     self.scheme.game.name)
    saveProjectData("recent.location", self.scheme.location.name)
    saveProjectData("ui.watch",        self.ui.watchPanel.show)
end

function App:loadData()
    self.recent.game     = readProjectData("recent.game")     or nil
    self.recent.location = readProjectData("recent.location") or nil
    self.recent.watch    = readProjectData("ui.watch")        or false
end

function App:saveProjectMetadata(description,author,since,version)
    saveProjectInfo("Description", description)
    saveProjectInfo("Author",      author)
    saveProjectInfo("Since",       since)
    saveProjectInfo("Version",     version)
end

-- parameters --

function App:initParameters()
    parameter.action("Hide",         function() self:hideDevPanel();        end)
    parameter.action("Clear",        function() output.clear();             end)
    parameter.action("Print",        function() self.stage:onPrint();       end)
    parameter.action("Print deeply", function() self.stage:onPrintDeeply(); end)
    parameter.action("Print log",    function() self.stage:onPrintLog();    end)
end

-- ui --

function App:restoreUI()
    if self.recent.watch then
        Events.trigger("ui.watch.show")
    end
end

-- pack --

Pack.App.Kinds = {
    MenuItems = {
        kind       = "Essences",
        moveRange  = 0,
        sightRange = 0,
        refLevel   = 1,
    },
    SubmenuItems = {
        kind       = "MenuItems",
        imaginary  = true,
        visible    = false,
        refLevel   = 0,
    },
    Exits = {
        kind       = "MenuItems",
        size       = 20,
        moveRange  = 25,
        sightRange = 27,
        colour     = color(69, 51, 28, 227),
    },
    ExitConfirms = {
        kind       = "SubmenuItems",
        size       = 15,
        colour     = color(244, 255, 0, 255),
    },
    Infos = {
        kind       = "MenuItems",
        size       = 20,
        sightRange = 70,
        moveRange  = 30,
        colour     = color(70, 81, 135, 183),
    },
    InfoArticles = {
        kind       = "SubmenuItems",
        size       = 15,
        colour     = color(79, 88, 138, 188),
    },
    InfoAbouts = {
        kind       = "InfoArticles",
    },
    InfoControls = {
        kind       = "InfoArticles",
    },
    Games = {
        kind       = "MenuItems",
        size       = 20,
        sightRange = 40,
        moveRange  = 30,
        colour     = color(147, 130, 32, 133),
    },
    Locations = {
        kind       = "SubmenuItems",
        size       = 15,
        colour     = color(30, 69, 30, 231),
    },
}
Pack.Common.Kinds.InsertTo(Pack.App.Kinds)

local bad     = Const.Lawbook.Collision.Bad
local good    = Const.Lawbook.Collision.Good
local none    = Const.Lawbook.Collision.None

local like     = Const.Lawbook.Attitude.Like
local dislike  = Const.Lawbook.Attitude.Dislike
local ignore   = Const.Lawbook.Attitude.Ignore

Pack.App.Lawbook = {
    Attitudes = {
        Games = { Games = {dislike}, Locations={like} },
        Exits = { ExitConfirms = {like}, Games = {dislike} },
    }
}

App.InfoX,App.InfoY = 100,140
App.ExitX,App.ExitY = 140,140
App.GameX,App.GameY = 100,100

Pack.App.Locations = {
    Menu = {
        Description = "Get information or select game to play",
        Disposition = {
            ["Info"] = {x=App.InfoX,y=App.InfoY,kind="Infos", imagination={
                    About   = {x=App.InfoX-8,y=App.InfoY+12,kind="InfoAbouts"},
                    Control = {x=App.InfoX+8,y=App.InfoY+12,kind="InfoControls"},
                },
            },
            ["Exit"] = {x=App.ExitX,y=App.ExitY,kind="Exits", imagination={
                    Yes = {x=App.ExitX,y=App.ExitY-15,kind="ExitConfirms"},
                },
            },
        },
    },
}

-- pack proc --

function App:loadMenu()
    local g = self.scheme.game.name
    local l = self.scheme.location.name
    self:loadGame("App", "Menu")
    self.stage:setViewByName(g)    
    self.stage:setFocusByName(l)
    if g~="App" then
        self:restoreStageCoords()
    end
end

function App:preparePackApp()
    self:addGamesToPackApp()
    self:setPackEvents()
end

function App:setPackEvents()
    Pack.App.Kinds.Locations.app        = self
    Pack.App.Kinds.InfoAbouts.onFocus   = App.doPackInfoAbout
    Pack.App.Kinds.InfoControls.onFocus = App.doPackInfoControl
    Pack.App.Kinds.ExitConfirms.onFocus = App.doPackExit
    Pack.App.Kinds.Locations.onFocus    = App.doPackGameLocation
end

function sortPack(t,a,b)
    -- !!! Todo
do return a<b end
    
    if t == nil then return false end
    if t[a]==nil and t[b]==nil then return false  end
    if t[a]==nil or t[a].n==nil then return true  end
    if t[b]==nil or t[b].n==nil then return false end
    return t[a].n<t[b].n
end

function App:isPackValid(g,l)
    return g and l and Pack[g] and Pack[g].Locations[l]
end

function App:getPackDisposition()
    return Pack.App.Locations.Menu.Disposition
end

-- pack menu commands --

function App.doPackGameLocation(l)
    local app = Pack.App.Kinds.Locations.app
    app:saveStageCoords()
    app:loadGame(l.host.name,l.name)
end

function App.doPackInfoAbout()
    local app = Pack.App.Kinds.Locations.app
    app.ui:showInfoPanel(App.Info.About)
end

function App.doPackInfoControl()
    local app = Pack.App.Kinds.Locations.app
    app.ui:showInfoPanel(App.Info.Control)
end

function App.doPackExit()
    local app = Pack.App.Kinds.Locations.app
    app:onClose()
end

-- pack games --

function App:addGamesToPackApp()
    local gx,gdx = App.GameX, 40
    local gy,gdy = App.GameY,  0
    local x,y    = gx, gy
    for gamename, game in spairs(Pack,sortPack) do
        if game.IsGame then 
            game.name = gamename
            game.x    = x
            game.y    = y
            self:addGameToPackAppLocations(game)
            x = x + gdx
            y = y + gdy
        end
    end
end

function App:addGameToPackAppLocations(g)
    local disp = self:getPackDisposition()
    disp[g.name]={
        x=g.x,y=g.y,kind="Games", imagination = self:creatPackAppGameImagination(g)
    }
end

function App:creatPackAppGameImagination(g)
    local img = {}
    local locs = self:creatPackAppGameLocations(g)
    for k,v in pairs(locs) do img[k]=v end
    return img
end

function App:creatPackAppGameLocations(g)
    local lx,ldx = g.x-18,  0
    local ly,ldy = g.y,   -15
    local x,y    = lx, ly
    local locations = {}
    for locname,loc in spairs(Pack[g.name].Locations, sortPack) do
        loc.name = locname
        loc.x    = x
        loc.y    = y
        locations[locname]={x=loc.x,y=loc.y,kind="Locations"}
        x = x + ldx 
        y = y + ldy
    end
    return locations
end

-- game --

function App:loadGame(g,l)
    if not self:isPackValid(g,l) then 
        g,l = "App", "Menu" 
    end
    self.scheme:init(g,l)
    self.stage:init (self.scheme, self.topHight-1, self.bottomHight-1)
    self.scheme:popupLocationInfo()
    self.inMenuMode = (g == "App" and l == "Menu")
    self.stage:onGameLoaded()
end

function App:loadRecentGame()
    self:loadGame(self.recent.game, self.recent.location)
end
    
-- stage --

function App:runStageEvery(interval)
    if not self.prevStageRunTime or os.clock()-self.prevStageRunTime > interval then
        self.stage:runSchemeInView()
        self.prevStageRunTime = os.clock()
    end
end

function App:saveStageCoords()
    self.stageCoords = {
        ox    = self.stage.canvas.ox,
        oy    = self.stage.canvas.oy,
        scale = self.stage.canvas.scale, 
    }
end

function App:restoreStageCoords()
    if not self.stageCoords then return end
    self.stage.canvas:setOffset(self.stageCoords.ox, self.stageCoords.oy)
    self.stage.canvas:setScale (self.stageCoords.scale)
end

-- draw --

function App:draw()
    self:onTick()
    self:onDraw()
end

function App:drawFps()
    local fs = 12
    fontSize(fs)
    fill(255, 255, 0, 76)
    font(Panel.Font)
    textAlign(LEFT)
    text(self.fps, fs*2, self.bottomHight+fs/2)
end

-- eof --




























--# UI
-- ui.lua
-- Papa's game studio (c) 2014

UI = class()

-- config --

UI.Font = "Inconsolata"
UI.Animation = {}
UI.Animation.Popup = {}
UI.Animation.Popup.Show = 5
UI.Animation.Popup.Fade = 1

-- init --

function UI:init(stage, top, bottom)
    local right = 250
    self.stage = stage
    self:createPanels(top, bottom, right)
    self:bindEvents()
end

-- events --

function UI:bindEvents()
    Events.bind("ui.popup",      self, UI.onPopup     )
    Events.bind("ui.watch.show", self, UI.onWatchShow )
    Events.bind("ui.watch.obj",  self, UI.onWatchObj  )
end

function UI:onTick()
end

function UI:onTouch(t)
    self:hidePopupPanelOnTouch(t)
    self.continueTouchProc = self.panels:onTouch(t.x,t.y,t.state,t.id)
end

function UI:onPopup(msg)
    self:showPopupPanel(msg)
end

function UI:onWatchShow()
    self:showWatchPanel()
end

function UI:onWatchObj(obj,method)
    self:setWatchObj(obj,method)
end

function UI:onDraw()
    self.panels:onDraw()
end

-- panels -- 

function UI:createPanels(top, bottom, right)
    self.panels = Panel(0, 0, WIDTH, HEIGHT,grey(0,0),"root")
    self.panels:insert(self:createTopPanel(top))
    self.panels:insert(self:createBottomPanel(bottom))
    self.panels:insert(self:createWatchPanel(self.panels,top,bottom,right))
    self.panels:insert(self:createInfoPanel(self.panels,top,bottom))
    self.panels:insert(self:createPopupPanel(self.panels,top,bottom))
end

-- stack -- 

function UI:createTopPanel(height)
    self.topPanel = Panel(0, HEIGHT-height, WIDTH, height, nil, "top")
    self.topPanel:insert(self:createStackPanel(self.topPanel))
    return self.topPanel
end

function UI:createStackPanel(p)
    local fclr      = color(28, 29, 55, 255)
    local fs        = p.h/2.2
    self.stackPanel = Button(0, 0, p.w, p.h, "", fclr, nil, "stack")
    self.stackPanel:setDraw(function(p)
       p:fill ()
       p:text (self:getStackText(), fs, LEFT)
    end)
    self.stackPanel:setAction(function() 
        if not self.showPopup then
            self.stage.scheme:popupLocationInfo()
        end
    end)
    return self.stackPanel
end

function UI:getStackText()
    local t = ""
    local r = ""
    local n = 100
    local i = 0
    if not self.stage then return "UI:getStackText()" end
    for i = 1,n,1 do
        t = self.stage:getStackInfo(i) or ""
        if t=="" then
            i=n+1
        elseif i > 1 then
            r = r.." | "
        end
        r = r..t
    end
    if (self.stage.inExploreMode) then r=r.." | ..." end
    return r
end

-- info panel --

function UI:createInfoPanel(p,top,bottom)
    local w,y  = p.w, bottom-1
    local x    = 0
    local h    = p.h-top-bottom+2
    local fclr = color(148, 134, 107, 223)
    local tclr = color(27, 23, 18, 249)
    local fs   = 22
    self.infoPanel = Button(x,y,w,h,"", fclr, nil, "info")
    self.infoPanel:setUpdate(function(p) 
        p.v = self.infoPanel.show
    end)   
    self.infoPanel:setDraw(function(p) 
        p:fill()
        p:text(self.infoPanel.txt, fs, CENTER, tclr)
    end)
    self.infoPanel:setAction(function() 
        self:hideInfoPanel()
    end)
    return self.infoPanel
end

function UI:hideInfoPanel()
    self.infoPanel.show    = false
end

function UI:showInfoPanel(txt)
    self.infoPanel.txt    = txt or ""
    self.infoPanel.show   = true
end

-- watch panel --

function UI:setWatchObj(obj,method)
    self.watchPanel.wobj    = obj
    self.watchPanel.wmethod = method
end

function UI:watchMethod(plotter,w,h)
    local fs = plotter:fontSize()
    plotter:text("UI:watchMethod", fs,h-2*fs)
end

function UI:createWatchPanel(p,top,bottom,width)
    local w,y  = width, bottom-1
    local x    = p.w-w
    local h    = p.h-top-bottom+2
    local fclr = color(28, 28, 28, 138)
    local tclr = color(37, 127, 33, 249)
    local fs   = 20
    self.watchPanel         = Button(x,y,w,h,"",fclr, nil, "watch")
    self.watchPanel.X       = x
    self:setWatchObj(self,UI.watchMethod)
    self.watchPanel:setUpdate(function(p) 
        p.v = self.watchPanel.show
    end)   
    self.watchPanel:setDraw(function(p)
        local plotter = p:getPlotter()
        p:fill          ()
        plotter:font    (UI.Font)
        plotter:fontSize(fs)
        plotter:fill    (tclr)
        plotter:textMode(CORNER)
        p.wmethod       (p.wobj,plotter,p.w,p.h)
    end)
    self.watchPanel:setAction(function() 
       self:hideWatchPanel()
    end)
    return self.watchPanel
end

function UI:showWatchPanel()
    if self.watchPanel.inAnimation then return end
    if self.watchPanel.show        then return end
    self.watchPanel.x           = WIDTH 
    self.watchPanel.show        = true
    self.watchPanel.inAnimation = true
    tween(0.25, self.watchPanel, 
        { x = self.watchPanel.X }, 
        tween.easing.quadInOut,
        function(ui) 
            ui.watchPanel.inAnimation = false
        end,
    self)
    Events.trigger("sys.watch",true)
end

function UI:hideWatchPanel()
    if self.watchPanel.inAnimation then return end
    self.watchPanel.inAnimation = true
    tween(0.25, self.watchPanel, 
        { x = WIDTH+1 }, 
        tween.easing.linear,
        function(ui) 
            ui.watchPanel.inAnimation = false
            ui.watchPanel.show        = false
        end,
    self)
    Events.trigger("sys.watch",false)
end

-- popup panel --

function UI:createPopupPanel(p,top,bottom)
    local w,h = p.w,top
    local fs  = h/2
    local x   = (p.w-w)/2
    local y   = p.h-h-top+1
    local fclr = color(100, 99, 66, 198)
    self.popupPanel = Panel(x,y,w,h,fclr, nil, "popup")
    self.popupPanel:setUpdate(function(p)
        p.v = self.showPopup and not self.showInfo
        p.o = self.popupOpaque
    end)   
    self.popupPanel:setDraw(function(p)
        p:fill()
        p:text(self.popupText)
    end)   
    return self.popupPanel
end

function UI:showPopupPanel(msg)
    self.showPopup   = true
    self.popupText   = msg
    self.popupOpaque = 0
    if self.popupTween then tween.stop(self.popupTween) end
    self.popupTween  = tween.sequence(
        tween(UI.Animation.Popup.Fade/2, self,
            {popupOpaque=1},
            tween.easing.quintIn),
        tween(UI.Animation.Popup.Show, self, {popupOpaque=1}),
        tween(UI.Animation.Popup.Fade, self,
            {popupOpaque=0},
            tween.easing.quintIn, 
            function(ui) ui.showPopup = false end, 
        self)
    )
end

function UI:hidePopupPanel()
    if self.popupTween then tween.stop(self.popupTween) end
    tween.stop(self.popupTween)
    self.popupTween = tween(UI.Animation.Popup.Fade/4, self,
        {popupOpaque=0},
        tween.easing.linear,
        function(ui) ui.showPopup = false end,
    self)
end

function UI:hidePopupPanelOnTouch(t)
    if t.state == BEGAN and self.showPopup then 
        self:hidePopupPanel() 
    end
end

-- buttons --

function UI:createBottomPanel(height)
    local pc = color(24, 24, 24, 255)
    local bc = color(39, 39, 39, 255)
    local tc = color(109, 109, 109, 255)    
    self.bottomPanel = Panel(0, 0, WIDTH, height, pc, "bottom")
    local w,W,b = height*1.2,height*1.5,height/18
    local x,X = b,1000
    local btn,run,exp,inf
    btn,x=self:insertBottomButton(x,w,b,height,bc,tc, "?",  "app.close")
    btn,x=self:insertBottomButton(x,w,b,height,bc,tc, "?",  "app.restart")
    btn,x=self:insertBottomButton(x,w,b,height,bc,tc, "?",  "app.menu")
    run,x=self:insertBottomButton(X,w,b,height,bc,tc, "Go",  "scheme.run",        true)
    imp,x=self:insertBottomButton(x,w,b,height,bc,tc, "?",  "stage.implant.new", true)
    imp:setUpdate(function(b) 
        b.isChecked = self.stage.inImplantMode     
        b.isEnabled = not App.TheApp.inMenuMode
    end)
    run:setUpdate(function(b) 
        b.isEnabled = not self.stage.inExploreMode 
        and not App.TheApp.inMenuMode
    end)
    return self.bottomPanel
end

function UI:insertBottomButton(x,w,b,ph,bc,tc,name,event,rev,...)
    local y,w,h = b, w, ph-2*b-2
    local args = {...}
    local btn
    x = math.min(x,WIDTH-w-b)
    btn = Button(x,y,w,h, name, bc, tc)
    btn:setAction(function() Events.trigger(event,unpack(args)) end)
    self.bottomPanel:insert(btn)
    x = (rev and (x - btn.w - b) or (x + btn.w + b))
    return btn,x
end

-- geometry --

function UI:preparePanelElemCoords(p,i,n,b)
    local offx = ((p.w-b-1)/n)*(i-1)
    local x = offx + b
    local y = b
    local w = (p.w-b-1)/n - b+1
    local h = p.h - 2*b
    return x,y,w,h
end

-- eof --




























--# Stage
-- stage.lua
-- Papa's game studio (c) 2014

Stage = class()

-- config --

Stage.Animation = {}
Stage.Animation.Miseenscene = 1
Stage.BackgroundColor = color(31, 83, 36, 255)

-- init --

function Stage:init(scheme, tSpace, bSpace)
    self.canvas              = Canvas(self,0,bSpace,WIDTH,HEIGHT-tSpace-bSpace)
    self.scheme              = scheme
    self.actors              = {}   
    self.canvas.onTap        = Stage.onTap
    self.canvas.onLongTap    = Stage.onLongTap
    self.canvas.onSlidingBeg = Stage.onSlidingBeg
    self.focusName           = ""
    self.inExploreMode       = false
    self.inImplantMode       = false
    self.world               = scheme.world
    self.view                = scheme.world
    self:bindEvents           ()
    self:playScene            () 
    self:setInitialPerspective()
end

function Stage:setInitialPerspective()
    local c = self.scheme.location.center
    if c.scale then
        self.canvas:setOffset(-c.x,-c.y,0)
        self.canvas:setScale (c.scale,0)
    else
        self:fitMiseenscene (0)
    end
end 
    
-- events --

function Stage:bindEvents()
    Events.bind("stage.implant.new",  self, Stage.onImplantMode)
    Events.bind("scheme.run",         self, Stage.onRunScheme)
    Events.bind("stage.fit",          self, Stage.onFit)
    Events.bind("stage.explore.mode", self, Stage.onExploreMode)
    Events.bind("sys.watch",          self, Stage.onWatch)
end

function Stage:onTap(x,y)
    if self.inImplantMode then
        self:tapInImplantMode(x,y)
    elseif self.inExploreMode then
        self:tapInExploreMode(x,y)
    else 
        self:tapInStandartMode(x,y)
    end
end

function Stage:onLongTap(x,y)
    if self.inImplantMode then
    elseif self.inExploreMode then
        self:longTapInExploreMode(x,y)
    else 
        self:longTapInStandartMode(x,y)
    end
end

function Stage:onSlidingBeg(side,x,y)
    if side==Toucher.Side.Left then
        Events.trigger("slide.left")
    elseif side==Toucher.Side.Right then
        Events.trigger("ui.watch.show")
    end
end

function Stage:onTouch(t)
    self.canvas:onTouch(t)
end

function Stage:onTick()
    self:updateEnableExploreMode()
    self.canvas:onTick()
end

function Stage:onRunScheme()
    self:runScheme()
end

function Stage:onExploreMode()
    if not self.inExploreMode then
        self:setExploreModeOn()
    else
        self:setExploreModeOff()
    end
end

function Stage:onDraw()
    self:draw()
end

function Stage:onGameLoaded()
    Events.trigger("ui.watch.obj",self,Stage.watchMethod)
end

function Stage:onWatch(flag)
    self.inWatchMode = flag
end

function Stage:onFit()
    self:fitMiseenscene()
end

function Stage:onPrint()
    self.view:print(1,0)
end

function Stage:onPrintDeeply()
    self.view:print(100,0)
end

function Stage:onPrintLog()
    self.view:printLog()
end

function Stage:onImplantMode()
    if not self.inImplantMode then
        self:setImplantModeOn()
    else
        self:setImplantModeOff()
    end
end

-- touch --

function Stage:clearTouch()
    self.canvas:clearTouch()
end

-- run --

function Stage:runScheme(world)
    if self.inExploreMode then return end
    self.scheme:run(world)
    if self:viewPresentsInWorld() then
        self:playScene ()
    else
        self:setView(self:getWorld())
    end
end

function Stage:runSchemeInView()
    self:runScheme(self:getView())
end

-- standart mode --
    
function Stage:longTapInStandartMode(x,y)
    local actor = self:findActorInScreen(x,y)
    if actor and not actor.person.onTap then
        self:longTapOnActorInStandartMode(actor)
    else
        self:longTapOnSpaceInStandartMode(x,y)
    end
end

function Stage:tapInStandartMode(x,y)
    local actor = self:findActorInScreen(x,y)
    if actor then
        self:tapOnActorInStandartMode(actor)
    elseif self.canvas:contains(x,y) then
        self:tapOnSpaceInStandartMode()
    end
end
    
function Stage:tapOnSpaceInStandartMode()
    if self:hasFocus() then
        self:setView (self:getWorld())
        self:setFocus(nil)
    end
end

function Stage:tapOnActorInStandartMode(actor)
    if not actor.inFocus then
        self:setFocus(actor)
        self:setViewAccountingFocus(actor)
        actor:onFocus()
    elseif actor.onTap then
        actor:onTap()
    end
end

function Stage:longTapOnActorInStandartMode(actor)
    if not actor.inFocus then
        self:setFocus(actor)
        self:setView (self:getWorld():presentSubperson(actor.person))
        actor:onFocus()
    end
    self:setExploreModeOn()
end

function Stage:longTapOnSpaceInStandartMode(x,y)
    self:tapInImplantMode(x,y,true)
end

-- implant mode --
    
function Stage:tapInImplantMode(x,y,longTap)
    if longTap then
        y = y + 30
    end
    x,y = self:toWorld(x,y)
    self:implantNewTo(self.view,"Orders", x,y)
    self:setImplantModeOff()
end

function Stage:setImplantModeOn()
    self.inImplantMode = true
end

function Stage:setImplantModeOff()
    self.inImplantMode = false
end

function Stage:implantNewTo(subj,kind,x,y)
    local secret = self.view ~= self.world
    self.scheme:implantNewTo(subj,kind,x,y,secret)
    self:playScene ()
end

-- explore mode --
    
function Stage:tapInExploreMode(x,y)
    local actor = self:findActorInScreen(x,y)
    if actor then
        self:tapOnActorInExploreMode(actor)
    elseif self.canvas:contains(x,y) then
        self:tapOnSpaceInExploreMode()
    end
end
    
function Stage:longTapInExploreMode(x,y)
    local actor = self:findActorInScreen(x,y)
    if not actor then
        self:longTapOnSpaceInExploreMode(x,y)
    end
end

function Stage:tapOnSpaceInExploreMode()
    if self.world.host then
        if self:getFocus().person == self:getWorld() then
           self:setWorld(self:getWorld().host)
        end
        self:setFocus(self:findActorByPerson(self:getView()))
    end
    if not self.world.host then
        self:setExploreModeOff()
    end
end
    
function Stage:tapOnActorInExploreMode(actor)
    if actor.person.refLevel > 0 then
        self:setFocus(actor)
        self:setWorld(actor.person)
    else
        self:setFocus(actor)
    end
end

function Stage:setExploreModeOn()
    self:updateEnableExploreMode()
    if not self.enableExploreMode then return end
    self.inExploreMode = true
    self:setWorld(self.view)
end

function Stage:setExploreModeOff()
    self.inExploreMode = false
    self:setWorld(self.scheme.world)
end

function Stage:updateEnableExploreMode()
    self.enableExploreMode = self:getFocus() and self:getFocus().refLevel > 0
end

function Stage:longTapOnSpaceInExploreMode(x,y)
    self:tapInImplantMode(x,y,true)
end

-- world --

function Stage:setWorld(world)
    if world == nil        then return end
    if world.refLevel == 0 then return end
    self.world = world
    self:setView(world)
end

function Stage:getWorld()
    return self.world
end

-- view --

function Stage:getView()
    return self.view
end

function Stage:setView(view)
    if view == self.view                     then return end
    if not self.view:isPersonReflexive(view) then return end    
    local prevView = self.view
    self.view      = view
    self:playNewScene (prevView:presentSubpersons(), view:presentSubpersons())
end

function Stage:setViewByName(name)
    local actor  = self:findActorByName(name)
    local person = actor and actor.person or nil
    self:setView(person)
end

function Stage:viewPresent()
    return self:getView():presentSubpersons()
end

function Stage:viewPast()
    return self:getView():pastSubpersons()
end

function Stage:viewPresentsInWorld()
    return self.world:is(self.view) or self.world:presentSubperson(self.view)
end

-- focus --

function Stage:getFocus()
    for _,a in pairs(self.actors) do if a.inFocus then return a end end
    return nil
end

function Stage:hasFocus()
    return self:getFocus()~=nil
end

function Stage:setFocus(actor)
    for _,a in pairs(self.actors) do a.inFocus=false end
    if actor then 
        actor.inFocus  = true 
        self.focusName = actor.name
        Events.trigger("ui.watch.obj",actor,Actor.watchMethod)
    else
        self.focusName = ""
        Events.trigger("ui.watch.obj",self,Stage.watchMethod)
    end
end

function Stage:setFocusByName(name)
    local actor  = self:findActorByName(name)
    self:setFocus(actor)
end

function Stage:restoreFocus()
    for _,a in pairs(self.actors) do
        if a.name==self.focusName then
            self:setFocus(a)
        end
    end
end

function Stage:setViewAccountingFocus(actor)
    if actor.imaginary then
        self:setView(self:getWorld():presentSubperson(actor.person))
    elseif actor.refLevel > 0 then
        self:setView(self:getWorld():presentSubperson(actor.person))
        actor:adjustPerson(self:getView())
    else
        self:setView(self:getWorld())
        actor:adjustPerson(self:getView():presentSubperson(actor.person))
        if actor.refLevel > 0 then
            self:setView(self:getWorld():presentSubperson(actor.person))
       end
    end
end

-- actors --

function Stage:createActors(situation)
    local actors={}
    for _,subj in pairs(situation) do
        table.insert(actors,Actor(subj,self,self.canvas.plotter))
    end
    return actors
end

function Stage:createGhostActors(past)
    local actors={}
    for _,subj in pairs(past) do
        local a = Actor(subj,self,self.canvas.plotter)
        a.isVisible = false
        a.isSupposed = false
        table.insert(actors,a)
    end
    return actors
end

function Stage:findActorByPerson(subj)
    for _,a in pairs(self.actors) do
        if a.person==subj then
            return a
        end
    end
    return nil
end

function Stage:findActorByName(name)
    for _,a in pairs(self.actors) do
        if a.person.name==name then
            return a
        end
    end
    return nil
end

-- animation --

function Stage:playNewScene(prev,new)
    self.retirees   = self.actors or {}
    self.actors     = self:createActors      (new)
    self.ghosts     = self:createGhostActors (prev)
    self:startAnimation(true)
    self:restoreFocus  ()
end

function Stage:playScene()
    self.retirees   = self.actors or {}
    self.actors     = self:createActors      (self:viewPresent())
    self.ghosts     = self:createGhostActors (self:viewPast   ())
    self:startAnimation()
    self:restoreFocus  ()
end

function Stage:startAnimation(isNewScene)
    local retirees   = table.index(self.retirees, "name")
    local presents   = table.index(self.actors,   "name")
    local pasts      = table.index(self.ghosts,   "name")
    self:startAnimationMotion       (retirees)
    self:startAnimationAppiarence   (retirees, isNewScene)
    self:startAnimationDisappiarence(pasts, presents, isNewScene)
end

function Stage:startAnimationMotion(retirees)
    for _,a in pairs(self.actors) do
        if retirees[a.name] then
            a:animateMovingFrom(retirees[a.name])
        end
    end
end

function Stage:startAnimationAppiarence(retirees,isNewScene)
    for _,a in pairs(self.actors) do
        if not retirees[a.name] then
            if isNewScene then
                a:animateEmergence()
            else
                a:animateAppiarence()
            end
        end
    end
end

function Stage:startAnimationDisappiarence(pasts,presents,isNewScene)
    for _,r in pairs(self.retirees) do
        if pasts[r.name] and not presents[r.name] then
            if isNewScene then
                pasts[r.name]:animateFading()
            else
                pasts[r.name]:animateDisapiarenceInMotion(r)
            end
        end
    end
end

-- stack --

function Stage:getStack()
    local stack = {}
    local subj = self.world
    while subj~= nil do
        table.insert(stack,1,subj)
        subj = subj.host
    end
    if self.view:isNot(self.world) then
        table.insert(stack,self.view)
    end
    return stack
end

function Stage:getStackInfo(i)
    local stack = self:getStack()
    local info  = nil
    if i > #stack then return nil end
    return stack[i].name
end

-- watch --

function Stage:watchMethod(plotter,w,h)
    local fs   = plotter:fontSize()
    local p    = self.view
    local info = p:fullName().."\n"..textline(23)
    info = self:addWatch(info,"kind:     ", p.kind)
    info = self:addWatch(info,"reflevel: ", p.refLevel)
    local tw,th = plotter:textSize(info)
    plotter:text(info, fs/2, h-fs/2-th)
end

function Stage:addWatch(info,key,val)
    val = tostring(val)
    return info.."\n"..key..(val=="" and "-" or val)
end

-- draw --

function Stage:draw()
    self.canvas:open()
        self:drawBackground()
        self:drawGrid()
        self:drawActors()
    self.canvas:close()
end

function Stage:drawActors()
    for _,fun in ipairs(Actor.Draw.Algorithm) do
        for _,a in pairs(self.actors) do if a.isVisible then
            Actor[fun](a) 
        end end
    end
    for _,g in pairs(self.ghosts) do  
        g:draw () 
    end
end

function Stage:drawBackground()
    self.canvas:draw(self:getBackgroundColor())
end

function Stage:getBackgroundColor()
    local bgr = self.scheme.backgroundColor or Stage.BackgroundColor
    return self.inExploreMode and greyBlend(0,100,bgr) or bgr 
end

function Stage:drawGrid()
    local minx,miny,maxx,maxy = -1000,-1000,1000,1000
    self.canvas.plotter:stroke(grey(20,20))
    self.canvas.plotter:strokeWidth(0.6)
    for x=minx, maxx, 100 do self.canvas.plotter:line(x,miny,x,maxy) end
    for y=miny, maxy, 100 do self.canvas.plotter:line(minx,y,maxx,y) end
end

-- geometry --

function Stage:toWorld(x,y)
    return self.canvas:wX(x), self.canvas:wY(y)
end

function Stage:findActorInScreen(x,y)
    return self:findActorInScheme(self.canvas:wX(x), self.canvas:wY(y))
end

function Stage:findActorInScheme(x,y)
    for _,a in pairs(self.actors) do
        if a:contains(x,y) then return a end
    end
    return nil
end

function Stage:fitMiseenscene(animationTime)
    local left, top, right, bottom
    local maxScale = 7
    animationTime = animationTime or Stage.Animation.Miseenscene
    for _,a in pairs(self.actors) do
        local l,t,r,b = a:getBounds()
        left   = math.min(l, (left   or l))
        top    = math.max(t, (top    or t))
        right  = math.max(r, (right  or r))
        bottom = math.min(b, (bottom or b))
    end
    if #self.actors>0 then
        self.canvas:fitRect(left, bottom, right-left, top-bottom, animationTime, maxScale)
    end
end

-- info --

function Stage:getDescription()
    return self.scheme:getDescription()
end

-- eof --




























--# Scheme
-- scheme.lua
-- Papa's game studio (c) 2014

Scheme = class()

-- init --

function Scheme:init(gamename, locname)
    self:loadGame   (gamename, locname)
    self:createWorld()
    self:createImaginations(self.world)
    self.world:think()
    Test.Rational.Run.Deep(self.world)
end

-- world --

function Scheme:createWorld()
    self.world = Rational({
        scheme      = self,
        host        = nil,
        tag         = "w",
        name        = self.game.name..":".. self.location.name,
        kind        = "Universe",
        depth       = 0,
        x           = 0,
        y           = 0,
        radius      = 10,
        refLevel    = 100,
        sightRange  = math.huge,
        moveRange   = 0,
        imaginary   = true,
        visible     = false,
        secret      = false,
        tactics     = {},
    })
    self.world:explore(self.location.layout)  
end

-- events --

function Scheme:onTick()
    local d = os.clock()-(self.prevThinkTime or 0)
    local t = 0.5
    if d >= t then
        self.world:think()
        self.prevThinkTime = os.clock()
        debug.preventMemoryCrash()
    end
end

-- control --

function Scheme:run(world)
    local world = world or self.world
    world:run()
    self.stepnum = self.stepnum + 1
    Test.Rational.Run.Deep(world)
end

-- game --

function Scheme:loadGame(gamename, locname)
    self.stepnum          = 1
    self.pack             = Pack[gamename]
    self.game             = {}
    self.game.name        = gamename
    self.law              = {}
    self.game.description = self.pack.Description        or ""
    self.pack.Lawbook     = self.pack.Lawbook            or {}
    self.pack.Locations   = self.pack.Locations          or {}
    self.pack.Persons     = self.pack.Persons            or {}
    self.kinds            = self.pack.Kinds              or {}
    self.law.collision    = self.pack.Lawbook.Collisions or {}
    self.law.attitude     = self.pack.Lawbook.Attitudes  or {}
    self:loadLocation(locname or self:defaultLocation())
end

-- location --

function Scheme:defaultLocation()
    for name in pairs(self.pack.Locations) do
        return name
    end
    return nil
end

function Scheme:loadLocation(loc)
    self.location               = {}
    self.location.name          = loc or "<noname>"
    self.location.disposition   = loc and self.pack.Locations[loc].Disposition   or {}
    self.location.description   = loc and self.pack.Locations[loc].Description   or ""
    self.location.center        = loc and self.pack.Locations[loc].Center        or {}
    self.location.background    = loc and self.pack.Locations[loc].Background    or nil
    self.location.layout        = {}
    self:createLocationLayout ()
    self:obtainBackgroundColor()
end

function Scheme:obtainBackgroundColor()
    local bgr = self.location.background or self.pack.Background or Pack.Background
    self.backgroundColor = bgr
end 

function Scheme:popupLocationInfo()
    Events.trigger("ui.popup", self.location.description)
end

function Scheme:createLocationLayout()
    for name,coords in pairs(self.location.disposition) do
        coords.name = name
        table.insert(self.location.layout, self:createLayoutItem(coords))
    end
end

-- items --

function Scheme:createLayoutItem(coords)
    local item      = {}
    local info      = self.pack.Persons[coords.name] or {}
    item.scheme     = self
    info.coords     = coords
    item.name       = coords.name
    info.name       = coords.name
    self:obtainItemAllInfo(item,info)
    return item
end

function Scheme:createKindItem(kind,x,y,name)
    __itemnum       = __itemnum and __itemnum+1 or 1
    local coords    = {x=x, y=y, kind=kind}
    coords.name     = name or kind.."."..tostring(__itemnum)
    return self:createLayoutItem(coords)
end

function Scheme:obtainItemAllInfo(item,info)
    item.x           = self:obtainItemInfo( info, "x"          , nil      )
    item.y           = self:obtainItemInfo( info, "y"          , nil      )
    item.kind        = self:obtainItemInfo( info, "kind"       , nil      )
    item.size        = self:obtainItemInfo( info, "size"       , 6        )
    item.comfortDist = self:obtainItemInfo( info, "comfortDist", 0        )
    item.visible     = self:obtainItemInfo( info, "visible"    , true     )
    item.imaginary   = self:obtainItemInfo( info, "imaginary"  , true     )
    item.secret      = self:obtainItemInfo( info, "secret"     , false    )
    item.suggested   = self:obtainItemInfo( info, "suggested"  , false    )
    item.impassable  = self:obtainItemInfo( info, "impassable" , false    )
    item.opaque      = self:obtainItemInfo( info, "opaque"     , false    )
    item.colour      = self:obtainItemInfo( info, "colour"     , grey(96) )
    item.moveRange   = self:obtainItemInfo( info, "moveRange"  , 0        )
    item.sightRange  = self:obtainItemInfo( info, "sightRange" , 0        )
    item.refLevel    = self:obtainItemInfo( info, "refLevel"   , 0        )
    item.tactics     = self:obtainItemInfo( info, "tactics"    , {}       )  
    item.imagination = self:obtainItemInfo( info, "imagination", {}       )  
    item.onTap       = self:obtainItemInfo( info, "onTap"      , nil, true)  
    item.onFocus     = self:obtainItemInfo( info, "onFocus"    , nil, true)  
    item.showName    = self:obtainItemInfo( info, "drawName"   , 0        )  
    item.showEyes    = self:obtainItemInfo( info, "drawEyes"   , 0        )  
    item.showMouth   = self:obtainItemInfo( info, "drawMouth"  , 0        )  
    item.tag         = self:makeItemTag   ( info                          )
end

function Scheme:makeItemTag(info)
    if info.tag then return info.tag end
    return string.lower(string.sub(info.name,1,1))
end

function Scheme:obtainItemInfo(info, field, defval, ignoreNil)
    if not info.coords then info.coords = {} end
    local retval = nil
    retval=info.coords[field]
    if retval==nil then 
        retval=info[field] 
    end
    if not info.kind then
        info.kind = info.coords.kind
    end
    if retval==nil then
        if info.kind then 
            if not self.kinds[info.kind] then
                self.kinds[info.kind]={} 
            end
            self.kinds[info.kind].name = info.kind
            retval = self:obtainItemInfo(self.kinds[info.kind], field, defval, ignoreNil)
        end
    end
    if ignoreNil then 
        return retval or defval
    end
    if retval==nil then
        debug.warning("Can't obtain '"..field.."'", info.name)
        retval = defval
    end
    debug.assert(retval~=nil, "Can't obtain '"..field.."'", info.name)
    return retval
end

-- edit --

function Scheme:implantNewTo(subj,newObjKind,x,y,secret,name)
    local info     = self:createKindItem(newObjKind,x,y,name)
    info.secret    = secret
    subj:convinceOfExisting(info)
end

function Scheme:createImaginations(subj)
    if subj.refLevel==0 then return end
    for name,i in pairs(subj.imagination) do
        self:implantNewTo(subj,i.kind,i.x,i.y,i.secret,name)
    end
    for _,p in pairs(subj:presentSubpersons()) do
        self:createImaginations(p)
    end
end

-- kind --

function Scheme:getKind(k)
    if not self.kinds[k] then
        self.kinds[k] = {}
    end
    return self.kinds[k].kind
end

-- laws --

function Scheme:__readLaw(book,k1,k2)
    if not self.law[book][k1] then
        self.law[book][k1] = {}
    end
    return self.law[book][k1][k2]
end

function Scheme:__writeLaw(book,k1,k2,law)
    if not self.law[book][k1] then
        self.law[book][k1] = {}
    end
    self.law[book][k1][k2] = law
    return law
end

function Scheme:getLaw(book,k1,k2,default)
    local i=k1
    while i do
        local j=k2
        while j do
            local law = self:__readLaw(book,i,j)
            if law then
                self:__writeLaw(book,i,j,law)
                return law
            end
            j=self:getKind(j)
        end
        i=self:getKind(i)
    end
    return self:__writeLaw(book,k1,k2,default)
end

-- attitude --

function Scheme:getCollisionLaw(k1,k2)
    return self:getLaw("collision",k1,k2,Const.Lawbook.Collision.None)
end

function Scheme:getAttitudeLaw(k1,k2)
    local  default = {self:getCollisionLaw(k1,k2),1}
    local  law     = self:getLaw("attitude",k1,k2,default)
    return law
end

-- info --

function Scheme:getDescription()
    return self.location.descr
end

function Scheme:getStepnum()
    return self.stepnum
end

-- eof --




























--# Rational
-- rational.lua
-- Papa's game studio (c) 2014

Rational = class()

-- config --

Rational.CanAutoreflex = false
Rational.Comfort = {}
Rational.Direction = {}
Rational.Passability = {}
Rational.Direction.Toward   = 1
Rational.Direction.Backward = 2
Rational.Passability.Precisely = 1
Rational.Passability.Roughly   = 2
Rational.Comfort.Attract       = 1
Rational.Comfort.Repel         =-1
Rational.Comfort.Stay          = 0
Rational.Emotion               = {}
Rational.Emotion.None          = "none"
Rational.Emotion.Joy           = "joy"
Rational.Emotion.Sadness       = "sadness"
Rational.Emotion.Trust         = "trust"
Rational.Emotion.Disgust       = "disgust"
Rational.Emotion.Fear          = "fear"
Rational.Emotion.Anger         = "anger"
Rational.Emotion.Surprise      = "surprise"
Rational.Emotion.Anticipation  = "anticipation"

-- init --

function Rational:init(data, hasMind)
    if hasMind == nil then hasMind=true end
    self.scheme         = data.scheme
    self.host           = data.host
    self.kind           = data.kind
    self.depth          = data.depth
    self.tag            = data.tag
    self.name           = data.name
    self.x              = data.x
    self.y              = data.y
    self.radius         = data.radius or data.size/2
    self.size           = data.size
    self.colour         = data.colour
    self.visible        = data.visible
    self.secret         = data.secret
    self.imaginary      = data.imaginary
    self.suggested      = data.suggested
    self.impassable     = data.impassable
    self.opaque         = data.opaque
    self.moveRange      = data.moveRange
    self.sightRange     = data.sightRange
    self.comfortDist    = data.comfortDist
    self.refLevel       = hasMind and data.refLevel or 0
    self.tactics        = data.tactics 
    self.imagination    = data.imagination or {}
    self.prefix         = self:getPrefix()
    self.onTap          = data.onTap
    self.onFocus        = data.onFocus
    self.showName       = data.showName
    self.showEyes       = data.showEyes
    self.showMouth      = data.showMouth
    self.signalEmotions = {}
    if hasMind then
        self:createMind         (data)   
        self:createPath         ()
        self:clearSignalEmotions()
    end
    self:assert(self.refLevel>=0, "Negative refLevel="..self.refLevel)
end

-- think --

function Rational:run()
    self:think   () -- make decision based on deep forecast
    self:realize () -- set deep inner worlds in motion and apply rules
    self:inquire () -- get info directly from world and peers and inform subpersons
end

function Rational:think()
    if self.refLevel > 0 then 
        self:predict()
        self:decide ()
    end
end

function Rational:predict()
    self:reproduceFutureFromPresent()
    self:updateFutureWithSubpersonsDecisions()
end

function Rational:decide()
    local int = Tactics.decide(self,self.mind.future)
    self:setIntention(int)
    self:makeSignalEmotionsForIntention()
end

-- signals --

function Rational:makeSignalEmotionsForIntention()
    self:clearSignalEmotions()
    local int = self:getIntention()
    local exp = int.expectation
    if int.tactics == "hunt" then
        local exl = 0.75
        local emd = 1.00
        if exp > exl then 
            emd = math.degree(exl,exp,1)
            self:addSignalEmotion(Rational.Emotion.Joy, emd,"catching "..int.goal)
        else
            emd = math.degree(0,exp,exl)
            self:addSignalEmotion(Rational.Emotion.Anger, emd,"chasing "..int.goal)
        end
    elseif int.tactics == "beware" or int.tactics == "avoid" then
        emd = 1-exp
        self:addSignalEmotion(Rational.Emotion.Fear, emd, "beware "..int.goal)
    else
        self:addSignalEmotion(Rational.Emotion.None,1)
    end
end

function Rational:clearSignalEmotions()
    for _,n in pairs(Rational.Emotion) do
        self.signalEmotions[n]={degree=0, causes={}}
    end
end

function Rational:addSignalEmotion(name,degree,cause)
    local emo = self.signalEmotions[name]
    self:assert(emo,      "Unknoun emotion: "..tostring(name))
    self:assert(degree>=0,"Negative emotion's degree: "..name..":"..degree)
    emo.degree = math.min(1, emo.degree + degree)
    table.insert(emo.causes,cause)
end

function Rational:getSignalEmotions()
    return self.signalEmotions
end

function Rational:getMainSignalEmotion()
    local emo = Rational.Emotion.None
    local deg = 0
    for n,e in pairs(self.signalEmotions) do
        if e.degree > deg then
            emo = n
            deg = e.degree
        end
    end
    return emo,deg
end

-- realize --

function Rational:realize()
    self:realizePresentSubpersons()
    self:applyLaws()
    for _,subj in pairs(self:presentSubpersons()) do
        if self:isPersonReflexive(subj) then
            subj:realize()
        end
    end
end

function Rational:applyLaws()
    for _,subj in pairs(self:presentSubpersons()) do
        for _,obj in pairs(self:presentSubpersons()) do
            if subj:isNot(obj) 
                and self:inContact(subj,obj) 
                and self:canDemage(subj,obj)
            then
                self:log("? event: "..subj:fullName().." ? "..obj:fullName())
                self:forgetSubperson(obj, "destroyed")
            end
        end
    end
end

function Rational:realizePresentSubpersons()
    for _,subj in pairs(self:presentSubpersons()) do
        if subj:is(self) then
            subj:setpos(self:getIntention().position)
        elseif self:isPersonReflexive(subj) then
            subj:setpos(subj:getIntention().position)
        end
    end
end

-- inquire --

function Rational:inquire()
    self:inquireHost     ()
    self:notifySubpersons()
end

function Rational:notifySubpersons()
    for _,subj in pairs(self:presentSubpersons()) do
       if self:isPersonReflexive(subj) then
           subj:inquire()
       end
    end
end

function Rational:answerToSubperson(subj)
    return self:getAwarenessObjectsForSubject(subj)
end

function Rational:inquireHost()
    if not self.host then return end
    local answer = self.host:answerToSubperson(self)
    self:updatePresentSubpersons(answer)
    self:forgetInadequateSubpersons(answer)
end

-- introduce -- 

function Rational:explore(context)
    if self.refLevel > 0 then
        self:introduceJustMeToContext(context)
        self:introduceSubpersonsToTheirContext()
    end
end

function Rational:introduceJustMeToContext(context)
    self:clearPresent()
    for _,person in pairs(context) do
        self:introduceToPerson(person) 
    end
end

function Rational:introduceToPerson(info)
    local obj = Rational(self:prepareSubpersonInfo(info))
    self.mind.present:insert(obj)
    self:deleteFromPast(obj)
    self:log("? introduce: "..obj:fullNameCoords())
end

function Rational:introduceSubpersonsToTheirContext()
    for _,subj in pairs(self:presentSubpersons()) do
        self:introduceSubpersonToItsContext(subj)
    end
end

function Rational:introduceSubpersonToItsContext(subj)
    subj:explore(self:prepareContextForSubperson(subj))
end

-- update -- 

function Rational:updatePresentSubpersons(info)
    for _,person in pairs(info) do
        if not self:presentContains(person) then
            self:introduceToPerson(person)
        else
            self:updateSubpersonWithInfo(person)
        end
    end
end

function Rational:updateSubpersonWithInfo(info)
    local subj = self:presentSubperson(info)
    if subj.x~=info.x or subj.y~=info.y then
        self:log("? update: "..subj:fullNameCoords())
        subj:setpos(info:position())
    end
end

-- forget --

function Rational:forgetInadequateSubpersons(visibles)
    self:forgetGhostSubpersons       (visibles)
    self:forgetIllegitimateSubpersons(visibles)
end

function Rational:forgetGhostSubpersons(visibles)
    local is_visible = table.index(visibles, "name")
    for _,obj in pairs(self:presentSubpersons()) do
        if not is_visible[obj.name] and self:canSee(obj) then
            self:forgetSubperson(obj, "ghost")
        end
    end
end

function Rational:forgetIllegitimateSubpersons(visibles)
    local is_visible = table.index(visibles, "name")
    for _,obj in pairs(self:presentSubpersons()) do
        if not is_visible[obj.name] and not self:isSubpersonLegitimate(obj) then
            self:forgetSubperson(obj, "illegitimate")
        end
    end
end

function Rational:forgetSubperson(obj, cause)
    self.mind.present:remove(obj)
    self.mind.future:remove(obj)
    self:keepInPast(obj)
    return self:log("? forget: "..obj:fullName().." ["..cause.."]")
end

-- communication --

function Rational:convinceOfExisting(info)
    info.suggested = true
    self:introduceToPerson(info)
    self:inquireHost      ()
    self:notifySubpersons ()
end

-- subperson --

function Rational:prepareSubpersonInfo(info)
    local subp    = table.flatcopy(info)
    subp.host     = self
    subp.depth    = self.depth+1
    subp.refLevel = self:makeValidSubpersonReflevel(info)
    return subp
end

function Rational:makeValidSubpersonReflevel(info)
    return math.min(self.refLevel-1, info.refLevel)
end

function Rational:prepareContextForSubperson(person)
    return self:getAwarenessObjectsForSubject(person)
end

-- mind --

function Rational:createMind(data)
    self.mind = {
        present   = Map(self, "Present"),
        future    = Map(self, "Future"),
        past      = Map(self, "Past"),
        intention = {position={x=data.x,y=data.y},tactics="none",expectation=0.0},
        log       = {}
    }
end

function Rational:setIntention(int)
    int.expectation = int.expectation or 0
    int.tactics     = int.tactics     or "?"
    self:assert(int.position, "Unknown intention position")
    self:assert(int.expectation>=0, "Negative exp="..int.expectation.." t="..int.tactics)
    self.mind.intention = int
end

function Rational:getIntention()
    return self.mind.intention
end

function Rational:getIntentionInfo()
    if self.refLevel==0 then return "-" end
    local res = ""
    local int = self.mind.intention
    res = res..(int.tactics or "-").." "
    res = res..(int.goal    or "-").." "
    res = res..(math.round((int.expectation or 0)*100).."%")
    return res
end

function Rational:isPersonReflexive(subj)
    return subj and subj.refLevel > 0 and self:checkAutoreflex(subj)
end

function Rational:checkAutoreflex(subj)
    return Rational.CanAutoreflex or self:isNot(subj)
end

function Rational:createPath()
    self.path = {}
    if self.host~=nil then self.path=table.flatcopy(self.host.path) end
    table.insert(self.path,self)
end

-- present --

function Rational:clearPresent()
    self.mind.present:clear()
end

function Rational:presentContains(subj)
    return self.mind.present:contains(subj)
end

function Rational:presentSubpersons()
    return self.mind.present:objects()
end

function Rational:presentSubperson(obj)
    return self.mind.present:object(obj)
end

-- future --

function Rational:updateFutureWithSubpersonsDecisions()
    for _,person in pairs(self:presentSubpersons()) do
        if self:isPersonReflexive(person) then
            person:think()
            self:updateFutureForPerson(person)
        end
    end
end

function Rational:updateFutureForPerson(subj)
    self.mind.future:object(subj):setpos(subj.mind.intention.position)
end

function Rational:reproduceFutureFromPresent()
    self.mind.future:flatcopy(self.mind.present, false)
end

-- past --

function Rational:keepInPast(obj)
    self.mind.past:insert(obj)
end

function Rational:deleteFromPast(obj)
    self.mind.past:remove(obj)
end

function Rational:pastSubpersons()
    return self.mind.past:objects()
end

-- collisions --

function Rational:collisionGood(obj)
    return self:getCollisionLaw(obj)==Const.Lawbook.Collision.Good
end

function Rational:collisionBad(obj)
    return self:getCollisionLaw(obj)==Const.Lawbook.Collision.Bad
end

function Rational:getCollisionLaw(obj)
    return self.scheme:getCollisionLaw(self.kind, obj.kind)
end

function Rational:inContact(subj,obj)
    if not self:sameReality(subj,obj) then return false end
    return subj:distance(obj) < subj.radius+obj.radius
end

function Rational:canDemage(subj,obj)
    if not self:sameReality(subj,obj) then return false end
    return obj:collisionBad(subj)
end

-- attitude --

function Rational:getAttitudeTo(obj)
    local  law = self.scheme:getAttitudeLaw(self.kind, obj.kind)
    local  att = {gist=law[1], degree=(law[2] or 1)}
    return att
end

function Rational:likes(obj)
    return self:getAttitudeTo(obj).gist == Const.Lawbook.Attitude.Like
end

function Rational:dislikes(obj)
    return self:getAttitudeTo(obj).gist == Const.Lawbook.Attitude.Dislike
end

-- legitimation --

function Rational:isSubpersonLegitimate(subj)
    if self:is(subj) then
        return true
    end
    for _,obj in pairs(self:presentSubpersons()) do
        if self:IllegitimateContact(subj,obj) then
            return false
        end
    end
    return true
end

function Rational:IllegitimateContact(subj,obj)
    return 
        subj:isNot(obj)           and 
        self:inContact(subj,obj)  and 
        (self:canDemage(subj,obj) or self:canDemage(obj,subj)) 
end

-- perception --

function Rational:sameReality(subj,obj)
    if obj.secret and subj.secret               then return true  end
    if subj:is(obj.host) or obj:is(subj.host)   then return true  end
    if obj.secret or subj.secret                then return false end
    return true
end

function Rational:canSee(obj) 
    local inRange = (self:distance(obj) <= self.sightRange+obj.radius)
    return inRange and obj.visible and self:objectIsInViewField(obj)
end

function Rational:canMakeAwareOf(obj)
    return obj.imaginary or self:canSee(obj)
end

function Rational:getVisibleObjectsForSubject(subj)
    local objs = {}
    if self:isNot(subj) or Rational.CanAutoreflex then
        for _,o in pairs(self:presentSubpersons()) do
            if subj:canSee(o) then
                table.insert(objs, o)
            end
        end
    end
    return objs
end

function Rational:getAwarenessObjectsForSubject(subj)
    local objs = {}
    if self:isNot(subj) or Rational.CanAutoreflex then
        for _,o in pairs(self:presentSubpersons()) do
            if subj:isNotSecret(o) and subj:canMakeAwareOf(o) then
                table.insert(objs, o)
            end
        end
    end
    return objs
end

function Rational:isNotSecret(obj)
    if not obj.secret then return true end
    if obj:is(self)   then return true end
    return false
end

-- suppose --

function Rational:supposesPositionIsSafe(pos,map)
    for _,obj in pairs(map:objects()) do
        if self:collisionBad(obj) and self:isNot(obj) then
            if obj:vec2():dist(pos) < self.radius+obj.radius then
                return false
            end
        end
    end
    return true
end

-- tactics --

function Rational:getComfortIntention(obj)
    local d   = self:distance(obj)
    local da1 = self.radius+obj.radius+self.comfortDist
    local da2 = da1+self.moveRange
    local dr1 = math.max(obj.sightRange, self.sightRange)
    local dr2 = dr1+(self:canDemage(obj,self) and self.moveRange or math.huge)
    if self:likes(obj) then
        if d > da2 then 
            return Rational.Comfort.Attract
        elseif d < da1 then 
            return Rational.Comfort.Repel
        end
    elseif self:dislikes(obj) then
        if d < dr1 then
            return Rational.Comfort.Repel
        elseif d > dr2 then
            return Rational.Comfort.Attract
        end
    end
    return Rational.Comfort.Stay
end

-- comparing --

function Rational:isNot(obj)
    return not self:is(obj)
end

function Rational:is(obj)
    return self.name == obj.name
end

-- geometry --

function Rational:vec2()
    return vec2(self.x,self.y)
end

function Rational:distance(obj)
    return self:vec2():dist(obj:vec2())
end

function Rational:clearance(obj)
    return math.max(0, self:distance(obj)-self.radius-obj.radius)
end

function Rational:clearanceFromPos(pos,goal)
    local x,y     = self.x,self.y
    self.x,self.y = pos.x,pos.y
        local dpg = self:clearance(goal)
    self.x,self.y = x,y
    return dpg
end

function Rational:getBounds()
    local l,t,r,b,d
    d = self.radius
    l = self.x-d
    r = self.x+d
    t = self.y+d
    b = self.y-d
    return l,t,r,b
end

function Rational:setpos(p)
    self.x,self.y = p.x,p.y
end

function Rational:position()
    return {x=self.x, y=self.y}
end

function Rational:objectIsInViewField(obj)
    if not self.host then return true end
    local disposition = self.host:presentSubpersons()
    for _,b in pairs(disposition) do
        if b.opaque then
            if not Trigonometry.canCirclesSeeEachOtherOverBarrier(
                self.x,self.y,self.radius,
                 obj.x, obj.y, obj.radius,
                   b.x,   b.y,   b.radius ) 
            then
                return false
            end
        end
    end
    return true
end

function Rational:makeMoveInRange(goalx,goaly,dir)
    local len
    local vs,vg = self:vec2(), vec2(goalx,goaly)
    if dir == Rational.Direction.Toward then
        len = math.min(vs:dist(vg)-0.1,self.moveRange)
    elseif dir == Rational.Direction.Backward then
        len = -self.moveRange
    else
        self:error("Unknown dir")
    end
    local  pos=Trigonometry.vec2dir(vs,vg,len)
    return vec2(pos.x,pos.y)
end

function Rational:adjustMoveToPassability(movex,movey,mode)
    if mode == Rational.Passability.Precisely then
        return self:adjustMoveToPassability_Precisely(movex,movey)
    elseif mode == Rational.Passability.Roughly then
        return self:adjustMoveToPassability_Roughly(movex,movey)
    else
        self:error("Unknown mode")
    end
end

function Rational:adjustMoveToPassability_Roughly(movex,movey)
    local s,g =  {x=self.x,y=self.y,r=self.radius}, {x=movex,y=movey}
    if not self.host      then return vec2(movex,movey) end
    if self.refLevel == 0 then return vec2(movex,movey) end
    local disposition = self.host:presentSubpersons()
    for _,o in pairs(disposition) do
        if o.impassable then
            local b = {x=o.x, y=o.y, r=o.radius}
            if not Trigonometry.canPassCircle(s,g,b) then
                return dotVec2(s)
            end
        end
    end
    return dotVec2(g)
end

function Rational:adjustMoveToPassability_Precisely(movex,movey)
    local s,g =  {x=self.x,y=self.y,r=self.radius}, {x=movex,y=movey}
    if not self.host      then return vec2(movex,movey) end
    if self.refLevel == 0 then return vec2(movex,movey) end
    local disposition = self.host:presentSubpersons()
    for _,o in pairs(disposition) do
        if o.impassable then
            local b = {x=o.x, y=o.y, r=o.radius}
            local p = Trigonometry.getMotionPositionWithBarrier(s,g,b)
            if p~=nil then
                g = {x=p.x,y=p.y}
            end
        end
    end
    return Trigonometry.dotVec2(g)
end

-- log --

function Rational:log(post)
    local rec = string.format("%3d %s", self.scheme:getStepnum(), post)
    table.insert(self.mind.log, rec)
    return post
end

-- info --

function Rational:getPrefix()
    local p=""
    if self.depth > 1 then 
        p=self.host.prefix..self.host.tag
    end
    return p
end

function Rational:getInfo()
    local info=""
    info = info..self.name
    info = info..(self.refLevel>0 and "\n"..string.rep("•",self.refLevel) or "")
    return info
end

function Rational:getIntentionPos()
    return self:intention().position
end

-- string --

function Rational:fullName()
    return self.prefix=="" and self.name or self.prefix..""..self.name
end

function Rational:fullNameCoords()
    return self:fullName().." "..self:stringCoords()
end

function Rational:stringCoords()
    return string.format("%d,%d", math.round(self.x), math.round(self.y))
end

-- print --

function Rational:print(depth,indent)
    indent = indent or 0
    depth  = depth or 1
    self:printMe(indent)
    self:printMaps(depth,indent)
end

function Rational:printMaps(depth,indent)
    if depth>0 and self.refLevel>0 then
        if depth==1 and indent==0 then
            self.mind.present:print(depth,indent+1)
            self.mind.future:print(depth,indent+1)
            self.mind.past:print(depth,indent+1)
        else
            self.mind.present:print(depth,indent, false)
        end
    end
end

function Rational:printMe(indent)
    if indent == 0 then printline() end
    local ip = self.refLevel>0 and self:getIntention().position or {}
    local sp = string.format(" %d,%d", self.x,self.y)
    local sip = self.refLevel>0 and string.format(" ? %d,%d", ip.x,ip.y) or ""
    sip= self.refLevel==0 and "" or sip
    if not self.host then sp="";sip="" end
    printindent(indent, self:fullName()..sp..sip)
end

function Rational:printLog()
    printline()
    print(self:fullName().." log")
    if #self.mind.log == 0 then
        printindent(1,"<empty>")
    else
        for _,r in pairs(self.mind.log) do
            printindent(0,r)
        end
    end
end

-- debug --

function Rational:error(msg)
    debug.error(msg,self:fullName())
end

function Rational:assert(cond, msg)
    debug.assert(cond,msg,self:fullName())
end

-- eof --




























--# Map
-- map.lua
-- Papa's game studio (c) 2014

Map = class()

-- init --

function Map:init(owner, name)
    self.name           = owner:fullName().." "..name
    self.depth          = owner.depth
    self.elems          = {}
    self.elems_name     = {}
end

-- objects --

function Map:objects()
    return self.elems
end

function Map:contains(obj)
    return self:object(obj)~=nil
end

function Map:object(obj)
    local mo = self.elems_name[obj.name]
    if mo==nil then
        for _,o in pairs(self.elems) do
            if o.name == obj.name then
                mo = o
                self.elems_name[obj.name] = mo
                break
            end
        end
    end
    return mo
end

function Map:position(obj)
    local mo = self:m_objects(obj)
    return {x=mo.x, y=mo.y}
end

-- content --

function Map:insert(info, hasMind)
    local obj = Rational(info,hasMind)
    table.insert(self.elems,obj)
    self.elems_name[obj.name] = obj
end

function Map:remove(obj)
    local newObjects = {}
    for _,o in pairs(self.elems) do
        if o.name ~= obj.name then
            table.insert(newObjects,o)
        end
    end
    self.elems = newObjects
    self.elems_name[obj.name] = nil
end

function Map:clear()
    self.elems_name = {}
    self.elems      = {}
end

function Map:flatcopy(map, hasMind)
    self:clear()
    for _,o in pairs(map.elems) do
        self:insert(o, hasMind)
    end
end

-- utils --

function Map:size()
    return #self.elems
end

-- print --

function Map:print(depth,indent,printName)
    printName = printName==nil and true or printName
    if depth>0 and self:size()>0 then
        if printName then printindent(indent, self.name) end
        for _,elem in pairs(self.elems) do
            elem:print(depth-1,indent+1)
        end
    end
end

-- eof --



























--# Tactics
-- tactics.lua
-- Papa's game studio (c) 2014

Tactics = class()
Tactics.method={}

-- decision --

function Tactics.decide(subj,map)
    for _,t in ipairs(subj.tactics) do       
        local res = Tactics.method[string.lower(t)](subj,map)
        local int = Tactics.makePositionIntention(subj,res.pos,res.dir,res.exp,t,res.gln)
        if Tactics.isIntentionReasonable(subj,int,map) then
            return int
        end       
    end
    return Tactics.makePositionIntention(subj)
end

-- utils --

function Tactics.isIntentionReasonable(subj,int,map)
    return 
        not Tactics.isIntentionTrivial(subj,int)
        and subj:supposesPositionIsSafe(vec2(int.position.x,int.position.y),map)
end

function Tactics.isIntentionTrivial(subj,int)
    return subj.x==int.position.x and subj.y==int.position.y
end

function Tactics.makePosition(subj,goal,dir)
    dir = dir or Rational.Direction.Toward
    local  pos = subj:makeMoveInRange        (goal.x,goal.y,dir)
           pos = subj:adjustMoveToPassability(pos.x,pos.y,Rational.Passability.Precisely)
    return pos
end

function Tactics.makePositionIntention(subj,goal,dir,exp,tct,gln)
    goal = goal or subj
    local  pos = Tactics.makePosition(subj,goal,dir)
    local  int = {
        position    = {x=pos.x,y=pos.y},
        tactics     = tct,
        expectation = exp,
        goal        = gln,
    }
    return int
end

function Tactics.veryCloseTo(v)
    local d = 0.001
    return vec2(v.x+math.frandom(-d,d), v.y+math.frandom(-d,d))
end

function Tactics.res(pos,exp,gln,dir)
    return {
        pos = pos,
        exp = exp or 0.0,
        dir = dir or Rational.Direction.Toward,
        gln = gln or "-",
    }
end

-- expectation --

function Tactics.calcAttractionExpectation(subj,goal,pos)
    local fromsubj = subj:clearance(goal)
    local frompos  = subj:clearanceFromPos(pos,goal)
    local exp      = math.degree(fromsubj,frompos,0)
    return exp
end

function Tactics.calcRepelationExpectation(subj,goal,pos)
    local clearance = subj:clearanceFromPos(pos,goal)
    local distance  = pos:dist(goal:vec2())
    local exp       = math.degree(0, clearance, distance)
    return exp
end

-- methods --

Tactics.method["none"]=function(subj,map)
    local pos = subj:vec2()
    return Tactics.res(pos)
end

Tactics.method["around"]=function(subj,map)
    local angle = math.rad(-App.getTicks())/subj.radius*6
    local r     = vec2(0,subj.moveRange):rotate(angle)
    local pos   = vec2(subj.x + r.x, subj.y + r.y)
    if not subj:supposesPositionIsSafe(pos,map) then
        return Tactics.method.none(subj,map)
    end
    return Tactics.res(pos)
end

Tactics.method["wait"]=function(subj,map)
     local n = 5
     local pos = vec2(
        subj.x + math.random(-subj.radius,subj.radius)/n,
        subj.y + math.random(-subj.radius,subj.radius)/n)
    return Tactics.res(pos)
end

Tactics.method["panic"]=function(subj,map)
     local pos = vec2(
        subj.x + math.random(-subj.moveRange, subj.moveRange),
        subj.y + math.random(-subj.moveRange, subj.moveRange))
    return Tactics.res(pos)
end

Tactics.method["hunt"]=function(subj,map,mustSee)
    local goal
    local gln = ""
    local pos = subj:vec2()
    local exp = 0.0
    for _,obj in pairs(map:objects()) do
        if subj:isNot(obj) and subj:collisionGood(obj) then
            if not mustSee or subj:canSee(obj) then
                local dobj  = subj:clearance(obj)
                local dgoal = goal and subj:clearance(goal) or math.huge
                if dobj < dgoal then 
                    local p = Tactics.makePosition(subj,obj)
                    if subj:supposesPositionIsSafe(p,map) then
                        goal = obj 
                        gln  = obj:fullName()
                        pos  = Tactics.veryCloseTo(goal:vec2())
                        exp  = Tactics.calcAttractionExpectation(subj,goal,p)
                    end
                end
            end
        end
    end
    return Tactics.res(pos,exp,gln)
end

Tactics.method["attack"]=function(subj,map)
    return Tactics.method["hunt"](subj,map,true)
end

Tactics.method["beware"]=function(subj,map)
    local goal
    local gln = ""
    local pos = subj:vec2()
    local exp = 0.0
    for _,obj in pairs(map:objects()) do
        if subj:isNot(obj) and subj:collisionBad(obj) then
            if not goal or subj:distance(obj) < subj:distance(goal) then 
                local p = Tactics.makePosition(subj,obj,Rational.Direction.Backward)
                if subj:supposesPositionIsSafe(p,map) then
                    goal = obj 
                    gln  = obj:fullName()
                    pos  = Tactics.veryCloseTo(goal:vec2())
                    exp  = Tactics.calcRepelationExpectation(subj,goal,p)
                end
            end
        end
    end
    return Tactics.res(pos, exp, gln, Rational.Direction.Backward)
end

Tactics.method["avoid"]=function(subj,map)
    if subj:supposesPositionIsSafe(subj:vec2(),map) then 
        return Tactics.method["none"](subj,map)
    else
        return Tactics.method["beware"](subj,map)
    end
end

Tactics.method["comfort"]=function(subj,map)
    local pos = subj:vec2()
    local vec = vec2()
    local W   = 0.01
    local w   = 0.0
    for _,obj in pairs(map:objects()) do
        local p  = subj:getAttitudeTo(obj).degree
        local v  = obj:vec2()-pos
        local d  = v:len()+0.001
        local na = subj:canDemage(subj,obj) and 10 or 1
        local nr = subj:canDemage(obj,subj) and 10 or 2
        if subj:is(obj) then
        elseif subj:getComfortIntention(obj) == Rational.Comfort.Attract then
            w   = na  * p
            W   = W   + w
            vec = vec + v*w
        elseif subj:getComfortIntention(obj) == Rational.Comfort.Repel then
            w   = nr  * p
            W   = W   + w
            vec = vec - v*w
        end
    end
    return Tactics.res((pos + vec/W))
end

-- eof --




























--# Test
-- test.lua
-- Papa's game studio (c) 2014

Test = class()
Test.Logbook        = {}
Test.Details        = ""
Test.Rational       = {}
Test.Rational.Check = {}
Test.Rational.Run   = {}

-- log --

Test.Rational.Log = function(title,description,result)
    local res = result and "OK" or "Failed"
    local rec = title..": "..description.." — "..res
    if Test.Details ~="" then
        rec = rec..": "..Test.Details..""
    end
    table.insert(Test.Logbook,rec)   
    return rec
end

-- run --

function Test.Run(title, description, test, ...)
    Test.Details = ""
    local res = test(unpack({...}))
    local rec = Test.Rational.Log(title,description,res)
    if not res then
        displayMode(OVERLAY)
        print("Test: "..rec)
    end
end

Test.Rational.Run.Deep = function(subj)
    Test.Rational.Run.All(subj)
    for _,obj in pairs(subj:presentSubpersons()) do
        Test.Rational.Run.Deep(obj)
    end
end

Test.Rational.Run.All = function(subj)
    for description,test in pairs(Test.Rational.Check) do
        Test.Run(subj:fullName(), description, test, subj)
    end
end

-- checks --

Test.Rational.Check
["Imaginary: Reflevel must be positive"] = 
function(subj)
    for _,o in pairs(subj:presentSubpersons()) do
        if o.refLevel < 0 then
            Test.Details = "("..o:fullName().."="..o.refLevel..")"
            return false
        end
    end
    return true
end

Test.Rational.Check
["Imaginary: imaginary must be invisible"] = 
function(subj)
    for _,o in pairs(subj:presentSubpersons()) do
        if o.imaginary and o.visible then
            Test.Details = "("..o:fullNameCoords()..")"
            return false
        end
    end
    return true
end

Test.Rational.Check
["Imaginary: secret must be invisible"] = 
function(subj)
    for _,o in pairs(subj:presentSubpersons()) do
        if o.secret and o.visible then
            Test.Details = "("..o:fullNameCoords()..")"
            return false
        end
    end
    return true
end

Test.Rational.Check
["Collisions: intersected objects must be under laws"] = 
function(subj)
    if subj.refLevel==0 then return true end
    for _,s in pairs(subj:presentSubpersons()) do
        for _,o in pairs(subj:presentSubpersons()) do
            if s:isNot(o) and subj:inContact(s,o) and subj:canDemage(s,o) then
                Test.Details = "("..s:fullNameCoords()..") x ("..o:fullNameCoords()..")"
                return false
            end
        end
    end
    return true
end

Test.Rational.Check
["Self-knowledge: subject has self-reflection and its mind-position is correct"] = 
function(subj)
    if subj.refLevel==0                                  then return true end
    if not subj.host                                     then return true end
    if subj.host:is(subj) and not Rational.CanAutoreflex then return true end
    
    local ref = subj:presentSubperson(subj)
    if not ref then
        Test.Details = subj:fullName().."("..subj.refLevel..") has no self-reflection"
        return false
    elseif subj.x~=ref.x or subj.y~=ref.y then 
        Test.Details = subj:fullNameCoords().." / "..ref:fullNameCoords()
        return false
    end
    return true
end

Test.Rational.Check
["No ghosts: objects in sight range actually present in subject's reality"] = 
function(subj)
    local host = subj.host
    if not host then return true end
    if subj.refLevel==0 then return true end
    
    local visobjects      = host:getVisibleObjectsForSubject(subj)
    local visobjects_name = table.index(visobjects, "name")
    
    for _,obj in pairs(subj:presentSubpersons()) do
        if not obj.suggested and subj:canSee(obj) and not visobjects_name[obj.name] then 
            Test.Details = obj:fullNameCoords()
            return false
        end
    end
    return true
end

Test.Rational.Check
["Evident positions: visible objects present in subject's mind and have correct layout"] = 
function(subj)
    local host = subj.host
    if not host then return true end
    if subj.refLevel==0 then return true end
    
    local visobjects = host:getVisibleObjectsForSubject(subj)
    for _,visobj in pairs(visobjects) do
        local subpers = subj:presentSubperson(visobj)
        if not subpers then
            Test.Details = "unkown "..visobj:fullNameCoords()
            return false
        elseif subpers.x~=visobj.x or subpers.y~=visobj.y then
            Test.Details = "coords "..subpers:fullNameCoords()..
                            " / "..visobj:fullNameCoords()
            return false
        end
    end
    return true
end

-- eof --




























--# Actor
-- actor.lua
-- Papa's game studio (c) 2014

Actor = class()

-- config --

Actor.Draw = {}
Actor.Draw.Font = "Inconsolata"
Actor.Draw.Color = color(51, 57, 70, 139)
Actor.Draw.IntentionFocusCenterRadius = 1.2
Actor.Animation = {}
Actor.Animation.Duration = {}
Actor.Animation.Duration.Appiarence    = 1
Actor.Animation.Duration.Moving        = 1
Actor.Animation.Duration.Disappiarence = 1
Actor.Animation.Duration.Fading        = 0.5
Actor.Animation.Duration.Emergence     = 0.5

-- init --

function Actor:init(person,stage,plotter,isPhantom)
    self.person      = person
    self.stage       = stage
    self.plotter     = plotter
    self.inAnimation = false
    self.isVisible   = true
    self.inFocus     = false
    self.color       = person.colour or Actor.Draw.Color
    self.drawScale   = 1
    self.drawOpaque  = 1
    self.isSupposed  = self:isSupposedByView()
    self:update()
end

-- control --

function Actor:think()
    self.person:think()
    self:update()
end

function Actor:update(ignoreAnimation)
    if not ignoreAnimation and self.inAnimation then return end
    self.person      = self:isView() and self.stage:getView() or self.person
    self.name        = self.person.name
    self.label       = self.person:getInfo()
    self.sightRange  = self.person.sightRange
    self.moveRange   = self.person.moveRange
    self.refLevel    = self.person.refLevel
    self.x           = self.person.x
    self.y           = self.person.y
    self.ix          = self.person:getIntention().position.x
    self.iy          = self.person:getIntention().position.y
    self.radius      = self.person.radius
    self.size        = self.person.size
    self.visible     = self.person.visible
    self.imaginary   = self.person.imaginary
    self.secret      = self.person.secret
    self.color       = self.person.colour or Actor.Draw.Color
    self.showName    = self.person.showName
    self.showEyes    = self.person.showEyes
    self.showMouth   = self.person.showMouth
end

function Actor:adjustPerson(exactPerson)
    if exactPerson and exactPerson.name == self.person.name then 
        self.person = exactPerson
    end
    self:update(true)
end

-- events --

function Actor:onTap()
    if self.person.onTap then
        self.person.onTap(self.person)
    elseif self.person.onFocus then
        self.person.onFocus(self.person)
    end
end

function Actor:onFocus()
    if self.person.onFocus then
        self.person.onFocus(self.person)
    end
end

-- draw --

Actor.Draw.Algorithm={
    "update",
    "drawMoveRange",
    "drawHighliting",
    "drawSightRange",
    "drawBody",
    "drawIntention",
    "drawSupposedSign",
    "drawAttitudeSign",
}

function Actor:draw()
    if not self.isVisible then return end
    for _,fun in ipairs(Actor.Draw.Algorithm) do
        Actor[fun](self)
    end
end

-- draw calculations --

function Actor:calcColor(c)
    return color(c.r,c.g,c.b,c.a * self.drawOpaque)
end

function Actor:textColor()
    if colorIsLight(self.color) then
        return self:greyBlend(20,180,self.color)   
    else
        return self:greyBlend(200,80,self.color)   
    end
end

function Actor:eyeColor()
    return self:greyBlend(150,100,self.color)   
end

function Actor:pupilColor()
    return self:greyBlend(20,80,self.color)   
end

function Actor:mouthColor()
    return self:greyBlend(10,80,self.color)   
end

function Actor:borderColor()
    if colorIsLight(self.color) then
        return self:greyBlend(0,120,self.color,210)
    elseif colorIsDark(self.color) then
        return self:greyBlend(0,110,self.color,170)  
    else
        return self:greyBlend(0,90,self.color,150)  
    end
end

function Actor:greyBlend(g,a1,c,a2)
    return self:calcColor(greyBlend(g,a1,c,a2))
end

function Actor:calcRadius()
    return self.drawScale*self.radius
end

function Actor:calcBodyLabelFontSize()
    local fsmax  = self:calcRadius()/2
    local fs     = fsmax/string.len(self.name)*6
    fs = math.min(fs,fsmax)
    return fs
end

-- draw body --

function Actor:drawBody()
    if not self.isVisible then return end
    self:drawTrunk()
    self:drawName ()
    self:drawEyes ()
    self:drawMouth()
end

function Actor:drawHighliting()
    if not self.isVisible then return end
    if not self.inFocus   then return end 
    local clr     = self:greyBlend(255,100,self.stage:getBackgroundColor(),40)
    local width   = self:calcRadius()*0.5
    local radius  = self:calcRadius()*1.5
    self.plotter:stroke     (clr)
    self.plotter:fill       (clr)
    self.plotter:strokeWidth(width)
    self.plotter:arc        (self.x, self.y, radius)
end

function Actor:drawTrunk()
    if not self.isVisible then return end
    local bodyColor  = self:calcColor(self.color)
    local edgeColor  = self:borderColor()
    local radius     = self:calcRadius()
    local edgeWidth  = radius/15
    self.plotter:stroke     (edgeColor)
    self.plotter:strokeWidth(edgeWidth)
    self.plotter:fill       (bodyColor)
    self.plotter:circle     (self.x, self.y, radius)
end

-- draw eyes --

function Actor:drawEyes()
    if self.showEyes == 0 then return end
    local yc  = self:eyeColor()
    local pc  = self:pupilColor()
    local r   = self:calcRadius()
    local dx  = r*0.38
    local dy  = r*0.25
    local yr  = r*0.40
    local y1  = vec2(self.x-dx, self.y+dy)
    local y2  = vec2(self.x+dx, self.y+dy)
    self:drawEye(y1.x,y1.y, yr, yc,pc)
    self:drawEye(y2.x,y2.y, yr, yc,pc)
end
    
function Actor:drawEye(x,y, yr, yc,pc)
    local pr   = yr*self.refLevel/7
    local w    = yr*0.1
    local yv   = vec2(x,y)
    local bv   = vec2(self.x,self.y)
    local iv   = vec2(self.ix,self.iy)
    local from = bv
    local to   = iv
    local len  = (yr-pr)*math.min(0.7, (bv-iv):len()/self.radius)
    local pv   = Trigonometry.vec2dir(from,to,len)-bv+yv
    self.plotter:stroke     (pc)
    self.plotter:strokeWidth(w)
    self.plotter:fill       (yc)
    self.plotter:circle     (x, y, yr)
    self.plotter:fill       (pc)
    self.plotter:noStroke   ()
    self.plotter:circle     (pv.x, pv.y, pr)
end

-- draw mouth --

Actor.Draw.Mouth        = {}
Actor.Draw.Mouth.Width  = 0.1
Actor.Draw.Mouth.Height = 0.5
Actor.Draw.Mouth.Length = 0.1

local mhn = Actor.Draw.Mouth.Height
local mwn = Actor.Draw.Mouth.Width
local mln = Actor.Draw.Mouth.Length

function Actor:drawMouth()
    if self.showMouth == 0 then return end
    local drawEmoMouth={
        [Rational.Emotion.None]         = Actor.drawNeutralMouth,
        [Rational.Emotion.Joy]          = Actor.drawHappyMouth,
        [Rational.Emotion.Sadness]      = Actor.drawNeutralMouth,
        [Rational.Emotion.Trust]        = Actor.drawNeutralMouth,
        [Rational.Emotion.Disgust]      = Actor.drawNeutralMouth,
        [Rational.Emotion.Anger]        = Actor.drawAngryMouth,
        [Rational.Emotion.Fear]         = Actor.drawScaredMouth,
        [Rational.Emotion.Surprise]     = Actor.drawNeutralMouth,
        [Rational.Emotion.Anticipation] = Actor.drawNeutralMouth,
    }
    local emo    = self.person:getMainSignalEmotion()
    local degree = self.person:getSignalEmotions()[emo].degree
    drawEmoMouth[emo](self,degree)
end

function Actor:drawNeutralMouth()
    local w = 0.10
    local l = 0.15
    local h = mhn
    self:drawMouthCentralLine(w,l,h)
end

function Actor:drawHappyMouth(d)
    local h  = math.between(mhn+0.1,mhn+0.12,d)
    local w  = math.between(mwn,mwn*1.4,d)
    local lc = math.between(0.12,0.30,d)
    local ls = math.between(0.08,0.30,d)
    self:drawMouthCentralLine (w,lc,h)
    self:drawMouthLeftLineUp  (w,ls,h,lc)
    self:drawMouthRightLineUp (w,ls,h,lc)
end

function Actor:drawAngryMouth(d)
    local h  = math.between(mhn,mhn-0.0,d)
    local wc = math.between(mwn,mwn*1.1,d)
    local ws = math.between(mwn,mwn*2.9,d)
    local lc = math.between(mln,mln*2.5,d)
    local ls = math.between(mln,mln*3.0,d)
    self:drawMouthCentralLine (wc,lc,h)
    self:drawMouthLeftLine    (ws,ls,h,lc)
    self:drawMouthRightLine   (ws,ls,h,lc)
end

function Actor:drawScaredMouth(d)
    local h  = math.between(mhn,mhn-0.05,d)
    local wc = math.between(mwn,mwn*2.0,d)
    local ws = math.between(mwn,mwn*4.0,d)
    local lc = math.between(mln,mln*2.5,d)
    local ls = math.between(mln,mln*1.5,d)
    local hc = h-wc/3
    local hs = h
    self:drawMouthCentralLine (wc,lc,hc)
    self:drawMouthLeftLine    (ws,ls,hs,lc)
    self:drawMouthRightLine   (ws,ls,hs,lc)
end

function Actor:drawMouthSideLine(w,ls,h,lc,dirX,dirY)
    lc = lc or ls
    local r     = self:calcRadius()
    local mw    = r*w
    local mls   = r*ls
    local mlc   = r*lc
    local dy    =-r*h
    local sy    = 0.7
    local sx    = 0.7
    local x1,y1 = self.x+dirX*mlc,self.y+dy
    local x2,y2 = x1+dirX*mls*sx,y1+dirY*mls*sy
    self:drawMouthLine(x1,y1,x2,y2,mw)
end

function Actor:drawMouthLeftLine     (w,l,h,lc) self:drawMouthSideLine(w,l,h,lc,-1, 0) end
function Actor:drawMouthLeftLineUp   (w,l,h,lc) self:drawMouthSideLine(w,l,h,lc,-1, 1) end
function Actor:drawMouthLeftLineDown (w,l,h,lc) self:drawMouthSideLine(w,l,h,lc,-1,-1) end
function Actor:drawMouthRightLine    (w,l,h,lc) self:drawMouthSideLine(w,l,h,lc, 1, 0) end
function Actor:drawMouthRightLineUp  (w,l,h,lc) self:drawMouthSideLine(w,l,h,lc, 1, 1) end
function Actor:drawMouthRightLineDown(w,l,h,lc) self:drawMouthSideLine(w,l,h,lc, 1,-1) end 

function Actor:drawMouthCentralLine(w,l,h)
    local r     = self:calcRadius()
    local mw    = r*w
    local ml    = r*l
    local dy    =-r*h
    local x1,y1 = self.x-ml,self.y+dy
    local x2,y2 = self.x+ml,self.y+dy
    self:drawMouthLine(x1,y1,x2,y2,mw)
end

function Actor:drawMouthLine(x1,y1,x2,y2,mw)
    local mc    = self:mouthColor()
    self.plotter:lineCapMode(ROUND)
    self.plotter:stroke     (mc)
    self.plotter:strokeWidth(mw)
    self.plotter:line       (x1,y1,x2,y2)
end

-- draw name --

function Actor:drawName()
    if self.showName == 0 then return end
    if not self.isVisible then return end
    local txt     = self.label
    local fName   = Actor.Draw.Font
    local fSize   = self:calcBodyLabelFontSize()
    local fColor  = self:textColor() 
    self.plotter:textAlign(CENTER)
    self.plotter:textMode (CENTER)
    self.plotter:font     (fName)
    self.plotter:fontSize (fSize)
    self.plotter:fill     (fColor)
    self.plotter:text     (txt, self.x, self.y)
end

-- draw ranges --

function Actor:drawSightRange()
    if not self.isVisible then return end
    if self.refLevel == 0 then return end
    if not self.inFocus   then return end
    local clr     = self:greyBlend(255,40,self.stage:getBackgroundColor(),60)
    local width   = self:calcRadius()*0.1
    local radius  = self.sightRange
    self.plotter:stroke     (clr)
    self.plotter:strokeWidth(width)
    self.plotter:arc        (self.x,self.y,radius)
end

function Actor:drawMoveRange()
    if not self.isVisible then return end
    if self.refLevel == 0 then return end
    local clr     = self:greyBlend(0,40,self.stage:getBackgroundColor(),60)
    local radius  = self.moveRange*self.drawScale
    local sidenum = 32
    self.plotter:fill   (clr)
    self.plotter:polygon(self.x,self.y,radius,sidenum)
end

-- draw intention --

function Actor:drawIntention()
    if not self.isVisible then return end
    if self.refLevel == 0 then return end
    if not self.inFocus and not self.stage.inWatchMode then return end
    if #self.person.tactics == 0 then return end
    self:drawIntentionFocus      ()
    self:drawIntentionVector     ()
    self:drawIntentionFocus      () 
    self:drawIntentionFocusCenter() 
end

function Actor:drawIntentionVector()
    local xy,ixy,r = vec2(self.x,self.y), vec2(self.ix,self.iy), self:calcRadius() 
    local fr       = Actor.Draw.IntentionFocusCenterRadius
    local v1       = Trigonometry.vec2dir(xy,ixy,r)
    local v2       = Trigonometry.vec2dir(xy,ixy,xy:dist(ixy)-fr)
    local clr      = self:greyBlend(255,40,self.stage:getBackgroundColor(),60)
    local sw       = 1*self.drawScale
    self.plotter:stroke     (clr)
    self.plotter:strokeWidth(sw)
    self.plotter:lineCapMode(SQUARE)
    self.plotter:line       (v1.x,v1.y, v2.x,v2.y)
end

function Actor:drawIntentionFocusCenter()
    local r     = Actor.Draw.IntentionFocusCenterRadius*self.drawScale
    local sw    = 0.2*self.drawScale
    local fc    = self:greyBlend(255,80,self.stage:getBackgroundColor(),60)
    local sc    = self:greyBlend(  0,80,self.stage:getBackgroundColor(),60)
    self.plotter:stroke     (sc)
    self.plotter:strokeWidth(sw)
    self.plotter:fill       (fc)
    self.plotter:circle     (self.ix, self.iy, r) 
end
    
function Actor:drawIntentionFocus()
    if not self.inFocus or not self.stage.inWatchMode then return end
    local r,sw  = self:calcRadius(), self:calcRadius()/60
    local fc    = self:greyBlend(255,80,self.stage:getBackgroundColor(),20)
    local sc    = self:greyBlend(255,80,self.stage:getBackgroundColor(),80)
    self.plotter:stroke     (sc)
    self.plotter:strokeWidth(sw)
    self.plotter:fill       (fc)
    self.plotter:circle     (self.ix, self.iy, r) 
end

-- draw signs --

function Actor:drawSupposedSign()
    if not self.isVisible  then return end
    if not self.isSupposed then return end
    local txt     = "?"
    local fName   = Actor.Draw.Font
    local fSize   = self:calcRadius()*0.8
    local fColor  = self:greyBlend(255,80,self.stage:getBackgroundColor(),60)
    local x,y     = self.x+self.radius, self.y+self.radius
    self.plotter:textAlign(CENTER)
    self.plotter:textMode (CENTER)
    self.plotter:font     (fName)
    self.plotter:fontSize (fSize)
    self.plotter:fill     (fColor)
    self.plotter:text     (txt, x,y)
end
    
function Actor:drawAttitudeSign()
    if not self.isVisible then return end
    if self:isView() then return end
    local txt     = self:getAttitudeSignFromView()
    local fName   = Actor.Draw.Font
    local fSize   = self:calcRadius()*0.8
    local fColor  = self:greyBlend(255,80,self.stage:getBackgroundColor(),60)
    local x,y     = self.x-self.radius, self.y+self.radius
    self.plotter:textAlign(CENTER)
    self.plotter:textMode (CENTER)
    self.plotter:font     (fName)
    self.plotter:fontSize (fSize)
    self.plotter:fill     (fColor)
    self.plotter:text     (txt, x,y)
end

-- watch --

function Actor:watchMethod(plotter,w,h)
    local fs   = plotter:fontSize()
    Actor.watchInfo = ""
    self:addBasicWatch  ()
    self:addWatch       ()
    self:addEmotionWatch()
    local tw,th = plotter:textSize(Actor.watchInfo)
    plotter:text(Actor.watchInfo, fs/2, h-fs/2-th)
end

function Actor:addWatch(str)
    Actor.watchInfo = (Actor.watchInfo or "")..(str or "").."\n"
end

function Actor:addBasicWatch()
    local p   = self.person
    local tab = 6
    self:addWatchHeader(p:fullName())
    self:addWatchKeyVal("kind:", p.kind,               tab)
    self:addWatchKeyVal("intn:", p:getIntentionInfo(), tab)
    self:addWatchKeyVal("refl:", p.refLevel,           tab)
end

function Actor:addEmotionWatch()
    local p           = self.person
    local tab         = 10
    local hasEmotions = false
    self:addWatchHeader("Signal emotions")
    for n,e in pairs(self.person:getSignalEmotions()) do
        if e.degree>0 then
            self:addWatchKeyVal(n..": ", strPercent(e.degree))
            for _,c in ipairs(e.causes) do
                self:addWatch("  "..c)
            end
            hasEmotions = true
        end
    end
    if not hasEmotions then
        self:addWatch("-")
    end
end

function Actor:addWatchHeader(str)
    Actor:addWatch(str.."\n"..textline(23))
end

function Actor:addWatchKeyVal(key,val,tab)
    tab = tab or 0
    key = tabulate(key,tab)
    Actor:addWatch(key..(val=="" and "-" or val))
end

-- animation --

function Actor:animateMovingFrom(start)
    self:think()
    local x,y,ix,iy = self.x,self.y,self.ix,self.iy
    self.x  = start.x
    self.y  = start.y
    self.ix = start.refLevel == 0 and start.x or start.ix
    self.iy = start.refLevel == 0 and start.y or start.iy
    self.inAnimation = true
    tween(Actor.Animation.Duration.Moving, self,
        {x=x, y=y, ix=ix, iy=iy},
        tween.easing.quadInOut, 
        function(a) a.inAnimation = false end, 
    self)
end

function Actor:animateAppiarence()
    self:think()
    local ix,iy    = self.ix,self.iy
    self.drawScale = 0
    self.ix        = self.x
    self.iy        = self.y
    self.inAnimation = true
    tween(Actor.Animation.Duration.Appiarence, self,
        {drawScale = 1, ix=ix, iy=iy},
        tween.easing.quadInOut, 
        function(a) a.inAnimation = false end, 
    self)
end

function Actor:animateDisapiarenceInMotion(start)
    self:update()
    local x1,y1      = start.x,start.y
    local x2,y2      = self.x,self.y
    self.x           = x1
    self.y           = y1
    self.isVisible   = true
    self.inAnimation = true
    tween.sequence(
        tween(Actor.Animation.Duration.Moving,self,
            {x=x2,y=y2},
            tween.easing.quadInOut,
            function(a)end,
        self),
        tween(Actor.Animation.Duration.Disappiarence,self,
            {drawScale=0,ix=x2,iy=y2},
            tween.easing.quadInOut,
            function(a) a.inAnimation = false; a.isVisible = false; end,
        self)
    )
end

function Actor:animateEmergence(start)
    self:update()
    self.isVisible   = true
    self.inAnimation = true
    self.drawOpaque  = 0
    tween(Actor.Animation.Duration.Emergence,self,
        {drawOpaque=1},
        tween.easing.quadInOut,
        function(a) a.inAnimation = false end,
    self)
end

function Actor:animateFading(start)
    self:update()
    self.isVisible   = true
    self.inAnimation = true
    tween(Actor.Animation.Duration.Fading, self,
        {drawOpaque=0},
        tween.easing.quadInOut,
        function(a) a.inAnimation = false; a.isVisible = false; end,
    self)
end

-- info --

function Actor:isView()
    return self.stage:getView().name == self.name
end

function Actor:isSupposedByView()
    return not self.stage:getView():canSee(self.person)
end

function Actor:getAttitudeSignFromView()
    local s = ""
    local view  = self.stage:getView()
    local workd = self.stage:getWorld()
    local me    = self.person
    if not view or view==world then return s end
    if view:likes(me) then
        s = "+"
    elseif view:dislikes(me) then
        s = "-"
    end
    return s
end

-- geometry -- 

function Actor:contains(x,y)
    return vec2(self.x,self.y):dist(vec2(x,y)) < self.radius
end

function Actor:getBounds()
    return self.person:getBounds()
end

-- eof --


























--# Canvas
-- canvas.lua
-- Papa's game studio (c) 2014

Canvas = class()

-- init --

function Canvas:init(obj,x,y,w,h)
    self.obj         = obj
    self.x           = x
    self.y           = y
    self.w           = w
    self.h           = h
    self.ox          = 0
    self.oy          = 0
    self.scale       = 10
    self.maxScale    = 100
    self.minScale    = 1
    
    self.onTap       = nil
    self.onLongTap   = nil
    self.onPanning   = nil
    self.onScaling   = nil
    
    self.toucher              = Toucher(self,x,y+h,x+w,y)
    self.toucher.onTap        = Canvas._onTap
    self.toucher.onLongTap    = Canvas._onLongTap
    self.toucher.onPanning    = Canvas._onPanning
    self.toucher.onScaling    = Canvas._onScaling
    self.toucher.onSliding    = Canvas._onSliding
    self.toucher.onPanningBeg = Canvas._onPanningBeg
    self.toucher.onScalingBeg = Canvas._onScalingBeg
    self.toucher.onSlidingBeg = Canvas._onSlidingBeg
    
    self.plotter              = Plotter(self,Canvas.scrX,Canvas.scrY,Canvas.scrS)
end

-- events -- 

function Canvas:onTouch(t)
    self.toucher:proc(t, self:contains(t.x,t.y))
end

function Canvas:onTick()
    self.toucher:tick(CurrentTouch)
end

-- touching --

function Canvas:clearTouch()
    self.toucher:clear()
end

function Canvas:_onTap(x,y)
    self:call(self.onTap, x,y)
end

function Canvas:_onLongTap(x,y)
    self:call(self.onLongTap, x,y)
end

function Canvas:_onSlidingBeg(side,x,y)
    self:call(self.onSlidingBeg, side,x,y)
end

function Canvas:_onSliding(side,x,y)
    self:call(self.onSliding, side,x,y)
end

function Canvas:_onPanning(dx,dy) 
    self.ox = self.offsetBeg.x + dx/self.scale
    self.oy = self.offsetBeg.y + dy/self.scale
end

function Canvas:_onPanningBeg() 
    self.offsetBeg = vec2(self.ox, self.oy)
end

function Canvas:_onScalingBeg(f) 
    self.scaleBeg  = self.scale
    self.focusPrv  = vec2(f.x,f.y)
    self.offsetBeg = vec2(self.ox, self.oy)
end

function Canvas:call(method, ...)
    if method~=nil then
        method(self.obj, unpack({...}))
    end
end

function Canvas:_onScaling(s,f)
    self:shiftSchemeFocusToCanvasCenter  ()
    self:setScale                        (s*self.scaleBeg)
    self:shiftWorldFocusBackToStoredFocus(f)
    self:panToCurrentFocus               (f)
end

function Canvas:shiftSchemeFocusToCanvasCenter()
    self.wfx = self:wX(self.focusPrv.x) 
    self.wfy = self:wY(self.focusPrv.y)
    self.ox = -self.wfx
    self.oy = -self.wfy
end
    
function Canvas:shiftWorldFocusBackToStoredFocus(f)
    local nwfx = self:wX(f.x)
    local nwfy = self:wY(f.y)   
    self.ox = self.ox + (nwfx-self.wfx)
    self.oy = self.oy + (nwfy-self.wfy)
end

function Canvas:panToCurrentFocus(f)
    self.focusPrv.x = f.x
    self.focusPrv.y = f.y
end

-- windowing --

function Canvas:setScale(s,t)
    local ns = math.min(self.maxScale,math.max(self.minScale,s))  
    if not t or t == 0 or self.scale == ns then
        self.scale = ns
        return tween(0.01,self,{})
    else
        return tween(t, self,
            {scale = ns},
            tween.easing.linear, 
            function(c)end, self)
    end
end

function Canvas:setOffset(nox,noy,t)
    if not t or t == 0 or (self.ox == nox and self.oy == noy ) then
        self.ox = nox
        self.oy = noy
        return tween(0.01,self,{})
    else
        return tween(t, self,
            {ox = nox, oy = noy},
            tween.easing.linear, 
            function(c)end, self)
    end
end

function Canvas:fitRect(x,y,w,h,t,maxScale)
    local nox = -(x+w/2)
    local noy = -(y+h/2)
    local sx  = self.w / (w+0.01)
    local sy  = self.h / (h+0.01)
    local ns  = math.min(sx,sy)
    ns = math.min (ns,maxScale)
    self:setOffset(nox,noy,t)
    self:setScale (ns,t)
end

-- draw --

function Canvas:open()
    pushStyle()
    pushMatrix()  
    self:clip()
end

function Canvas:close()
    clip()
    popMatrix()
    popStyle()
end

function Canvas:clip()
    clip(self.x,self.y,self.w,self.h)
end

function Canvas:draw(clr)
    fill(clr)
    rect(self.x,self.y,self.w,self.h)
end

-- geometry --

function Canvas:center() return vec2(self.x + self.w/2, self.y + self.h/2) end
function Canvas:scrX(x) return (x+self.ox)*self.scale + self:center().x end
function Canvas:scrY(y) return (y+self.oy)*self.scale + self:center().y end
function Canvas:scrS(n) return n*self.scale end
function Canvas:scrV2(v) return vec2(self:scrX(v.x),self:scrY(v.y)) end
function Canvas:wX(x) return (x-self:center().x)/self.scale-self.ox end
function Canvas:wY(y) return (y-self:center().y)/self.scale-self.oy end
function Canvas:wV2(v) return vec2(self:wX(v.x),self:wY(v.y)) end
function Canvas:contains(x,y) return Trigonometry.vec2inRect(vec2(x,y),self) end

-- eof --




























--# Plotter
-- plotter.lua
-- Papa's game studio (c) 2014

Plotter = class()

-- init --

function Plotter:init(obj, scrX, scrY, scrS)
    self.obj  = obj
    self.scrX = scrX
    self.scrY = scrY
    self.scrS = scrS
end

-- translate --

function Plotter:x(x)
    return self.scrX and self.scrX(self.obj,x) or x
end

function Plotter:y(y)
    return self.scrY and self.scrY(self.obj,y) or y
end

function Plotter:s(n)
    return self.scrS and self.scrS(self.obj,n) or n
end

-- draw --

function Plotter:noStroke() 
    noStroke() 
end

function Plotter:noFill() 
    noFill() 
end

function Plotter:circle(x,y,r) 
    ellipse(self:x(x), self:y(y), self:s(r*2)) 
end

function Plotter:arc(x, y, r)
    local m = mesh()
    x,y,r = self:x(x), self:y(y), self:s(r+0.0001)
    m:addRect(x, y, r*2, r*2)
    m.shader       = shader("Patterns:Arc")
    m.shader.size  = (1 - strokeWidth()/r) * 0.5
    m.shader.color = color(stroke())
    m.shader.a1    = 0
    m.shader.a2    = 0
    m:draw()
end

function Plotter:text(t,x,y) 
    text(t, self:x(x), self:y(y))
end

function Plotter:polygon(x,y,r,n)
    x,y,r = self:x(x), self:y(y), self:s(r+0.0001)
    polygon(x,y,r,n)
end

function Plotter:line(x1,y1,x2,y2)
   line(self:x(x1),self:y(y1),self:x(x2),self:y(y2))
end

function Plotter:lineCapMode(m) 
    return m and lineCapMode(m) or lineCapMode()
end

function Plotter:fill(clr) 
    return clr and fill(clr) or fill()
end

function Plotter:stroke(clr) 
    return clr and stroke(clr) or stroke()
end

function Plotter:textAlign(ta) 
    return ta and textAlign(ta) or textAlign()
end

function Plotter:textMode(tm) 
    return tm and textMode(tm) or textMode()
end

function Plotter:font(f) 
    return f and font(f) or font()
end
    
function Plotter:textSize(t) 
    w,h = textSize(t)
    return w/self:s(1), h/self:s(1)
end
    
function Plotter:textWrapWidth(w) 
    return w and textWrapWidth(self:s(w)) or textWrapWidth()/self:s(1)
end

function Plotter:strokeWidth(w) 
    return w and strokeWidth(self:s(w)) or strokeWidth()/self:s(1)
end

function Plotter:fontSize(fs) 
    return fs and fontSize(self:s(fs)) or fontSize()/self:s(1)
end

-- eof --




























--# Toucher
-- toucher.lua
-- Papa's game studio (c) 2014

Toucher = class()

-- config --

Toucher.Mode         = {}
Toucher.Side         = {}
Toucher.Mode.Nothing = 0
Toucher.Mode.Waiting = 1
Toucher.Mode.Panning = 2
Toucher.Mode.Scaling = 3
Toucher.Mode.Sliding = 4
Toucher.Side.Left    = 1
Toucher.Side.Top     = 2
Toucher.Side.Right   = 3
Toucher.Side.Bottom  = 4
Toucher.LongTapDuration = 0.5
    
-- init --

function Toucher:init(obj,l,t,r,b)
    self.l            = l or 0
    self.t            = t or HEIGHT
    self.r            = r or WIDTH
    self.b            = b or 0
    self.mode         = Toucher.Mode.Nothing
    self.obj          = obj    
    self.onTap        = nil
    self.onLongTap    = nil
    self.onWaitingBeg = nil
    self.onPanning    = nil
    self.onPanningBeg = nil
    self.onPanningEnd = nil
    self.onScaling    = nil
    self.onScalingBeg = nil
    self.onScalingEnd = nil    
    self.onSliding    = nil
    self.onSlidingBeg = nil
    self.onSlidingEnd = nil    
    
    self.t1id         = nil
    self.t2id         = nil
    self.t1beg        = nil
    self.t1cur        = nil
    self.t2beg        = nil
    self.t2cur        = nil
end

-- proc--

function Toucher:proc(t,inBounds)
    if t.state == MOVING  then
        self:moving(t,inBounds)
    elseif t.state == BEGAN then
        self:began(t)
    elseif t.state == ENDED  then
        self:ended(t,inBounds)
    end
end

-- events --

function Toucher:tick(t)
    if self.mode == Toucher.Mode.Waiting
        and os.clock()-self.beganTime > Toucher.LongTapDuration 
    then
        self:_onLongTap(t.x, t.y)
        self:clear()
    end
end
    
function Toucher:ended(t,inBounds)
    if inBounds and self.mode == Toucher.Mode.Waiting and t.id==self.t1id then
        self:_onTap(t.x, t.y)
    elseif self.mode == Toucher.Mode.Panning then
        self:_onPanningEnd()
    elseif self.mode == Toucher.Mode.Scaling then
        self:_onScalingEnd()
    elseif self.mode == Toucher.Mode.Sliding then
        self:_onSlidingEnd()
    end
    self:clear()
end
    
function Toucher:began(t)
    self.beganTime = os.clock()
    if self.t1id == nil then
        self.t1id  = t.id
        self.t1beg = vec2(t.x,t.y)
        self.t1cur = vec2(t.x,t.y)
        self.mode  = Toucher.Mode.Waiting
        self:_onWaitingBeg()
    elseif self.t2id == nil then
        self.t2id  = t.id
        self.t2beg = vec2(t.x,t.y)
        self.t2cur = vec2(t.x,t.y)
        self.mode  = Toucher.Mode.Scaling
        self:_onScalingBeg(self:focus())
    end
end

function Toucher:focus()
    if self.mode == Toucher.Mode.Waiting then
        return self.t1cur
    elseif self.mode == Toucher.Mode.Panning then
        return self.t1cur
    elseif self.mode == Toucher.Mode.Scaling then
        return Trigonometry.vec2middle(self.t1cur,self.t2cur)
    end
    return nil
end

function Toucher:moving(t,inBounds)
    self:updateVectors(t)
    if self.mode == Toucher.Mode.Waiting and self:fromSide() and inBounds then
        self.mode = Toucher.Mode.Sliding
        self.side = self:fromSide()
        self:_onSlidingBeg(self.side,t.x,t.y)
    elseif self.mode == Toucher.Mode.Waiting and inBounds then
        self.mode = Toucher.Mode.Panning
        self:_onPanningBeg()
    elseif self.mode == Toucher.Mode.Panning then
        self:_onPanning(t.x-self.t1beg.x, t.y-self.t1beg.y)
    elseif self.mode == Toucher.Mode.Scaling then
        local dbeg = self.t1beg:dist(self.t2beg)
        local dcur = self.t1cur:dist(self.t2cur)
        local s    = dcur/(dbeg+0.1)
        self:_onScaling(s, self:focus())
    elseif self.mode == Toucher.Mode.Sliding then
        self:_onSliding(self.side, t.x,t.y)
    end
end

-- sliding --

function Toucher:fromSide()
    if self.t1beg.x<=self.l+1 then 
        return Toucher.Side.Left
    elseif self.t1beg.x>=self.r-1 then 
        return Toucher.Side.Right
    elseif self.t1beg.y>=self.t-1 then 
        return Toucher.Side.Top
    elseif self.t1beg.y<=self.b+1 then 
        return Toucher.Side.Bottom
    end
    return nil
end

-- control --
    
function Toucher:clear()
    self.mode  = Toucher.Mode.Nothing
    self.side  = nil
    self.t1id  = nil
    self.t2id  = nil
    self.t1beg = nil
    self.t1cur = nil
    self.t2beg = nil
    self.t2cur = nil
end
    
-- utils --

function Toucher:updateVectors(t)
    if t.id == self.t1id then
        self.t1cur = vec2(t.x,t.y)
    elseif t.id == self.t2id then
        self.t2cur = vec2(t.x,t.y)
    end
end

-- substitutes --

function Toucher:call(method, args)
    if method~=nil then 
        method(self.obj, unpack(args))
    end
end

function Toucher:_onTap        (...) self:call(self.onTap,          {...}) end
function Toucher:_onLongTap    (...) self:call(self.onLongTap,      {...}) end
function Toucher:_onWaitingBeg (...) self:call(self.onWaitingBeg,   {...}) end
function Toucher:_onPanning    (...) self:call(self.onPanning,      {...}) end
function Toucher:_onPanningBeg (...) self:call(self.onPanningBeg,   {...}) end
function Toucher:_onPanningEnd (...) self:call(self.onPanningEnd,   {...}) end
function Toucher:_onScaling    (...) self:call(self.onScaling,      {...}) end
function Toucher:_onScalingBeg (...) self:call(self.onScalingBeg,   {...}) end
function Toucher:_onScalingEnd (...) self:call(self.onScalingEnd,   {...}) end
function Toucher:_onSliding    (...) self:call(self.onSliding,      {...}) end
function Toucher:_onSlidingBeg (...) self:call(self.onSlidingBeg,   {...}) end
function Toucher:_onSlidingEnd (...) self:call(self.onSlidingEnd,   {...}) end



-- eof --




























--# Events
-- events.lua
-- Copied from (c) Twolivesleft

Events = class()
Events.__callbacks = {}

-- bind --

function Events.bind(event,obj,func)
    if not Events.__callbacks[event] then
        Events.__callbacks[event] = {}
    end
    
    if not Events.__callbacks[event][obj] then
        Events.__callbacks[event][obj] = {}
    end
    
    Events.__callbacks[event][obj][func] = 1
end

-- unbind --

function Events.unbind(obj,optionalEvent)
    local event = optionalEvent
    for evt,cbs in pairs(Events.__callbacks) do
        if event == nil or event == evt then
            cbs[obj]=nil
        end
    end
end

function Events.unbindEvent(event)
    Events.__callbacks[event] = nil
end

-- trigger --

function Events.trigger(event,...)
    if Events.__callbacks[event] then
        local clone = {}
        for obj,funcs in pairs(Events.__callbacks[event]) do
            clone[obj] = {}
            for func,dummy in pairs(funcs) do
                clone[obj][func] = 1
            end
        end
        for obj,funcs in pairs(clone) do
            for func,dummy in pairs(funcs) do
                local argCopy = table.flatcopy({...})
                table.insert(argCopy,1,obj)
                func(unpack(argCopy))
            end
        end
    end
end

-- eof --




























--# Panel
-- panel.lua
-- Papa's game studio (c) 2014

Panel = class()

-- config --

Panel.Font = UI.Font

-- init --

function Panel:init(x,y,w,h,fclr,name)
    self.x     = x
    self.y     = y
    self.w     = w
    self.h     = h
    self.v     = true
    self.o     = 1
    self.fclr  = fclr or grey(128)
    self.elems = {}
    self.name  = name
    self._draw      = Panel.fill
    self._drawarg   = {fclr or grey(20)}
    self._update    = function()end
    self._updatearg = {}
end

-- events --

function Panel:onTouch(tx,ty,ts,tid)
    if not self:contains(tx,ty) then return true end
    tx = tx - self.x
    ty = ty - self.y
    self.continueTouchProc = true 
    for i=#self.elems,1,-1 do
        e = self.elems[i]
        if self.continueTouchProc then
            self.continueTouchProc = e:onTouch(tx,ty,ts,tid)
        end
    end
    return self.continueTouchProc
end

function Panel:onDraw()
    self:draw()
end

-- elems --

function Panel:insert(obj)
    table.insert(self.elems,obj)
end

function Panel:remove(obj)
    assert(false,"Panel:remove is not implemented yet")
end

-- plotter --

function Panel:getPlotter()
    return self.plotter or self:createPlotter()
end

function Panel:createPlotter()
    self.plotter = Plotter(self)
    return self.plotter
end

-- setters --

function Panel:setUpdate(f,...)
    self._update    = f
    self._updatearg = {...}
end

function Panel:setDraw(f,...)
    self._draw     = f
    self._drawarg  = {...}
end

-- update --

function Panel:update()
    self:_update(unpack(self._updatearg))
end

-- draw --

function Panel:draw()
    self:update()
    if not self.v then return end
    pushMatrix()
    pushStyle()
    translate(self.x,self.y)
        self:drawSelf ()
        self:drawElems()
    popStyle()
    popMatrix()
end

function Panel:drawSelf()
    self:_draw(unpack(self._drawarg))
end

function Panel:drawElems()
    for _,e in pairs(self.elems) do
        e:onDraw()
    end
end

function Panel:fill(fclr)
    fclr = fclr or self.fclr
    noStroke()
    fill(colorOpaque(fclr,self.o))
    rect(0,0,self.w,self.h)
end

function Panel:text(txt,fs,m,tclr)
    tclr = tclr or self:makeTextColor()
    m    = m    or CENTER
    fs   = fs   or math.min(self.h/2,50)
    if m==LEFT then m=CORNER end
    textMode  (m)
    textAlign (LEFT)
    fill      (colorOpaque(tclr,self.o))
    font      (Panel.Font)
    fontSize  (fs)
    local     x,y=0,0
    if m==CORNER then
        x = fs/2
        y = (self.h-fs)/2
    elseif m==CENTER then
        x = self.w/2
        y = self.h/2
    else
        error("unknown text mode")
    end
    text(txt,x,y)
end

-- utils --

function Panel:makeTextColor(fclr)
    fclr = fclr or self.fclr
    if colorIsLight(fclr) then
        return greyBlend(20,200,fclr)   
    else
        return greyBlend(200,100,fclr)   
    end
end

-- geometry --

function Panel:contains(x,y)
    return self.v and Trigonometry.vec2inRect(vec2(x,y),self)
end

-- eof --




























--# Button
-- button.lua
-- Papa's game studio (c) 2014

Button = class(Panel)

-- config --

Button.Font    = "Inconsolata"
Button.Color   = color(100)
Button.Tcolor  = color(40)

-- init --

function Button:init(x,y,w,h,t,fclr,tclr,name)
    Panel.init(self,x,y,w,h)
    self.t          = t or "<btn>"
    self.fclr       = fclr
    self.tclr       = tclr or Panel.makeTextColor(self)
    self.isChecked  = false
    self.isEnabled  = true
    self.name       = name or ("["..t.."]")
    self._draw      = Button.drawText
    self._drawarg   = {}
    self._action    = nil
    self._actionarg = {}
end

-- events --

function Button:onTouch(tx,ty,ts,tid)
    if not self:contains(tx,ty) then return true end
    Panel.onTouch(self,tx,ty,ts,tid)
    if self.continueTouchProc then 
        if ts == BEGAN then
            self.tid = tid
            return false
        elseif ts == ENDED and self.tid == tid then
            return self:action()
        end
    end
    return self.continueTouchProc
end

function Button:onDraw()
    Panel.draw(self)
end

-- setters --

function Button:setDraw(f,...)
    Panel.setDraw(self,f,{...})
end

function Button:setUpdate(f)
    Panel.setUpdate(self,f)
end

function Button:setAction(f,...)
    self._action    = f
    self._actionarg = {...}
end

-- update --

function Button:update()
    Panel.update(self)
end

-- action --

function Button:action()
    if self.isEnabled and self._action then
        local cont = self:_action(unpack(self._updatearg))
        return (cont==nil) and false or cont
    end
    return true
end

-- draw --

function Button:drawSelf()
    Panel.drawSelf(self)
end

function Button:drawElems()
    Panel.drawElems(self)
end

function Button:textColor()
    if not self.isEnabled then
        return self.tclr:mix(self.fclr,0.1)
    elseif self.isChecked then
        return self.fclr
    else
        return self.tclr
    end
end

function Button:fillColor()
    if not self.isEnabled then
        return self.fclr
    elseif self.isChecked then
        return self.tclr
    else
        return self.fclr
    end
end

function Button:drawText()
    Panel.fill(self,self:fillColor())
    local fs = self.fs or self.h*0.7
    fontSize(fs)
    fill(self:textColor())
    font(Button.Font)
    text(self.t, self.w/2, self.h/2)
end

-- geometry --

function Button:contains(x,y)
    return Panel.contains(self,x,y)
end

-- eof --




























--# Trigonometry
-- trigonometry.lua
-- Papa's game studio (c) 2014

Trigonometry = class()

-- third parts' helper class

__trighelper = class()

-- can pass --

function canPassCircle(s,g,br)
    return not __trighelper.SegmentCircleIntersect(s,g,br)
end

-- can see --

function Trigonometry.canCirclesSeeEachOtherOverBarrier(x1,y1,r1, x2,y2,r2, bx,by,br)
    local d1b = Trigonometry.distanceBetweenCircles(x1,y1,r1, bx,by,br)
    local d2b = Trigonometry.distanceBetweenCircles(x2,y2,r2, bx,by,br)
    local dcc = Trigonometry.distanceBetweenCircles(x1,y1,r1, x2,y2,r2)
    if dcc == 0 or dcc <= d1b or dcc <= d2b then
        return true
    end
    local res = __trighelper.getCircleCircleTangents(x1,y1,r1, x2,y2,r2)
    local vis = false
    for i,t in ipairs(res) do
        local a   = {x=t.x1,y=t.y1}
        local b   = {x=t.x2,y=t.y2}
        local cr  = {x=bx,y=by,r=br}
        if not __trighelper.SegmentCircleIntersect(a,b,cr) then
            vis = true
            break
        end
    end
    return vis
end

-- barriers --

function Trigonometry.getMotionPositionWithBarrier(s,e,b)
    local r = Trigonometry.segmentCircleIntersect(s,e,b)
    if not r then return e end
    local sr= Trigonometry.dotDistance(s,r)
    local v = Trigonometry.vec2dir(Trigonometry.dotVec2(s),Trigonometry.dotVec2(r),sr-s.r)
    r = {x=v.x,y=v.y}
    local sb = Trigonometry.dotDistance(s,b)
    if sb < b.r then r=s end
    if not r    then r=e end
    return r
end

-- segment circle intersection --

function Trigonometry.segmentCircleIntersect(s,e,c)
    local res = __trighelper.FindSegmentCircleIntersections(c.x,c.y,c.r,s.x,s.y,e.x,e.y)
    local rr = nil
    local md = math.huge
    for _,r in pairs(res) do
        if Trigonometry.segmentCircleIntersectionIsValid(s,e,c,r) then
            local d = Trigonometry.dotDistance(s,r)
            if d < md then
                rr = r
                md = d
            end
        end
    end
    return rr
end

function Trigonometry.segmentCircleIntersectionIsValid(s,e,b,r)
    local sb = Trigonometry.dotDistance(s,b)
    local se = Trigonometry.dotDistance(s,e)
    local sr = Trigonometry.dotDistance(s,r)
    local er = Trigonometry.dotDistance(e,r)
    if sb < b.r then return false end
    if sr > se  then return false end
    if er > se  then return false end
    return true
end

-- dots and circules --

function Trigonometry.dotVec2(a)
    return vec2(a.x,a.y)
end

function Trigonometry.dotDistance(a,b)
    return Trigonometry.dotVec2(a):dist(Trigonometry.dotVec2(b))
end

function Trigonometry.distanceBetweenCircles(x1, y1, r1, x2, y2, r2)
    local d = vec2(x1, y1):dist(vec2(x2, y2)) - r1 -r2
    d = math.max(d,0)
    return d
end

-- vec2 --

function Trigonometry.pointInRect(p, lb, rt)
    return not (p.x<=lb.x or p.x>=rt.x or p.y<=lb.y or p.y>=rt.y)
end

function Trigonometry.vec2dir(from,to,len)
    local v1 = vec2(from.x,from.y)
    local v2 = vec2(to.x,to.y)
    local dv = vec2(v2.x-v1.x, v2.y-v1.y)
    local dvl=dv:len()
    if dvl==0 then 
        return v1
    end
    dv.x = dv.x*len/dvl
    dv.y = dv.y*len/dvl
    return vec2(v1.x+dv.x,v1.y+dv.y) 
end

function Trigonometry.vec2inRect(v,r)
    return v.x>=r.x and v.x<=r.x+r.w and 
           v.y>=r.y and v.y<=r.y+r.h
end

function Trigonometry.vec2middle(v1,v2)
    return vec2((v1.x+v2.x)/2, (v1.y+v2.y)/2)
end

-- intersections (c) math forum --

function __trighelper.SegmentCircleIntersect(a, b, c)
    local ac2 = (c.x - a.x)^2 + (c.y - a.y)^2
    local cr2 = c.r * c.r
    if ac2 <= cr2 then
        return a
    end
    local bc2 = (c.x - b.x)^2 + (c.y - b.y)^2
    if bc2 <= cr2 then
        return b
    end    
    local abx = b.x-a.x
    local aby = b.y-a.y
    local e = {x = c.x - aby, y = c.y + abx}
    local f = {x = c.x + aby, y = c.y - abx}
    local point = __trighelper.SegmentLineIntersect(a, b, e, f)
    if point and (point.x - c.x)^2 + (point.y - c.y)^2 <= cr2 then
        return point
    end
end

function __trighelper.SegmentLineIntersect(p, p2, q, q2)
    local rx,ry     = p2.x-p.x, p2.y-p.y
    local sx,sy     = q2.x-q.x, q2.y-q.y
    local qmpx,qmpy = q.x -p.x, q.y -p.y
    local rxs = rx*sy - ry*sx
    local qmpxs = qmpx*sy - qmpy*sx
    if rxs == 0 then
        if qmpxs == 0 then
            return p
        end
    else
        local t = qmpxs / rxs
        if 0 <= t and t <= 1 then
            return {x=p.x+t*rx, y=p.y+t*ry}
        end
    end
end

-- tangents (c) math forum --

function __trighelper.getCircleCircleTangents(x1, y1, r1, x2, y2, r2)
    local res   = {}
    local signs = {1,-1}
    local d_sq  = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);    
    if (d_sq <= (r1-r2)*(r1-r2)) then
        return {}
    end    
    local d  =  math.sqrt(d_sq);
    local vx = (x2 - x1) / d;
    local vy = (y2 - y1) / d;    
    for _,sign1 in ipairs(signs) do
        local c = (r1 - sign1 * r2) / d
        if (c*c <= 1.0) then
            local h = math.sqrt(math.max(0.0, 1.0 - c*c))
            for _,sign2 in ipairs(signs) do
                local nx = vx * c - sign2 * h * vy
                local ny = vy * c + sign2 * h * vx
                local rx1 = x1 + r1 * nx;
                local ry1 = y1 + r1 * ny;
                local rx2 = x2 + sign1 * r2 * nx;
                local ry2 = y2 + sign1 * r2 * ny;
                local tangent = {x1=rx1,y1=ry1,x2=rx2,y2=ry2}
                table.insert(res,tangent)
            end
        end
    end
    return res
end

-- segment circle intesection (c) math forum --

function __trighelper.FindSegmentCircleIntersections(cx, cy, radius, x1,y1, x2,y2)
    local res = {}
    local ix1, iy1, ix2,iy2
    local dx
    local dy
    local A
    local B
    local C
    local det
    local t    
    dx = x2 - x1
    dy = y2 - y1
    A = dx * dx + dy * dy
    B = 2 * (dx * (x1 - cx) + dy * (y1 - cy))
    C = (x1 - cx) * (x1 - cx) + (y1 - cy) * (y1 - cy) - radius * radius  
    det = B * B - 4 * A * C
    if (A <= 0.0000001) or (det < 0) then
        return res
    elseif det == 0 then
        t = -B / (2 * A)
        ix1 = x1 + t * dx
        iy1 = y1 + t * dy
        table.insert(res,{x=ix1,y=iy1})
        return res
    else
        t = (-B + math.sqrt(det)) / (2 * A)
        ix1 = x1 + t * dx
        iy1 = y1 + t * dy
        table.insert(res,{x=ix1,y=iy1})
        t = (-B - math.sqrt(det)) / (2 * A)
        ix2 = x1 + t * dx
        iy2 = y1 + t * dy
        table.insert(res,{x=ix2,y=iy2})
        return res
    end
end

-- eof --




























--# Polygon
-- polygon.lua
-- Papa's game studio (c) 2014

Polygon = class()

-- init --

function Polygon:init(x,y,r,n,c)
    self.x  = x
    self.y  = y
    self.r  = r
    self.n  = n or 64
    self.c  = c or color(128)
    self:createMesh()
end

-- geometry --

function Polygon:createMesh()
    local vs={}
    self.m = mesh()
    for i=1,self.n do
        local a = i/self.n * math.pi * 2
        table.insert(vs, vec2(self.x,self.y) + vec2(math.cos(a), math.sin(a)) * self.r)
    end
    self.m.vertices = triangulate(vs)
    self.m:setColors(self.c)
end

-- draw --

function polygon(x,y,r,n)
    local p = Polygon(x,y,r,n,color(fill()))
    p:draw()
end

function Polygon:draw()
    self.m:draw()
end

-- eof --




























--# Framerate
-- framerate.lua 
-- Copied from (c) Kilam Malik

FrameRateC = class()

-- locals --

local frameRateAvg   =-1
local frameRateTable = {}
local tabIdx         = 1
local tabSize        = 0
local tabMaxSize     =25
local tabSum         = 0

-- init --

function FrameRateC:init(avgSize)
    local i
    tabMaxSize = avgSize
    for i = 1,tabMaxSize do
        frameRateTable[i] = 0
    end
end

-- calc --

function FrameRateC:calc()
    local thisFrameRate = 1.0 / DeltaTime
    tabSum = tabSum - frameRateTable[tabIdx]
    tabSum = tabSum + thisFrameRate
    frameRateTable[tabIdx] = thisFrameRate
    if tabIdx < tabMaxSize then
        tabIdx = tabIdx + 1
    else
        tabIdx = 1
    end
    if tabSize < tabMaxSize then
        tabSize = tabSize + 1
    end
    frameRateAvg = tabSum / tabSize
end

function FrameRateC:getAverageFrameRate()
    return math.floor(frameRateAvg)
end

-- eof --




























--# etc
-- etc.lua
-- Papa's game studio (c) 2014

-- text --

function textline(n)
    return string.rep("-", n)
end

function tabulate(v,w)
    local l = string.len(v) 
    local n = math.max  (w-l,0)
    local s = string.rep(" ",n)
    return v..s
end

function strPercent(n)
    return math.round(n*100).."%"
end

-- print --

function printindent(n,s)
    print(string.rep(" ", 2*n)..s)
end

function printline()
    print(textline(32))
end

-- color --

function grey(c,a)
    a = a or 255
    return color(c,c,c,a)
end

function greyBlend(g,a1,c,a2)
    a2 = a2 or 255
    local clr = grey(g,a1):blend(c)
    clr.a = a2
    return clr
end

function colorIsLight(c)
    return (c.r+c.g+c.b) > 225
end

function colorIsDark(c)
    return (c.r+c.g+c.b) < 175
end

function colorOpaque(c,o)
    return (color(c.r,c.g,c.b,c.a*o))
end

-- math --

function math.round(num)
   return math.floor(num + 0.5)
end

function math.frandom(a,b)
    local d = math.max(1/(a+0.0001),1/(b+0.0001))*1000
    local n1 = math.ceil(d*a)
    local n2 = math.ceil(d*b)
    return math.random(n1,n2)/d
end

function math.degree(l,v,r)
    if l==r then return 1 end
    local d  = r-l
    local p  = v-l
    return math.abs(p/d)
end

function math.between(l,r,a)
    return l+a*(r-l)
end

-- table --

function table.flatcopy(t)
    local new_t = {}           
    local i, v = next(t, nil)  
    
    while i do
        new_t[i] = v
        i, v = next(t, i)
    end
    return new_t
end

function table.index(t, f)
    local i={}
    for _,v in pairs(t) do
        i[v[f]]=v
    end
    return i
end

function table.protect(tbl)
    return setmetatable ({}, {
    __index    = tbl,
    __newindex = function (t, n, v)
        debug.error("attempting to change constant "..tostring(n).." to "..tostring(v))
    end
    })
end

function spairs(t, order)
    local keys = {}
    for k in pairs(t) do keys[#keys+1] = k end
    if order then
        table.sort(keys, function(a,b) return order(t, a, b) end)
    else
        table.sort(keys)
    end
    local i = 0
    return function()
        i = i + 1
        if keys[i] then
            return keys[i], t[keys[i]]
        end
    end
end

-- debug --

function debug.trace()
    local trace = debug.traceback()
    trace = string.gsub(trace,"stack traceback:\n","")
    trace = string.gsub(trace,"string ","")
    trace = string.gsub(trace,"\t","")
    trace = string.gsub(trace," %-%-","")
    trace = string.gsub(trace,"%-%- ","")
    trace = string.gsub(trace,"%.%.%.","")
    trace = string.gsub(trace,'"',"")
    trace = string.gsub(trace,"%[","")
    trace = string.gsub(trace,"%]:"," (")
    trace = string.gsub(trace," in function ","")
    trace = string.gsub(trace,"%.lua","")
    trace = string.gsub(trace,"'"," ")
    trace = string.gsub(trace,":",")")
    trace = string.gsub(trace,".*error \n","")
    trace = string.gsub(trace,".*assert \n","")
    trace = string.gsub(trace,".*trace \n","")
    trace = string.gsub(trace,".*warning \n","")
    print(trace)
end

function debug.error(msg, id)
    local err = "(error) "..msg
    if id then err = id..": "..err end
    print(err)
    debug.trace()
    error()
end

function debug.warning(msg, id)
    local err = "(warning) "..msg
    if id then err = id..": "..err end
    print(err)
    debug.trace()
    displayMode(OVERLAY)
end

function debug.assert(cond, msg, id)
    if not cond then
        debug.error(msg, id)
    end
end

function debug.preventMemoryCrash()
    collectgarbage()
end

-- eof --



























--# Main
-- main.lua
-- Papa's game studio (c) 2014

function setup()
    app = App()
end

function touched(t)
    app:onTouch(t)
end

function draw()
    app:draw()
end

-- eof --




























--# Info
-- info.lua
-- Papa's game studio (c) 2014
------------------------------------------------------
App.Info = {}
App.Info.About=[[
             "I saw you take his kiss!" "'Tis true."
             "O, modesty!" "'Twas strictly kept:
              He thought me asleep; at least, I knew
              He thought I thought he thought I slept."
                     / Coventry Patmore, 
                       The Angel In The House (1854) /

Purpose
~~~~~~~
The aim of "Kolobok" app is to research how we think
each about other and how we suggest what people think 
about us. Of course, such knowledges depends on what 
we can see, what we know and how deeply can we 
understand others. 
  
Here is the wide field for mistakes, mistortions, 
misunderstanding, wrong beliefs, lies and non-adequacies. 
All these deamons form out the topic of this app.
  
The model
~~~~~~~~~
World you can see on your screen contains "rational" 
subjects and is the "rational" in itself. Each rational 
subject has its kind, move/sight ranges, set of 
tactics, etc.
  
The main subject's feature is Reflexive Level —
the ability to deeply reflect perceived world in 
own mind. 
  
Subjects make decisions based on their models of world
and changhe their intention.
  
Universe's laws determine what happen when subjects 
collide.
]]

App.Info.Control = [[
Stage
~~~~~
At the top of the screen you can see the string with 
worlds hierarchy. The main part of the screen shows
you the current world.

Subjects
~~~~~~~~
Rational subjects are represented by colored bodies 
and "reflexive level" depth of eyes. You can select 
the subject to see its internal world. Intentions are 
shown as lightspots. The thin circule signs "sight 
range" and dark spot — the "move range". Some 
objects are opaque and some impassable. If someone 
can't see other object but has suggestion about it, 
such object would be marked by "*". One's attitude 
to other objects is represented by "+" and "-" signs.
Swipe screen's right side to watch subjects' details.

Change reality/imaginarity
~~~~~~~~~~~~~~~~~~~~~~~~~~
There is no technical different between "real" world 
and "imaginary" one. You can provide changes in real 
world as well as in the inner world in some subject's
mind. To add objects to current world use [?] button
or tap and hold at free space.

Explore minds
~~~~~~~~~~~~~
To deep explore someone's mind, tap and hold on 
subject and then fall down by selection nested inner 
worlds. To come back just tap on space.

Run the world
~~~~~~~~~~~~~
Press [Go] button to execute subjects' intentions and 
apply world's laws. It's available in top-level world.
]]

------------------------------------------------------

-- eof --



