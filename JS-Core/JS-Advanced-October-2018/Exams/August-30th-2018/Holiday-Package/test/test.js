let expect = require('chai').expect;
let should = require('chai').should();

let HolidayPackage = require('../HolidayPackage');


describe('Holiday Package', function () {
    it('instantiates an object', function () {
        let holidayPackage = new HolidayPackage('Italy', 'Summer');

        holidayPackage.should.have.property('vacationers').eql([]);
        holidayPackage.should.have.property('destination').equal('Italy');
        holidayPackage.should.have.property('season').equal('Summer');
        holidayPackage.should.have.property('insuranceIncluded').equal(false);
    });

    it('doesn\'t show vacationers if there aren\'t any', function () {
        let holidayPackage = new HolidayPackage('Italy', 'Summer');

        expect(holidayPackage.showVacationers()).to.equal('No vacationers are added yet');
    });

    it('gives an error when trying to add a vacationer with invalid input', function () {
        let holidayPackage = new HolidayPackage('Italy', 'Summer');

        try {
            holidayPackage.addVacationer(' ');
        } catch (err) {
            expect(err.toString()).to.equal('Error: Vacationer name must be a non-empty string');
        }

        try {
            holidayPackage.addVacationer(1);
        } catch (err) {
            expect(err.toString()).to.equal('Error: Vacationer name must be a non-empty string');
        }

        try {
            holidayPackage.addVacationer(true);
        } catch (err) {
            expect(err.toString()).to.equal('Error: Vacationer name must be a non-empty string');
        }
        
        try {
            holidayPackage.addVacationer('Gosho');
        } catch (err) {
            expect(err.toString()).to.equal('Error: Name must consist of first name and last name');
        }

    });

    it('adds vactioners', function () {
        let holidayPackage = new HolidayPackage('Italy', 'Summer');

        holidayPackage.addVacationer('Ivan Ivanov');
        holidayPackage.addVacationer('Petar Petrov');
        holidayPackage.addVacationer('Georgi Georgiev');

        expect(holidayPackage.vacationers).to.eql(['Ivan Ivanov', 'Petar Petrov', 'Georgi Georgiev']);
    });

    it('prints out the vacationers', function () {
        let holidayPackage = new HolidayPackage('Italy', 'Summer');

        holidayPackage.addVacationer('Ivan Ivanov');
        holidayPackage.addVacationer('Petar Petrov');
        holidayPackage.addVacationer('Georgi Georgiev');

        expect(holidayPackage.showVacationers()).to.equal('Vacationers:\nIvan Ivanov\nPetar Petrov\nGeorgi Georgiev');
    });

    it('gives an error when adding an insurance with an invalid input', function() {
        let holidayPackage = new HolidayPackage('Italy', 'Summer');

        try {
            holidayPackage.insuranceIncluded = 'true';
        } catch (err) {
            expect(err.toString()).to.equal('Error: Insurance status must be a boolean');
        }
    });
    
    it('adds insurance', function() {
        let holidayPackage = new HolidayPackage('Italy', 'Summer');

        holidayPackage.insuranceIncluded = true;
        
        holidayPackage.should.have.property('_insuranceIncluded').equal(true);
    });

    it('generates a holiday package', function () {
        let holidayPackage = new HolidayPackage('Italy', 'Summer');

        holidayPackage.addVacationer('Ivan Ivanov');
        holidayPackage.addVacationer('Petar Petrov');
        holidayPackage.addVacationer('Georgi Georgiev');

        holidayPackage.insuranceIncluded = true;
        expect(holidayPackage.generateHolidayPackage()).to.equal('Holiday Package Generated\nDestination: Italy\nVacationers:\nIvan Ivanov\nPetar Petrov\nGeorgi Georgiev\nPrice: 1500')

        holidayPackage.insuranceIncluded = false;
        expect(holidayPackage.generateHolidayPackage()).to.equal('Holiday Package Generated\nDestination: Italy\nVacationers:\nIvan Ivanov\nPetar Petrov\nGeorgi Georgiev\nPrice: 1400')

        holidayPackage.season = 'Autumn';
        expect(holidayPackage.generateHolidayPackage()).to.equal('Holiday Package Generated\nDestination: Italy\nVacationers:\nIvan Ivanov\nPetar Petrov\nGeorgi Georgiev\nPrice: 1200')
    });

    it('gives an error when trying to make a holiday package without vacationers', function () {
        let holidayPackage = new HolidayPackage('Italy', 'Summer');
        try {
            holidayPackage.generateHolidayPackage();
        } catch (err) {
        expect(err.toString()).to.equal('Error: There must be at least 1 vacationer added')
        }
    });
})