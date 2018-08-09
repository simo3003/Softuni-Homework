const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Project = sequelize.define("Project", {
        Title: {
            type: Sequelize.TEXT,
        },
        Description: {
            type: Sequelize.TEXT,
        },
        Budget: {
            type: Sequelize.INTEGER,
        }
    }, {
            timestamps: false
        });
    return Project;
};