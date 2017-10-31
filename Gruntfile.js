module.exports = function (grunt) {

    var projectRoot = 'website/js/';

    // config
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        uglify: {
            options: {
                banner: '/*! <%= pkg.name %> <%= grunt.template.today("yyyy-mm-dd") %> */\n'
            },
            build: {
                src: 'build/<%= pkg.name %>.debug.js',
                dest: 'build/prod/<%= pkg.name %>.min.js'
            }
        },
        concat: {
            options: {
                // separator: ';',
            },
            dist: {
                src: [
                    projectRoot + '**/*.js'],
                dest: 'build/<%= pkg.name %>.debug.js'
            }
        }
    });

    // plugins used
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-uglify');

    // default tasks
    grunt.registerTask('default', ['concat', 'uglify']);

};