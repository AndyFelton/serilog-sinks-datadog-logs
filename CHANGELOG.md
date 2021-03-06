# Changelog

## 0.3.0

* HTTP is now the default sending method for logs (#24). This is a **breaking change** for
users that were using a custom endpoint. TCP client can still be used by adding the `useTCP: true`
in the `DatadogConfiguration` object.

## 0.2.0

* Strong named the assembly (#22)
* Allow configuration from `appsettings.json` file (#11)

## 0.1.5

* Change severity field from "Level" to "level" (#15)
* Bug fix: Make sure the socket gets reopen when an exception is triggered (#14)

## 0.1.4

* Enabled custom source, service, host and tags

## 0.1.3

* Created a Serilog Sink to forward logs to Datadog (#2)
