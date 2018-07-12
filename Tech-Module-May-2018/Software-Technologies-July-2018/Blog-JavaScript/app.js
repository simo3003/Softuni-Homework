const express = require('express');
const config = require('./config/config.js');
const app = express();

require('./config/express')(app, config);
require('./config/passport')();
require('./config/routes')(app);

module.exports = app;
