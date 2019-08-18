## Ok, it’s finally happening. I’m finally doing it!

I’m going to move the backend of my website from a simple text file to a real database! You can read more about this on my [blawg](http://danielsabbaghcom-website.s3-website-us-east-1.amazonaws.com/#/blog/10) and at the [readme for the back-end of the site](https://github.com/dsab123/website-backend-blogposthandler).

But this time I won’t be interfacing with the database (herm, text file) through a Lambda function — I’ll be writing a .NET WebAPI project to do that. The reasons are not many and not complicated, so in an effort to remain as vague as possible I’ll just say that its because I haven’t touched a WebAPI project in a while and want to pick up those skills again.

Ok, first step is installing .NET for Mac on my sweet little MacBook Air. Painless, thanks to Microsoft’s installation docs: https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/intro

The first iteration of this was written as a Lambda function; I’ll improve upon the design as I go along (at least, I _assume_ I've gotten better at software stuff since I wrote that lambda).

And hey, maybe since (to my small brain) a straightforward CRUD-y backend lends itself to CRUD operations in an easier way than Lambdas do, I might actually put something on GitHub that’s not just GETful, but fully-fledged RESTful!