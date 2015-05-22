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
	lib: "./" + project.webroot + "/lib/"
};

gulp.task("clean", function (cb) {
	rimraf(paths.lib, cb);
});

gulp.task("copy", ["clean"], function () {
	var bower = {
		"webcomponentsjs": "webcomponentsjs/webcomponents*.js",
		"polymer/src": "polymer/src/**/*.*",
		"polymer": "polymer/*.{html,js}",
		"core-icon": "core-icon/core-icon.{html,css}",
		"core-icons": "core-icons/*-icons.html",
		"core-iconset": "core-iconset/core-iconset.html",
		"core-iconset-svg": "core-iconset-svg/core-iconset-svg.html",
		"core-meta": "core-meta/core-meta.html",
	}

	for (var destinationDir in bower) {
		gulp.src(paths.bower + bower[destinationDir])
		  .pipe(gulp.dest(paths.lib + destinationDir));
	}
});