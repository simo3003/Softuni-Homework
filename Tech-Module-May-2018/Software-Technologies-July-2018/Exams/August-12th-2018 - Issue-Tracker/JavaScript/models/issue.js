const Sequelize = require('sequelize');

module.exports = function (sequelize) {
  let Issue = sequelize.define("Issue", {
    title: {
        type: Sequelize.TEXT,
    },
    content: {
        type: Sequelize.TEXT,
    },
    priority: {
        type: Sequelize.INTEGER,
    }
},{
    timestamps:false
});
return Issue;  
};