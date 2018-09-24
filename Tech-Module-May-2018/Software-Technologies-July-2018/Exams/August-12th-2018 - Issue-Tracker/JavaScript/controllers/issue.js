const Issue = require('../models').Issue;

module.exports = {
    index: (req, res) => {
        Issue.findAll()
            .then(issues => {
                res.render('issue/index', { issues: issues });
            });
    },

    createGet: (req, res) => {
        res.render('issue/create');
    },

    createPost: (req, res) => {
        let args = req.body.issue;
        Issue.create(args)
            .then((issue) => {
                res.redirect('/');
            });
    },

    editGet: (req, res) => {
        let id = req.params.id;
        Issue.findById(id)
            .then(issue => {
                res.render('issue/edit', { issue: issue.dataValues });
            })
    },

    editPost: (req, res) => {
        let args = req.body.issue;
        let id = req.params.id;
        Issue.findById(id)
            .then(issue => {
                issue.updateAttributes(args)
                    .then(() => res.redirect('/'));
            });
    },

    deleteGet: (req, res) => {
        let id = req.params.id;
        Issue.findById(id)
            .then(issue => {
                res.render('issue/delete', { issue: issue.dataValues });
            })
    },

    deletePost: (req, res) => {
        let id = req.params.id;
        Issue.findById(id)
            .then(issue => {
                issue.destroy()
                    .then(() => res.redirect('/'));
            });
    }
};