const express = require('express');
const path = require('path');
const bodyParser = require('body-parser');
const hbsHelpers = require('../helpers/handlebarsHelpers');


module.exports = (app, config) => {
    app.set('views', path.join(config.rootFolder, '/views'));
    app.set('view engine', 'hbs');
    app.use(bodyParser.json());
    app.use(bodyParser.urlencoded({extended: true}));
    app.use(express.static(path.join(config.rootFolder, 'assets')));
};



