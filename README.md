# File Line Editor

![GitHub](https://img.shields.io/github/license/c0der4t/FileLineEditor?style=for-the-badge)

Quickly and easily add text infront of or behind of lines in a file.
This build comes with a registration module which can be used if needed.

The system can make backups of the file to ensure that any errors during the processing of the file does not affect the original file.

The system uses a worker thread to process the actual file so the UI will not lock up when processing big files.

Using The view from halfway down (from Bojack Horseman) as an example.

Example file before processing:

```text
The weak breeze whispers nothing
the water screams sublime.
His feet shift, teeter-totter
deep breaths, stand back, it’s time.

Toes untouch the overpass
soon he’s water-bound.
Eyes locked shut but peek to see
the view from halfway down.

A little wind, a summer sun
a river rich and regal.
A flood of fond endorphins
brings a calm that knows no equal.

You’re flying now, you see things
much more clear than from the ground.
It's all okay, or it would be
were you not now halfway down.

Thrash to break from gravity
what now could slow the drop?
All I’d give for toes to touch
the safety back at top.

But this is it, the deed is done
silence drowns the sound.
Before I leaped I should've seen
the view from halfway down.

I really should’ve thought about
the view from halfway down.
I wish I could've known about
the view from halfway down—
```

Example file after processing:

```text
NEW LINE The weak breeze whispers nothing LINE END
NEW LINE the water screams sublime. LINE END
NEW LINE His feet shift, teeter-totter LINE END
NEW LINE deep breaths, stand back, it’s time. LINE END
NEW LINE  LINE END
NEW LINE Toes untouch the overpass LINE END
NEW LINE soon he’s water-bound. LINE END
NEW LINE Eyes locked shut but peek to see LINE END
NEW LINE the view from halfway down. LINE END
NEW LINE  LINE END
NEW LINE A little wind, a summer sun LINE END
NEW LINE a river rich and regal. LINE END
NEW LINE A flood of fond endorphins LINE END
NEW LINE brings a calm that knows no equal. LINE END
NEW LINE  LINE END
NEW LINE You’re flying now, you see things LINE END
NEW LINE much more clear than from the ground. LINE END
NEW LINE It's all okay, or it would be LINE END
NEW LINE were you not now halfway down. LINE END
NEW LINE  LINE END
NEW LINE Thrash to break from gravity LINE END
NEW LINE what now could slow the drop? LINE END
NEW LINE All I’d give for toes to touch LINE END
NEW LINE the safety back at top. LINE END
NEW LINE  LINE END
NEW LINE But this is it, the deed is done LINE END
NEW LINE silence drowns the sound. LINE END
NEW LINE Before I leaped I should've seen LINE END
NEW LINE the view from halfway down. LINE END
NEW LINE  LINE END
NEW LINE I really should’ve thought about LINE END
NEW LINE the view from halfway down. LINE END
NEW LINE I wish I could've known about LINE END
NEW LINE the view from halfway down— LINE END
```

Some screenshots of the system:

![Screenshot 1](https://github.com/c0der4t/FileLineEditor/blob/main/img/screenshot1.jpg)

![Screenshot 2](https://github.com/c0der4t/FileLineEditor/blob/main/img/screenshot2.jpg)
