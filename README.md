## My first fsharp repo.

### F# set up on Ubuntu 15.10

Information from :
http://fsharp.org/use/linux/ and http://download.mono-project.com/repo/debian

Get keys:

sudo apt-key adv --keyserver keyserver.ubuntu.com --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF

Add mono to sources:
deb http://download.mono-project.com/repo/debian wheezy main
to
/etc/apt/sources.list.d/mono-xamarin.list

echo "deb http://download.mono-project.com/repo/debian wheezy-apache24-compat main" | sudo tee -a /etc/apt/sources.list.d/mono-xamarin.list


Install:
sudo apt-get install mono-complete fsharp

Useful looking highlighting for atom (takes a while to get dependences when atom is next run):

apm install ionide-installer

### Checking Mono is working
From http://www.mono-project.com/docs/getting-started/mono-basics/

See 'check_mono_is_working' directory

To compile: mcs hello.cs
To run mono.exe

Expect to see 'Hello Mono world' returned to stout

## Very first f#
See hello_world.fs
To compile: fsharpc <file>.fs
To Run: mono hello_world.exe

http://www.codeproject.com/Articles/738093/Fsharp-Hello-World for detailed notes on concepts here

## Things to do

http://channel9.msdn.com/Blogs/David+Gristwood/An-Introduction-to-F-with-Don-Syme-1-of-4
http://fsharpforfunandprofit.com/learning-fsharp/ (nice list of dos and don'ts for learngin f#, esp as purely functional language)
