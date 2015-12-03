# Quick Ping
Multi-threaded ping tool based on WMI. Supports getting ping results from remote PC in domain.
## Motivation
A multi-threaded ping tool based on WMI. Supports getting ping results from remote PC in domain (needs to be logged on as domain administrator). For example in a global company with multiple sites, for a person located in Hong Kong office, he / she can ping Singapore server from Sydney server without having to remotely connect to Sydney server first.
## Screenshot
<img class="alignnone size-full wp-image-12" src="http://carlchang.blog.com/files/2015/12/Screenshot_QP.png" alt="" width="767" height="390" />
## Language &amp; Requirement
<ul>
	<li>VB application written in VB.net</li>
	<li>.Net framework 4.5 or above.</li>
</ul>
## Features
<ul>
	<li>Multi-threaded ping echos are sent to avoid having to wait for previous echos to return, delaying further echos to be sent.</li>
	<li>Automatically generating a list of domain controllers if the local host is in domain. To get ping results from remote host (most likely to be a DC), you need to log in with a domain administrator account or other accounts with permissions to remotely log in to WMI (Windows Management Instrumentation).</li>
	<li>A chart will be generated for each ping session as shown in the screenshot.</li>
</ul>
## Note
<ul>
	<li>None</li>
</ul>
