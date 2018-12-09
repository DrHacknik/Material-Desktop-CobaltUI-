## This is the dependency base. 

## How modules work

Most modules are entirely web-based. So, in order to make development easy I used the Cef (Chromium Embedded framework) and developed a webview system. 
Modules are usually two files, and one folder. The first file being `meta.json'.` This file contains all Meta data that Cobalt can read and then display on screen for the user to see. The `modulename.ini` file contains all the module information for the webview to load. Such as how large the window needs to be, it's color, url, and other important option. It's usually meant to be left alone, so that you don't break your modules. Last but not least, there is the icons folder. This folder can contain any needed module icons; this information is actually stored within `meta.json` and can be parsed at any given time. The `.ini` module file can also contain this information for additional icons; if wanted. 


## How to make modules easily

Cobalt will include a module wrapper tool in order to actually make modules and deploy them easily. That and it will create both the module `ini` and `json` with the 
required dependencies that you can list when making a module. That, and you can preview your module in action (in real time.)

## Possible Variables: 

### Example: 
```ini
;This is webview based configuration settings. 
;Don't mess with this, or you may break the app. 
[webview]
webview_ver=65              --Minimum supported Chromium Version
webview_url=www.url.com     --WebView, URL to load
webview_size_width=1280     --WebView, Window Width
webview_size_height=768     --WebView, Window Height
webview_is_oath=false       --WebView, is the URL a OATH URL?
webview_scrollbars=true     --WebView, does it need scrollbars enabled?
webview_color=deepblue      --WebView, what colors does it need to be.
webview_controls=full       --WebView, what controls does it need. "minimal_max, minimal_close, full, none." 
webview_allow_lockscreen=false --Allow this webview to run on the Lockscreen?
webview_sizable=true        --WebView, can the window be resized?

;This is app specific configuration. 
;Don't mess with this, unless you know what to do. 
[app_options]
allow_lockscreen_svc=true   --Allow the service to run on the lockscreen instance.
allow_desktop_svc=true      --Allow the service to run on the desktop instance. 
refresh_svc_rate=10         --The refresh rate (in intervals) for the service/s.
```