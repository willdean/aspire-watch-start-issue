# aspire-watch-start-issue
Demonstrates startup problem when using Watch

* Start the apphost with `aspire run` - observe that it starts correctly (worker will complete after 5 seconds, then web will launch)
* Start the apphost with `aspire run --watch` - observe that web never launches because worker never completes.
