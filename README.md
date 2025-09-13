# Art Reference Timed-Viewer
This app allows you to set up timed-reference viewing sessions for drawing/painting/... practice using your own library of references.

# THIS IS ONLY A WORKING PROTOTYPE
The program is very unpolished; the code is a mess, likely not very extensible, features are missing, the way of storing and retrieving usage statistics is not suited for longer use timeframes, the UI is subject to change (I personally like the old Windows hobby program aesthetic, but I digress), and RAM consumption is needlessly high, as is the compiled binary size. The plan is to rewrite the whole thing in a different framework and language, eventually.
Having non-(.jpg/.png) format files renamed to (.jpg/.png) in your reference folder(s) can result in a crash, as the program currently takes the supplied file extensions at face value.

# Usage 
The program allows you to select one root folder, and then either further select (standard mode) or deselect (blacklist mode) respective album subfolders. The reference images need not be subfiles of the albums - further folder layering is permitted, but only top-level albums can be (de)selected.
More information on how to use the program is displayed upon pressing the "Help" button.

# Context
Timed drawing (etc.) is a common technique used in arts training and education, both in person and online through various websites offering timed references. A time limit is placed on the viewed references, after which either the pose of the model (real life) or the reference photo (computer-assisted) changes; depending on the time constraint, the artist is forced to adjust their approach to the image, potentially having to use more sparse and economical lines or otherwise capturing the likeness within the alloted time. For example, time windows under a minute are often used for "gesture" (simplified pose) practice.

# Releases
The supplied release is built targeting a win-x86 runtime; if you wish to run the application somewhere else, you may have to build it yourself.
