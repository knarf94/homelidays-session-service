**I wrote the "Homelidays Session Service" with my fellow collegues when I was working for Homeaway. This code has been initally hosted at Codeplex. [The codeplex archive can still be downloaded](https://archive.codeplex.com/?p=sessionservice). When Codeplex was decommissioned, I moved the code to https://www.github.com/Homeaway/homelidays-session-service from where I have cloned it before Homeaway decided to simply drop it without notice. I am leaving the code here for posterity :-)**

**Homelidays Session Service has been successfully used on production environment from November 2010 to May 2014 at [http://www.homelidays.com](http://www.homelidays.com/ "Homelidays") on high traffic pages. (up to 40 000 active sessions if I remember correctly).**

Classic ASP was widely used all around the world and it's so hard to migrate from Classic ASP to ASP.NET!

"Homelidays Session Service" makes it easier for ASP developers to share the Classic ASP Session State with ASP.NET by storing the Session State into a SQL Server database. Homelidays Session Service eases a step by step migration from ASP to ASP.NET.

![AHomelidays Session Service Global Overview](../../wiki/How-does-the-Homelidays-Session-Service-work_1.png)

Fig1\. Session Service global overview

Storing the session state in an external storage (Microsoft SQL Server database):

*   Eases the migration from classic ASP to ASP.NET allowing a step by step migration;
*   Allows a Classic ASP site using "Session" to be stateless.

It's developed in C++ for Classic ASP and in C# for ASP.NET.

[How does the Homelidays Session Service work?](../../wiki/How-does-the-Homelidays-Session-Service-work%3F)

[Install the Homelidays Session Service](../../wiki/Install-the-Homelidays-Session-Service)

[Use the Session Service in classic ASP code](../../wiki/Use-the-Session-Service-in-classic-ASP-code)

[Use the Session Service in ASP.NET code](../../wiki/Use-the-Session-Service-in-ASP.NET-code)
