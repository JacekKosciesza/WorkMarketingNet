module.exports = function() {
	var app = './app/';
	var client = './src/client/';
	var clientApp = client + 'app/';
	var root = './';
	var server = './src/server/';
	var temp = './.tmp/';
	
	
	var config = {
		/**
		 * File paths
		 */
	 	app: app,
		alljs: [
			'./src/**/*.js',
		  './*.js'
		],
		build: './wwwroot/', // or './dist/' or './production'
		index: client + 'index.html',
		client: client,
		js: [
			clientApp + '**/*.module.js',
			clientApp + '**/*.js',
			'!' + clientApp + '**/*.spec.js'
		],
		css: temp + 'colors.css',
		html: clientApp + '**/*.html',
		fonts: './bower_components/font-awesome/fonts/**/*.*',
		images: 'images/**/*',
		typeScriptFiles: app + '**/*.ts', 
//		[
//			app + 'scripts/**/*.ts',
//			app + 'elements/**/*.ts'
//		],
		lessFiles: app + '**/*.less',
//		[
//			app + 'styles/**/*.less',
//			app + 'elements/**/*.less'
//		],
		root: root,
		server: server,
		temp: temp,
		precache: {
			glob: '{elements,js,styles}/**/*.*',
			files: [
				'index.html', './',
				'bower_components/webcomponentsjs/webcomponents.min.js'
			],
			output: 'precache.json'
		},
		
		/**
		 * Bower and NPM locations
		 */
		 bower: {
			 json: require('./bower.json'),
			 directory: './bower_components/',
			 ignorePath: '../..'
		 },
		 packages: [
			 './package.json',
			 './bower.json'
		 ],
		 
		 /**
		  * Autoprefixer
		  */
		 autoprefixerOptions: {
			browsers: [
				'ie >= 10',
			  	'ie_mob >= 10',
			  	'ff >= 30',
				'chrome >= 34',
				'safari >= 7',
				'opera >= 23',
				'ios >= 7',
				'android >= 4.4',
				'bb >= 10'
			] 
		 },
					 
		 /**
		  * Browser Sync
		  */
		  browserReloadDelay: 1000,
		 
		 /**
		  * Node settings
		  */
		  defaultPort: 8000,
		  nodeServer: './src/server/app.js'
	};
	
	config.getWiredepDefaultOpitons = function() {
		var options = {
			bowerJson: config.bower.json,
			directory: config.bower.directory,
			ignorePath: config.bower.ignorePath
		};
		return options;
	};
	
	return config;
};