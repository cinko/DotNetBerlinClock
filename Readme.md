# The Berlin Clock

The Berlin Uhr (Clock) is a rather strange way to show the time. On the top of the clock there is a yellow lamp that
blinks on/off every two seconds. The time is calculated by adding rectangular lamps.
 
The top two rows of lamps are red. These indicate the hours of a day. In the top row there are 4 red lamps. Every lamp
represents 5 hours. In the lower row of red lamps every lamp represents 1 hour. So if two lamps of the first row and
three of the second row are switched on that indicates 5+5+3=13h or 1 pm.
 
The two rows of lamps at the bottom count the minutes. The first of these rows has 11 lamps, the second 4. In the
first row every lamp represents 5 minutes. In this first row the 3rd, 6th and 9th lamp are red and indicate the first
quarter, half and last quarter of an hour. The other lamps are yellow. In the last row with 4 lamps every lamp
represents 1 minute.

One can be seen [here](http://uniqueclocks.co.uk/media/berlin~clock.jpg~1.gif)

## The brief

We have created a number of acceptance tests for the Berlin Clock and your challenge is to get them passing.

## Some hints
ensure that your machine has visual studio (we used 2013), and the following 2 extensions: 1) Nuget 2) 'specflow for visual studio 2013' (or appropriate). These can be installed under menu tools, Extensions and updates.	

The exercise contains an un-implemented Specflow BDD test (see http://www.specflow.org/getting-started/). The use of BDD in this instance is to provide you with our definition of done for the task.

Please ensure that you are familiar with our values in the instructions project.  They are important to us.

* simple, elegant code that reads like a narrative
* thinking about the code more than the writing of the code (we spend a lot of time thinking/debating about what we are writing)
* transparency and feedback to support continuous learning
* excellent testing that acts as documentation for the code
* challenging boundaries where necessary

## Remarks 1,2,3
Code related to these remakrs is writting only to satisfy BDD tests.
When it comes to any input it is fine to show different outputs for tests like 00:00:00 and 24:00:00.
However, when talking about a real clock these outputs are incorrect because inputs like 00:00:00 and 24:00:00 are exactly the same time of day therefore clock cannot show two different outputs for the same time at the same time.
When talking about real clock, the code in remarks should be changed according to time format decided, whether it is 00:00:00 or 24:00:00 for midnight.
