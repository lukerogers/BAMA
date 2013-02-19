'use strict';

describe('AngularList App', function() {

    it('should redirect / to #/lists', function() {
        browser().navigateTo('../');
        expect(browser().location().url()).toBe('/lists');
    });
});