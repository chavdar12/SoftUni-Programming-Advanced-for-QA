import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as piccolo } from '../17.Piccolo.js';

describe('17.Piccolo', () => {
    it('17 tracks the parking lot', () => {
        expect(captureLog(() => piccolo([
            'IN, CA2844AA', 'IN, CA1234TA', 'OUT, CA2844AA', 'IN, CA9999TT', 'IN, CA2866HI',
            'OUT, CA1234TA', 'IN, CA2844AA', 'OUT, CA2866HI', 'IN, CA9876HH', 'IN, CA2822UU'
        ]))).to.deep.equal(['CA2822UU', 'CA2844AA', 'CA9876HH', 'CA9999TT']);
        expect(captureLog(() => piccolo(['IN, CA2844AA', 'OUT, CA2844AA']))).to.deep.equal(['Parking Lot is Empty']);
    });
});
