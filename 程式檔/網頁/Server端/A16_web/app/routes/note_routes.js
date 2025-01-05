module.exports = function(app,db) {
	var randInt = 1
	setInterval(function(){
		randInt = Math.floor(Math.random() * 10)+1
	},30000)
	
    app.get('/', (req,res) => {
		res.set('Content-Type', 'text/plain')
		res.append('Access-Control-Allow-Origin', ['*'])

		res.send(randInt.toString())
    })
}