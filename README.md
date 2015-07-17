# Greenfield Framework for Server Side API app 

As a developer there is often the opportunity to start from a green field in an application. We rather get brownfield OR extension: fixing / extending existing functionality. 

In most cases this is still a lot of fun, but there are cases in which we get to say "I wish this had been done differently". And, to be absolutely fair, in most cases we have our past selves to blame =).

Anyway, in my quest for all the knowledge and wisdom in the universe (until I find the hitchhikers guide to the galaxy, that is) I decided to wrap up in a single place some of the interesting patterns that make an applications extensible and fun to code against.

(but, in all truth, I also needed a sand box to try new patterns and implementation before tackling them on a project.)

I (will try to) update this as time allows with the latest and greatest patterns / easy to use packages I have stumbled across - or will stumble across.

What this implements now: 

* Separation of concerns between projects. 
* Dependency Injection for repository + services (business layer) 
* Repository Layer pattern. 
* Unit Testing (For API) 
* RESTful API design to service multiple clients (mobile, browser, other).
* Concise code notation.
* .gitignore from [here](https://github.com/github/gitignore/blob/master/VisualStudio.gitignore) but do no use Nuget Restore (or at least read [this](http://www.xavierdecoster.com/migrate-away-from-msbuild-based-nuget-package-restore))! 

Uses:

* .NET Framework. 
* ORM: NORMAN (not open source yet, but pretty nifty ORM package by Christian Jungers).
* Dependency Container: Unity
* Visual Studio Native: Tests
* Brain: Andrea + many other developers I had the luck and pleaseure to work and play with.


Implement next:

* Validations for the controllers.
* Using DTOs AND mapping (even though the use ofd DTOs is somewhat controversial and advised only if strictly required?).
* OAuth / authentication.
* Config / prebuilt events for local / deployment.
* NHibernate for the persistence layer (as NORMAN is not open source yet).
* Unit tests for the business logic.
* Mocks for the business logic to be injected from the tests(?)
* Multitenancy





