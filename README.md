# _Hangman_

#### _Hangman Game, 03.12.2020_

#### By _**Tiffany Siu and Jiwon Han**_

[![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](https://www.repostatus.org/badges/latest/inactive.svg)](https://www.repostatus.org/#inactive)
![LastCommit](https://img.shields.io/github/last-commit/tsiu88/Hangman)
![Languages](https://img.shields.io/github/languages/top/tsiu88/Hangman)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---
## Table of Contents
1. [Description](#description)
2. [Setup/Installation Requirements](#setup/installation-requirements)
    - [Requirements to Run](#requirements-to-run)
    - [Instructions](#instructions)
    - [Other Technologies Used](#other-technologies-used)
3. [Specifications](#specifications)
4. [Known Bugs](#known-bugs)
5. [Support and Contact Details](#support-and-contact-details)
6. [License](#license)
---
## Description

#### 3/12 Work from Home Summary
- Music Organizer
  - practice in objects within objects
- Upper Cohort Trade Show
- Hangman
  - Not finished at 5pm, currently works due to being finished later
- Struggles: Finishing hangman on time, dynamic picture source links, figuring out how to get data types to compare and display properly

This application practices MVC and objects within objects in a game of hangman where the user guesses letters and the answer is from a hardcoded list.  The user can't guess the same item htt was already guessed or items that haven't healed.  The picture of a hangman dynamically changes as the user guesses wrongly.

## Setup/Installation Requirements

### Requirements to Run
* _.NET Core_
* _ASP.NET Core MVC_
* _Command Prompt_
* _Web Browser_

### Instructions

*This page may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Clone the [repository](https://github.com/TSiu88/Hangman.git) from this [GitHub page](https://github.com/TSiu88)
3. Use a command line interface to move to the repository's directory with `cd project-directory`
4. Run `dotnet restore` and `dotnet build` in command line interface of the repository's directory
5. Run `dotnet run` to start up the program in the command line interface
6. Type the URL listed under "Now listening on:" into a web browser 

## Other Technologies Used
* _C#_
* _MSTest_
* _HTML_
* _CSS_
* _Razor_
* _Markdown_

## Specifications

* _Computer choses a word from a list to use for the game_
  * _Example Input: Game start_
  * _Example Output: Random word chosen from a list_
* _Word displayed as blanks for each letter._
  * _Example Input: word="word"_
  * _Example Output: show="_ _ _ _"_
* When guess right, show letters in blanks for that letter
  * _Example Input: word="word", guess=r_
  * _Example Output: show="_ _ r _"_
* When guess wrong, show next image - have 6 wrong guesses before game over
  * _Example Input: word="word", guess=s_
  * _Example Output: message="incorrect!"_
* Display if correct or incorrect when guessing and change styling, how many wrong guesses have left
  * _Example Input: word="word", guess=s_
  * _Example Output: message="incorrect!", wrong guesses left=5_
* If try to guess same letter twice, show error and ask for another letter
  * _Example Input: previous guesses=s, guess=s_
  * _Example Output: message="already guessed!"_

## Known Bugs

_There are currently no known bugs in this program._

## Support and contact details

_If there are any question or concerns please contact us at our email: [Tiffany Siu](mailto:tsiu88@gmail.com) or [Jiwon Han](mailto:jiwon1.han@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu, Jiwon Han_**
