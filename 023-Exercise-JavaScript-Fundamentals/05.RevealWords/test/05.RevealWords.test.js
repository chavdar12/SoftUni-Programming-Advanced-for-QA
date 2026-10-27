import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as revealWords } from '../05.RevealWords.js';

describe('05.RevealWords', () => {
    it('05 fills in the starred templates', () => {
        expect(captureLog(() => revealWords('great, learning', 'softuni is ***** place for ******** new programming languages')))
            .to.deep.equal(['softuni is great place for learning new programming languages']);
    });
});
