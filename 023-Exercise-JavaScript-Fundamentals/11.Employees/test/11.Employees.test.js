import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as employees } from '../11.Employees.js';

describe('11.Employees', () => {
    it('11 prints employees with their personal numbers', () => {
        expect(captureLog(() => employees(['Silas Butler', 'Adnaan Buckley']))).to.deep.equal([
            'Name: Silas Butler -- Personal Number: 12',
            'Name: Adnaan Buckley -- Personal Number: 14'
        ]);
    });
});
