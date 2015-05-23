//document.addEventListener('polymer-ready', function() {
	// var navicon = document.getElementById('navicon');
	// var drawerPanel = document.getElementById('drawerPanel');
	// navicon.addEventListener('click', function() {
		// drawerPanel.togglePanel();
	// });
//});

var tmpl = document.querySelector('#tmpl');
// tmpl.selected = 1;
// tmpl.page = 'home';
tmpl.heading = 'Polycast';
tmpl.data = generateContacts();

// tmpl.addEventListener('template-bound', function(){
	// console.log(document.querySelector('core-menu'));
// });

function generateContacts() {
	var data = [];
	for(var i=0; i<1000; i++){
		data.push({
			name: faker.name.findName(),
			avatar: faker.internet.avatar()
		});
	}
	return data;
}