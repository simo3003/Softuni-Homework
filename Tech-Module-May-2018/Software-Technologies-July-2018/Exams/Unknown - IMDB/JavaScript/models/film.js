const Sequelize = require('sequelize');

module.exports = function(sequelize){
    let Film = sequelize.define("Film", {
        name: {
            type: Sequelize.STRING
        },
        genre: {
            type: Sequelize.STRING
        },
        director: {
            type: Sequelize.STRING
        }, 
        year: {
            type: Sequelize.INTEGER
        }  
    })
    return Film;
};