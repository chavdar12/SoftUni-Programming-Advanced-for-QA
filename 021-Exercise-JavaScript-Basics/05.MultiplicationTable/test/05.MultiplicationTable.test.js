import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as multiplicationTable } from '../05.MultiplicationTable.js';

describe('05.MultiplicationTable', () => {
    it('05 prints the multiplication table', () => {
        const lines = captureLog(() => multiplicationTable(5));
        expect(lines).to.have.length(10);
        expect(lines[0]).to.equal('5 X 1 = 5');
        expect(lines[9]).to.equal('5 X 10 = 50');
    });
});
