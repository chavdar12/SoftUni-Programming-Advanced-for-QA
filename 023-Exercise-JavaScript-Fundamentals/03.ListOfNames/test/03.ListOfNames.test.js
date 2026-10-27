import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as listOfNames } from '../03.ListOfNames.js';

describe('03.ListOfNames', () => {
    it('03 prints names sorted and numbered', () => {
        expect(captureLog(() => listOfNames(['John', 'Bob', 'Christina', 'Ema'])))
            .to.deep.equal(['1.Bob', '2.Christina', '3.Ema', '4.John']);
    });
});
