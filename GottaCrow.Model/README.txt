April 11
I want this model to be very simple to start.
I am mimicking the Ninja Model example from J.Lermans EF 6 plural sight course.
We really only need a few classes for initial DbContext.
-JobSearchActivity(event):
	The job seeker does an activity from the list/enumeration of JobSearchActivityType. THe event happens on a certain date and there is usually but not always another person involved
-Company (Employer or prospective employer):
	Pretty self-expalnatory.
-Person (not sure whether to call this entity a "Contact"):
	The person contacted. They usually have a phone number and email.  Since this is a computer app. doesn't make much sense to add a person with no way to contact them.
	TO-DO: Look for examples of how other apps have modeled contact information: Phone, email, address, etc.

	April 12
	All of the classes are in NameSpace: JobSearch.Model
	April 26
	After seeing some of the DDD Plural sight class, I realize that the JobSearchActivity entity is not the correct aggregate root.
	Therefore, insted of refactoring I am going to refactor considerably.
	1) Create a Contacts class library
	2) The aggregate root that I really want is a Position.
	       Position is an entity and is made up of
		     - JobDescription
			 - Employer
			 - List<JobSearchActivitie>
			 - List<Contact>

