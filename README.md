vlcsharp
========

The vlcsharp project provides a platform independent C# framework to allow an 
instance of a native [vlc](http://www.videolan.org/vlc "vlc") media player to be
embedded in a Mono/.NET application.

You get more than just simple bindings, you also get a higher level framework
that hides a lot of the complexities of working with libvlc.

The aim of this project is to port the existing [vlcj](http://caprica.github.com/vlcj "vlcj at github")
project to platform independent C#, implementing as many vlcj features as possible, 
and  supporting as many platforms as possible.

Since this project is, initially at least, a straight port from vlcj there may
be some inherent Java-esque traits in the implementation rather than a best-practices
C# implementation.

News
----

24/06/2012 New project.

Right now this project should be considered experimental. It is possible to create
fully working media player applications at least on Linux using C#/Mono and GTK#.

Most of the functionality from vlcj has been ported to vlcsharp.

The biggest gap right now is in handling of sub-items, and also some of the native
bindings may not be entirely correct. In particular some of the marshalling between
managed code and native code have some errors, and some of the native structures
might only work on a 64-bit OS.

Other platforms and user interface toolkit support will be added at a later date.

There are no official downloads available as of yet - the best way to work with
this project for the time being is to check out the entire code-base from github
and incorporate it into your development environment as a library project.

Having said that, it is actually very easy right now to create a feature-rich media 
player for audio and/or video playback embedded in your own GTK# application. All
of the expected playback controls like play/pause/stop, volume/mute, chapter selection,
DVD menu navigation, sub-titles, media meta data, some media track information and
so on all works. Also various other information such as the list of available audio
and video filters, audio outputs and audio devices also works.

Documentation
-------------

The vlcsharp project page is at [github](http://caprica.github.com/vlcsharp "vlcsharp at github").

Documentation is being made available at [Caprica Software](http://www.capricasoftware.co.uk/wiki "Caprica Software WIKI"). 

The C# API mirrors as much as possible the Java API of vlcj, so all vlcj documentation
and vlcj examples should be equally applicable to C# projects.

Support
-------

Support for commercial projects is provided exclusively on commercial terms -
send an email to the following address for more information:

> mark [dot] lee [at] capricasoftware [dot] co [dot] uk

License
-------

The vlcsharp framework is provided under the GPL, version 3 or later.

If you want to consider a commercial license for vlcsharp that allows you to use and 
redistribute vlcsharp without complying with the GPL then send your proposal to:

> mark [dot] lee [at] capricasoftware [dot] co [dot] uk
