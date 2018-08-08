const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Cat = sequelize.define("Cat",{
        name: {
            type: Sequelize.TEXT,
        },
        nickname: {
            type: Sequelize.STRING,
        },
        price: {
            type: Sequelize.DOUBLE,
        }
    },{
        timestamps:false
    });

    return Cat;
};