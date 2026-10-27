import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as countOccurrences } from '../06.CountStringOccurrences.js';

describe('06.CountStringOccurrences', () => {
    it('06 counts whole-word occurrences', () => {
        expect(captureLog(() => countOccurrences('This is a word and it also is a sentence', 'is')))
            .to.deep.equal(['2']);
    });
});
