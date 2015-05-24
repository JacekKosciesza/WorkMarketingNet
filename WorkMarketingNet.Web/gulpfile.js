/// <binding Clean='clean' />

/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
	rimraf = require("rimraf"),
	fs = require("fs");

eval("var project = " + fs.readFileSync("./project.json"));

var paths = {
	bower: "./bower_components/",
	lib: "./" + project.webroot + "/lib/",
	wwwroot: "./" + project.webroot + "/"
};

gulp.task("clean", function (cb) {
	rimraf(paths.lib, cb);
});

gulp.task("copy", ["clean"], function () {
	var bower = {
		//"context-free-parser": "context-free-parser/**/*.*",
		//"core-a11y-keys": "core-a11y-keys/**/*.*",
		//"core-ajax": "core-ajax/**/*.*",
		//"core-animated-pages": "core-animated-pages/**/*.*",
		//"core-animation": "core-animation/**/*.*",
		//"core-collapse": "core-collapse/**/*.*",
		//"core-component-page": "core-component-page/**/*.*",
		//"core-docs": "core-docs/**/*.*",
		//"core-doc-viewer": "core-doc-viewer/**/*.*",
		//"core-drag-drop": "core-drag-drop/**/*.*",
		//"core-drawer-panel": "core-drawer-panel/**/*.*",
		//"core-dropdown": "core-dropdown/**/*.*",
		//"core-dropdown-menu": "core-dropdown-menu/**/*.*",
		//"core-field": "core-field/**/*.*",
		//"core-focusable": "core-focusable/**/*.*",
		//"core-header-panel": "core-header-panel/**/*.*",
		//"core-icon": "core-icon/**/*.*",
		//"core-icon-button": "core-icon-button/**/*.*",
		//"core-icons": "core-icons/**/*.*",
		//"core-iconset": "core-iconset/**/*.*",
		//"core-iconset-svg": "core-iconset-svg/**/*.*",
		//"core-image": "core-image/**/*.*",
		//"core-input": "core-input/**/*.*",
		//"core-item": "core-item/**/*.*",
		//"core-label": "core-label/**/*.*",
		//"core-layout-grid": "core-layout-grid/**/*.*",
		//"core-layout-trbl": "core-layout-trbl/**/*.*",
		//"core-list": "core-list/**/*.*",
		//"core-localstorage": "core-localstorage/**/*.*",
		//"core-media-query": "core-media-query/**/*.*",
		//"core-menu": "core-menu/**/*.*",
		//"core-menu-button": "core-menu-button/**/*.*",
		//"core-meta": "core-meta/**/*.*",
		//"core-overlay": "core-overlay/**/*.*",
		//"core-pages": "core-pages/**/*.*",
		//"core-range": "core-range/**/*.*",
		//"core-resizable": "core-resizable/**/*.*",
		//"core-scaffold": "core-scaffold/**/*.*",
		//"core-scroll-header-panel": "core-scroll-header-panel/**/*.*",
		//"core-scroll-threshold": "core-scroll-threshold/**/*.*",
		//"core-selection": "core-selection/**/*.*",
		//"core-selector": "core-selector/**/*.*",
		//"core-shared-lib": "core-shared-lib/**/*.*",
		//"core-signals": "core-signals/**/*.*",
		//"core-splitter": "core-splitter/**/*.*",
		//"core-style": "core-style/**/*.*",
		//"core-tests": "core-tests/**/*.*",
		//"core-toolbar": "core-toolbar/**/*.*",
		//"core-tooltip": "core-tooltip/**/*.*",
		//"core-transition": "core-transition/**/*.*",
		//"faker": "faker/**/*.*",
		//"font-roboto": "font-roboto/**/*.*",
		//"google-code-prettify": "google-code-prettify/**/*.*",
		//"marked": "marked/**/*.*",
		//"marked-element": "marked-element/**/*.*",
		//"more-routing": "more-routing/**/*.*",
		//"paper-button": "paper-button/**/*.*",
		//"paper-checkbox": "paper-checkbox/**/*.*",
		//"paper-dialog": "paper-dialog/**/*.*",
		//"paper-dropdown": "paper-dropdown/**/*.*",
		//"paper-dropdown-menu": "paper-dropdown-menu/**/*.*",
		//"paper-fab": "paper-fab/**/*.*",
		//"paper-icon-button": "paper-icon-button/**/*.*",
		//"paper-input": "paper-input/**/*.*",
		//"paper-item": "paper-item/**/*.*",
		//"paper-menu-button": "paper-menu-button/**/*.*",
		//"paper-progress": "paper-progress/**/*.*",
		//"paper-radio-button": "paper-radio-button/**/*.*",
		//"paper-radio-group": "paper-radio-group/**/*.*",
		//"paper-ripple": "paper-ripple/**/*.*",
		//"paper-shadow": "paper-shadow/**/*.*",
		//"paper-slider": "paper-slider/**/*.*",
		//"paper-spinner": "paper-spinner/**/*.*",
		//"paper-tabs": "paper-tabs/**/*.*",
		//"paper-toast": "paper-toast/**/*.*",
		//"paper-toggle-button": "paper-toggle-button/**/*.*",
		//"polymer": "polymer/**/*.*",
		//"polymer-core-elements": "polymer-core-elements/**/*.*",
		//"polymer-paper-elements": "polymer-paper-elements/**/*.*",
		//"polymer-test-tools": "polymer-test-tools/**/*.*",
		//"prettify-element": "prettify-element/**/*.*",
		//"sampler-scaffold": "sampler-scaffold/**/*.*",
		//"web-animations-js": "web-animations-js/**/*.*",
		//"webcomponentsjs": "webcomponentsjs/**/*.*"
	}

	for (var destinationDir in bower) {
		gulp.src(paths.bower + bower[destinationDir])
		  .pipe(gulp.dest(paths.lib + destinationDir));
	}

	var custom = {
		"elements": "Elements/**/*.*"		
	}

	for (var destinationDir in custom) {
		gulp.src(custom[destinationDir])
		  .pipe(gulp.dest(paths.lib + destinationDir));
	}

	var other = {
		"css": "Styles/**/*.*",
		"js": "Scripts/**/*.*"
	}

	for (var destinationDir in other) {
		gulp.src(other[destinationDir])
		  .pipe(gulp.dest(paths.wwwroot + destinationDir));
	}
});