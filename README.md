[![GitHub release](https://flat.badgen.net/github/release/adasjusk/Announcer)](https://github.com/adasjusk/Announcer)
[![LabAPI Version](https://flat.badgen.net/static/LabAPI%20Version/v1.1.7)](https://github.com/northwood-studios/LabAPI)
[![License](https://flat.badgen.net/github/license/adasjusk/Announcer)](https://github.com/adasjusk/Announcer/blob/main/LICENSE)
# Announcer
An SCP:SL plugin that scans the facility and announces who is still alive. Requires LabAPI, not Exiled.

> [!NOTE]
> So this is a Announcer updated version of this [Thundermaker300/Scanner](https://github.com/Thundermaker300/Scanner) <br>
> but this repo aims to update it and fix bugs

Config:
```yaml
Perform regular scanning throughout the round,
regular_scanning: true
Time in seconds the scan takes to complete,
scan_length: 90
Continue scanning after the nuke detonates?,
scan_after_nuke: false
CASSIE message when scan starts,
scan_start_message_cassie: FULL FACILITY SCAN IN {LENGTH} SECONDS
Caption when scan starts,
scan_start_message_caption: Full facility scan in {LENGTH} seconds
CASSIE message when nobody is detected,
scan_nobody_message_cassie: SCAN COMPLETE . NO SUBJECTS DETECTED
Caption when nobody is detected,
scan_nobody_message_caption: Scan complete. No subjects detected
Minutes to wait after a scan finishes before announcing next scan,
delay_after_scan_minutes: 12
```