# CRON-JOB-URL
---------------------------

Cron job url a simple c# application for running tasks based on a cron schedule.

---------------------------

[**Cron Schedules**](https://github.com/kevincolyar/CronNET/blob/master/Readme.md)

---------------------------

## setting
- Properties\Settings.settings
    ```sh
    <Settings>
        <Setting Name="BaseUrl" Type="System.String" Scope="Application">
        <Value Profile="(Default)">http://localhost/api/timestamp</Value>
        </Setting>
        <Setting Name="CronJob" Type="System.String" Scope="Application">
        <Value Profile="(Default)">* * * * *</Value>
        </Setting>
    </Settings>
    ```
- Or CRON-JOB-URL.exe.config
---------------------------

- Library
[**CronNET**](https://github.com/kevincolyar/CronNET)