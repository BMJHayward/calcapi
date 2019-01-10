### Simple Calculator API

+ .NET 4.5, made with monodevelop
+ 4 endpoints for add, subtract, multiply and divide, arguments are type:double and optional
+ build and run in visual studio or monodevelop or your preferred tool chain
+ calcFlask.py included for comparison between .NET and flask frameworks, see file for instructions to run

e.g. on localhost:8080/, hit the below endpoints for a response:

GET: api/calc/getadd/1/1
GET: api/calc/getsub/1/1
GET: api/calc/getmul/1/1
GET: api/calc/getdiv/1/1

e.g. 
$ curl http://127.0.0.1:8080/api/calc/getdiv/1/10
$ {"operation":"divide","arguments":[1.0,10.0],"result":0.1}b

Built with:
=== MonoDevelop ===

Version 7.7 (build 1869)
Installation UUID: 5746907f-c48c-46a5-a87b-fdb56c8b814d
	GTK+ 2.24.32 (Mint-Y theme)

=== Mono Framework MDK ===

Runtime:
	Mono 5.16.0.220 (tarball Wed Jan  2 21:11:00 UTC 2019) (64-bit)

=== NuGet ===

Version: 4.7.0.5148

=== .NET Core ===

Runtime: Not installed
SDK: Not installed
MSBuild SDKs: /usr/lib/mono/msbuild/15.0/bin/Sdks

=== Build Information ===

Release ID: 707001869
Git revision: f0f3d1d931d44682f076dde486ecec835f705b8d
Build date: 2018-11-29 14:54:14-05

=== Operating System ===

Linux
Linux 4.18.0-13-generic #14~18.04.1-Ubuntu SMP Thu Dec 6 14:09:52 UTC 2018 x86_64


