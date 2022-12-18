# Riwmorld-FixAnimalCount

[![Version](https://img.shields.io/badge/Rimworld-1.4-green.svg)](http://rimworldgame.com/)
[![GitHub release (latest by date)](https://img.shields.io/github/v/release/angelolocritani/Rimworld-FixAnimalCount)](https://github.com/angelolocritani/Rimworld-FixAnimalCount/releases/latest)
# FixAnimalCount

Fixes a glitch on the auto-slaughter total animals column.

In vanilla auto-slaughter based on total number is only perfomed using allowed slaughterable animals

Example:
- total limit = 8
- males = 5
- pregnant females = 3
- non-pregnant females = 2
- slaughter pregnant = OFF

total (as displayed in GUI) = male + pregnant females + non-pregnant females = **10**

even if 10 > 8, no slaughter occurs because internally the "real" calculation considers only 5 males + 2 non-pregnant females = total **7**

this mod fixes the value of the total count, considering pregnant females only if the specifich check is toggled: it aligns the logic to how bonded animal are managed. Indeed if "slaughter bonded" is NOT check, they are NOT counted in total column.

[![Steam download](https://img.shields.io/steam/downloads/2903360884?logo=steam)](https://steamcommunity.com/sharedfiles/filedetails/?id=2903360884)
