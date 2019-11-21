# CRON-JOB-URL
---------------------------

![2019-11-21_112219](https://user-images.githubusercontent.com/8300694/69304245-86677480-0c52-11ea-87d1-8371b558b539.png)

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
